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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="urlType"></param>
        /// <returns></returns>
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
        /// <param name="reportID"></param>
        /// <returns></returns>
        public List<Report> getReport(int reportID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("projetoDB")))
            {
                try
                {
                    var retrievedList = connection.Query<Report>("dbo.p_getReport @reportID", new { reportID = reportID }).ToList();
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
        /// <param name="playerID"></param>
        /// <returns></returns>
        public List<Report> getPlayerReports(int playerID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("projetoDB")))
            {
                try
                {
                    var retrievedList = connection.Query<Report>("dbo.p_getPlayerReports @playerID", new { playerID = playerID}).ToList();
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
        /// 
        /// </summary>
        /// <param name="playerID"></param>
        /// <param name="scoutID"></param>
        public void insertReport(int playerID, int scoutID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("projetoDB")))
            {
                try
                {
                    List<Report> positions = new List<Report>();
                    positions.Add(new Report { ID_Jogador = playerID, ID_Observador = scoutID});
                    connection.Execute("dbo.p_insertReport @ID_Jogador, @ID_Observador", positions);
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
                    list.Add(new URL {URL_Externo = url, URL_Type = urltype});
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
        public void insertCategoryEvaluation(int categoryID, int reportID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("projetoDB")))
            {
                try
                {
                    List<CategoryEvaluation> list = new List<CategoryEvaluation>();
                    list.Add(new CategoryEvaluation { CategoryID = categoryID, Rate = 0, ReportID = reportID });
                    connection.Execute("dbo.p_insertCategoryEvaluation @ReportID, @CategoryID", list);
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
        /// <param name="report"></param>
        public void updateReport(int reportID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("projetoDB")))
            {
                try
                {
                    connection.Execute("dbo.p_updateReport @reportID", new {reportID = reportID });
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
        public void updateCategoryEvaluation(int categoryID, int reportID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("projetoDB")))
            {
                try
                {
                    connection.Execute("dbo.p_updateCategoryEvaluation @categoryID, @reportID", new { categoryID = categoryID ,reportID = reportID });
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
        /// <param name="newValue"></param>
        public void updateAttributeEvaluation(int attributeID, int reportID, int newValue)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("projetoDB")))
            {
                try
                {
                    connection.Execute("dbo.p_updateAttributeEvaluation @attributeID, @reportID, @newValue", new {attributeID = attributeID, reportID = reportID, newValue = newValue });
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
        /// <param name="oldpassword"></param>
        /// <param name="newpassword"></param>
        public void updatePassword(string username, string oldpassword, string newpassword)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("projetoDB")))
            {
                try
                {
                    connection.Execute("dbo.p_updatePassword @username, @oldpassword, @newpassword", new { username = username, oldpassword = oldpassword, newpassword = newpassword});
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
        /// <param name="newUsername"></param>
        public void updateUsername(string username, string newUsername)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("projetoDB")))
            {
                try
                {
                    connection.Execute("dbo.p_updateUsername @username, @newUsername", new { username = username, newUsername = newUsername});
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
        /// <param name="newEmail"></param>
        public void updateUserEmail(string username, string newEmail)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("projetoDB")))
            {
                try
                {
                    connection.Execute("dbo.p_updateUserEmail @username, @newEmail", new { username = username, newEmail = newEmail });
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
        /// <param name="playerID"></param>
        /// <param name="clubName"></param>
        public void updatePlayerClub(int playerID, string clubName, Boolean isAdmin)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("projetoDB")))
            {
                try
                {
                    connection.Execute("dbo.p_updatePlayerClub @playerID, @clubName @isAdmin", new { playerID = playerID, clubName = clubName, isAdmin = isAdmin });
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
        /// <param name="playerID"></param>
        /// <param name="playerName"></param>
        public void updatePlayerName(int playerID, string playerName, Boolean isAdmin)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("projetoDB")))
            {
                try
                {
                    connection.Execute("dbo.p_updatePlayerName @playerID, @playerName, @isAdmin", new { playerID = playerID, playerName = playerName, isAdmin = isAdmin});
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
        /// <param name="playerID"></param>
        /// <param name="playerURL"></param>
        public void updatePlayerURL(int playerID, string playerURL, Boolean isAdmin)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("projetoDB")))
            {
                try
                {
                    connection.Execute("dbo.p_updatePlayerURL @playerID, @playerURL, @isAdmin", new { playerID = playerID, playerURL = playerURL, isAdmin = isAdmin});
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
        /// <param name="playerID"></param>
        public void deletePlayer(int playerID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("projetoDB")))
            {
                try
                {
                    connection.Execute("dbo.p_deletePlayerProcedure @playerID", new {playerID = playerID });
                }
                catch (System.Data.SqlClient.SqlException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        // TODO delete this
        public List<T> getAnything<T>(string tableName, string member, string primaryKey)
        {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("projetoDB")))
                {
                    String query = String.Format("select * from {0} where {1}='{2}';",tableName,primaryKey,member);
                    var output = connection.Query<T>(query).ToList();
                    return output;
                }
        }
    }
}
