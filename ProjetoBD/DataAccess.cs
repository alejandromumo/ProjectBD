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

        /// <summary>
        /// Establishes a connection with LocalDB/projetoDB and queries it looking for a League with given parameters, 
        /// using p_getLeagueByname Stored Procedure.
        /// </summary>
        /// <param name="leagueName"></param>
        /// <returns></returns>
        public List<League> getLeagueByName(string leagueName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("projetoDB")))
            {
                try
                {
                    var retrievedLeagues = connection.Query<League>("dbo.p_getLeagueByName @leagueName", new { leagueName = leagueName }).ToList();
                    return retrievedLeagues;

                }
                catch (System.Data.SqlClient.SqlException e)
                {
                    Console.WriteLine(e.Message);
                    return null;
                }
            }
        }

        /// <summary>
        /// Establishes a connection with LocalDB/projetoDB and queries it looking for a Club with given parameters, 
        /// using p_getClubByname Stored Procedure.        /// </summary>
        /// <param name="clubName"></param>
        /// <returns></returns>
        public List<Club> getClubByName(string clubName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("projetoDB")))
            {
                try
                {
                    var retrievedClubs = connection.Query<Club>("dbo.p_getClubByName @clubName", new { clubName = clubName }).ToList();
                    return retrievedClubs;

                }
                catch (System.Data.SqlClient.SqlException e)
                {
                    Console.WriteLine(e.Message);
                    return null;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="playerName"></param>
        /// <returns></returns>
        public List<Jogador> getPlayerByName(string playerName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("projetoDB")))
            {
                try
                {
                    var retrievedPlayers = connection.Query<Jogador>("dbo.p_getPlayerByName @playerName", new { playerName = playerName }).ToList();
                    return retrievedPlayers;

                }
                catch (System.Data.SqlClient.SqlException e)
                {
                    Console.WriteLine(e.Message);
                    return null;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="positionName"></param>
        /// <returns></returns>
        public List<Posição> getPositionByName(string positionName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("projetoDB")))
            {
                try
                {
                    var retrievedPosition = connection.Query<Posição>("dbo.p_getPositionByName @positionName", new { positionName = positionName }).ToList();
                    return retrievedPosition;

                }
                catch (System.Data.SqlClient.SqlException e)
                {
                    Console.WriteLine(e.Message);
                    return null;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public List<Categoria> getPositionCategoriesByName(string position)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("projetoDB")))
            {
                try
                {
                    var retrievedPosition = connection.Query<Categoria>("dbo.p_getPositionCategoriesByName @position", new { position = position }).ToList();
                    return retrievedPosition;

                }
                catch (System.Data.SqlClient.SqlException e)
                {
                    Console.WriteLine(e.Message);
                    return null;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public List<Atributo> getCategoryAttributesByName(string position, string category)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("projetoDB")))
            {
                try
                {
                    var retrievedAttributes = connection.Query<Atributo>("dbo.p_getCategoryAttributesByName @categoryName, @position", new { categoryName = category, position = position }).ToList();
                    return retrievedAttributes;

                }
                catch (System.Data.SqlClient.SqlException e)
                {
                    Console.WriteLine(e.Message);
                    return null;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="clubName"></param>
        /// <returns></returns>
        public List<Jogador> getClubPlayers(string clubName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("projetoDB")))
            {
                try
                {
                    var retrievedAttributes = connection.Query<Jogador>("dbo.p_getClubPlayers @ClubName", new { ClubName = clubName}).ToList();
                    return retrievedAttributes;

                }
                catch (System.Data.SqlClient.SqlException e)
                {
                    Console.WriteLine(e.Message);
                    return null;
                }
            }
        }

        public List<URL> getURL(string urlType)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("projetoDB")))
            {
                try
                {
                    var retrievedList = connection.Query<URL>("dbo.p_getURL @urlType", new { urlType  = urlType}).ToList();
                    return retrievedList;

                }
                catch (System.Data.SqlClient.SqlException e)
                {
                    Console.WriteLine(e.Message);
                    return null;
                }
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="username"></param>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public List<Utilizador> loginUser(string username, string email, string password)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("projetoDB")))
            {
                try
                {
                    var retrievedUser = connection.Query<Utilizador>("dbo.p_loginuser @userName, @email, @password", new { userName = username, email = email, password = password }).ToList();
                    return retrievedUser;

                }
                catch (System.Data.SqlClient.SqlException e)
                {
                    Console.WriteLine(e.Message);
                    return null;
                }
            }
        }

        /// <summary>
        /// Establishes a connection with LocalDB/projetoDB and tries to insert a Sport into it with given parameters, 
        /// using p_insertSportByName Stored Procedure.
        /// </summary>
        /// <param name="sportName"></param>
        /// <param name="URL"></param>
        public void insertSport(string sportName, string URL)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("projetoDB")))
            {
                try
                {
                    List<Sport> sports = new List<Sport>();
                    sports.Add(new Sport { SportName = sportName, URL = URL });
                    connection.Execute("dbo.p_insertSportByName @SportName, @URL", sports);
                }
                catch (System.Data.SqlClient.SqlException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        /// <summary>
        /// Establishes a connection with LocalDB/projetoDB and tries to insert a League into it with given parameters, 
        /// using p_insertLeagueByName Stored Procedure.
        /// </summary>
        /// <param name="leagueName"></param>
        /// <param name="date"></param>
        /// <param name="country"></param>
        /// <param name="url"></param>
        /// <param name="sportName"></param>
        public void insertLeague(string leagueName, DateTime date, string country, string url, string sportName, int ID_Externo)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("projetoDB")))
            {
                try
                {
                    Console.WriteLine($"{leagueName} {sportName}");
                    List<League> leagues = new List<League>();
                    leagues.Add(new League { LeagueName = leagueName, Date = date, SportName = sportName, Country = country, URL = url, ID_Externo = ID_Externo });
                    connection.Execute("dbo.p_insertLeagueByName @LeagueName, @Date, @Country, @URL, @SportName, @ID_Externo", leagues);
                }
                catch (System.Data.SqlClient.SqlException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        /// <summary>
        /// Establishes a connection with LocalDB/projetoDB and tries to insert a Club into it with given parameters, 
        /// using p_insertClubByName Stored Procedure.        /// </summary>
        /// <param name="clubName"></param>
        /// <param name="leagueName"></param>
        /// <param name="date"></param>
        /// <param name="City"></param>
        /// <param name="url"></param>
        public void insertClub(string clubName, string leagueName, DateTime date, string City, string url, int ID_Externo)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("projetoDB")))
            {
                try
                {
                    Console.WriteLine($"{clubName} {leagueName}");
                    List<Club> list = new List<Club>();
                    list.Add(new Club {ClubName = clubName, LeagueName = leagueName, Date = date, City = City, URL = url, ID_Externo = ID_Externo });
                    connection.Execute("dbo.p_insertClubByName @ClubName, @LeagueName, @Date, @City, @URL, @ID_Externo", list);
                }
                catch (System.Data.SqlClient.SqlException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        /// <summary>
        /// Establishes a connection with LocalDB/projetoDB and tries to insert a Player into it with given parameters, 
        /// using p_insertPlayerByName Stored Procedure.
        /// </summary>
        /// <param name="playerName"></param>
        /// <param name="clubName"></param>
        /// <param name="position"></param>
        /// <param name="url"></param>
        /// <param name="nationality"></param>
        /// <param name="birthdate"></param>
        /// <param name="height"></param>
        /// <param name="weight"></param>
        public void insertPlayer(string playerName, string clubName, string position, string url, string nationality, DateTime? birthdate, int? height, int? weight, int? ID_Externo)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("projetoDB")))
            {
                try
                {
                    Console.WriteLine($"{playerName} {clubName} {position} {url}");
                    List<Jogador> players = new List<Jogador>();
                    players.Add(new Jogador
                    {
                        playerName = playerName,
                        clubName = clubName,
                        position = position,
                        Nationality = nationality,
                        BirthDate = birthdate,
                        Height = height,
                        Weight = weight,
                        URL = url,
                        ID_Externo = ID_Externo
                    });

                    connection.Execute("dbo.p_insertPlayerByName @playerName, @clubName, @position, @URL, @Nationality, @BirthDate, @Height, @Weight, @ID_Externo", players);

                }
                catch (System.Data.SqlClient.SqlException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        /// <summary>
        /// Establishes a connection with LocalDB/projetoDB and tries to insert a Position into it with given parameters, 
        /// using p_insertPosition Stored Procedure.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="sportName"></param>
        public void insertPosition(string name, string sportName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("projetoDB")))
            {
                try
                {
                    List<Posição> positions = new List<Posição>();
                    positions.Add(new Posição {Position = name, SportName = sportName });
                    connection.Execute("dbo.p_insertPosition @Position, @SportName", positions);
                }
                catch (System.Data.SqlClient.SqlException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        /// <summary>
        /// Establishes a connection with LocalDB/projetoDB and tries to insert a URL into it with given parameters, 
        /// using p_insertURL Stored Procedure.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="urltype"></param>
        public void insertURL(string url, string urltype)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("projetoDB")))
            {
                try
                {
                    List<URL> list = new List<URL>();
                    list.Add(new URL {url = url, URL_Type = urltype});
                    connection.Execute("dbo.p_insertURL @URL, @URLType", list);
                }
                catch (System.Data.SqlClient.SqlException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="username"></param>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <param name="birthDate"></param>
        /// <param name="role"></param>
        public void insertUser(string username, string email, string password, DateTime? birthDate, string role)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("projetoDB")))
            {
                try
                {
                    List<Utilizador> list = new List<Utilizador>();
                    list.Add(new Utilizador { userName = username, email = email, birthDate = birthDate, password = password, role = role });
                    connection.Execute("dbo.p_insertUser @userName, @email, @password, @birthDate, @role", list);
                }
                catch (System.Data.SqlClient.SqlException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="attributeID"></param>
        /// <param name="reportID"></param>
        /// <param name="rate"></param>
        public void insertAttributeEvaluation(int attributeID, int reportID, int rate)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("projetoDB")))
            {
                try
                {
                    List<AttributeEvaluation> list = new List<AttributeEvaluation>();
                    list.Add(new AttributeEvaluation { AttributeID = attributeID, Rate = rate, ReportID = reportID });
                    connection.Execute("dbo.p_insertAttributeEvaluation @ReportID, @AttributeID, @Rate", list);
                }
                catch (System.Data.SqlClient.SqlException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="categoryID"></param>
        /// <param name="reportID"></param>
        /// <param name="rate"></param>
        public void insertCategoryEvaluation(int categoryID, int reportID, int rate)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("projetoDB")))
            {
                try
                {
                    List<CategoryEvaluation> list = new List<CategoryEvaluation>();
                    list.Add(new CategoryEvaluation { CategoryID = categoryID, Rate = rate, ReportID = reportID });
                    connection.Execute("dbo.p_insertCategoryEvaluation @ReportID, @CategoryID, @Rate", list);
                }
                catch (System.Data.SqlClient.SqlException e)
                {
                    Console.WriteLine(e.Message);
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
