using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace ProjetoBD
{
    public class DataAccess
    {
        public List<Report> getReports()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("projetoDB")))
            {
                var output = connection.Query<Report>($"select * from Observação").ToList();
                return output;
            }
        }

        public List<Person> getPeople(string name)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("projetoDB")))
            {
                var output = connection.Query<Person>($"select * from Clube").ToList();
                return output;
            }
        }

        public void insertPerson(string name, int ID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("projetoDB")))
            {
                try
                {
                    String query = String.Format("insert into Pessoa(Nome, ID) values('{0}', '{1}');", name, ID);
                    connection.Execute(query);
                    Console.WriteLine($"Person {name} successfully inserted into DB");
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    Console.WriteLine($"Person {name} already exists");
                }
            }
        }

        public void insertPosition(string name)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("projetoDB")))
            {
                try
                {
                    String query = String.Format("insert into Posição(Nome, Nome_Desporto) values('{0}, '{1}');", name, "Football");
                    connection.Execute(query);
                    Console.WriteLine($"Position {name} successfully inserted into DB");
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    Console.WriteLine($"Position {name} already exists");
                }
            }
        }

        public void insertLeague(string leagueName, string country = null, string sport = null, string url = null)
        {
            if (getAnything<URL>("URL_Externo", url, "URL_Externo").Count == 0)
                insertURL(url, "League");
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("projetoDB")))
            {
                try
                {
                    String query = String.Format("insert into Liga(Nome, Nome_Desporto, URL_Externo, País) values('{0}', '{1}', '{2}', '{3}');", leagueName, sport, url, country);
                    connection.Execute(query);
                    Console.WriteLine($"League {leagueName} successfully inserted into DB");
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    Console.WriteLine($"League {leagueName} already exists");
                }
            }
        }

        public void insertURL(string url, string urltype)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("projetoDB")))
            {
                try
                {
                    String query = String.Format("insert into URL_Externo(URL_Externo, Data_Criação, URL_Type) values('{0}', GETDATE(), '{1}');", url, urltype);
                    connection.Execute(query);
                    Console.WriteLine($"URL {url} successfully inserted into DB");
                }
                catch (System.Data.SqlClient.SqlException except)
                {
                    Console.WriteLine($"URL {url}  not inserted into DB due to {except.Message}");
                }
            }
        }

        public void insertClub(string clubName, string sport, string url, string leagueName)
        {
            if(getAnything<URL>("URL_Externo", url, "URL_Externo").Count == 0)
                insertURL(url, "Club");

            if (getAnything<League>("Liga", leagueName, "Nome").Count == 0)
                insertLeague(leagueName, null, sport, null);

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("projetoDB")))
            {
                try
                {
                    String query = String.Format("insert into Clube(Nome, Nome_Desporto, URL_Externo, Nome_Liga) values('{0}', '{1}', '{2}', '{3}');", clubName, sport, url, leagueName);
                    connection.Execute(query);
                    Console.WriteLine($"Club {clubName} successfully inserted into DB");
                }
                catch (System.Data.SqlClient.SqlException except)
                {
                    Console.WriteLine($"Club {clubName} not inserted into DB due to {except.Message}");
                }
            }
        }

        public void insertPlayer(string name, string clubName, string url, string position, int ID)
        {
            if (getAnything<URL>("URL_Externo", url, "URL_Externo").Count == 0)
                insertURL(url, "Player");

            if (getAnything<Club>("Clube", clubName, "Nome").Count == 0)
                insertClub(clubName, null, "Football", null);

            if (getAnything<Person>("Pessoa", ID.ToString(), "ID").Count == 0)
                insertPerson(name, ID);

            if (getAnything<Posição>("Posição", position, "Designação").Count == 0)
                insertPosition(position);

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("projetoDB")))
            {
                try
                {
                    String query = String.Format("insert into Jogador(ID, Nome, Nome_Clube, Nome_Desporto, URL_Externo, Designação_Posição) values('{0}', '{1}', '{2}', '{3}','{4},'{5});", ID, name, clubName, "Football", url, position);
                    connection.Execute(query);
                    Console.WriteLine($"Player {name} successfully inserted into DB");
                }
                catch (System.Data.SqlClient.SqlException except)
                {
                    Console.WriteLine($"Player {name} not inserted into DB due to {except.Message}");
                }
            }
        }

        public List<T> getAnything<T>(string tableName, string member, string primaryKey)
        {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("projetoDB")))
                {
                    String query = String.Format("select * from {0} where {1}='{2}';",tableName,primaryKey,member);
                    var output = connection.Query<T>(query).ToList();
                    return output;
                }
         // C: \Users\mumox\Desktop\clubs_final.csv
        }
    }
}
