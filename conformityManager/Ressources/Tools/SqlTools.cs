using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Windows.Media.Imaging;
using conformityManager.Ressources.Structures;
using MySql.Data.MySqlClient;

namespace conformityManager.Ressources.Tools
{
    public class SqlTools
    {
        private string MySQLConnectionString;// = "datasource=127.0.0.1;port=3306;username=root;password=;database=ncdb";
        // private string sqlQuery;
        private MySqlConnection DBConnection;
        private MySqlCommand sqlCmd;
        private MySqlDataReader sqlReader;

        public SqlTools()
        {
            DBConnection = new MySqlConnection();
            sqlCmd = new MySqlCommand("", DBConnection);
        }





        public void InitializeSqlTools(MainWindow mainWindow,string source, string port, string database, string username = "root", string password = "") // INITIALISING
        {
            DBConnection.Close();
            MySQLConnectionString = "datasource=" + source + ";port=" + port + ";username=" + username + ";password=" + password + ";database=" + database + "; convert zero datetime=True;"; // convert zero datetime=True : to support 0000-00-00 date value

            try
            {
                DBConnection.ConnectionString = MySQLConnectionString;
            }
            catch (Exception e)
            {
                mainWindow.newErrorMessageQueue("Server settings Error : " + e);
            }
        }


        public int IsSqlConnected(MainWindow mainWindow, string Query, int QueryType=0,Byte[] file=null,String fileName = "") // SQL CONNECTION and QUERY EXECUTION : return -1 if error
        {
            //Console.WriteLine(Query);
            try
            {
                if (DBConnection.State == ConnectionState.Open)// close existing open connection
                    DBConnection.Close();

                sqlCmd.CommandText = Query;
                DBConnection.Open();
                
                switch (QueryType)
                {
                    case 0: sqlReader = sqlCmd.ExecuteReader(); break; // For reading query
                    case 1: return sqlCmd.ExecuteNonQuery(); // For updating query : return updated row number
                    case 2: return Convert.ToInt32(sqlCmd.ExecuteScalar()); // For Insertion : return last insert id
                }
                return 0;
            }
            catch (MySqlException ex)
            {
                DBConnection.Close(); // close connection if still exist
                Console.WriteLine("Database error ::: " + ex.Message);
                mainWindow.newErrorMessageQueue("Database error : " + ex.Message);
                return -1;
            }
        }

        public static String AddSlash(String s) // To avoid SQL errors if the user typed a special character
        {
            return s.Replace("'", "\'");
        }

        public static String removeApostrophe(String s) // To avoid SQL errors if the user typed a special character
        {
            return s.Replace("'", "");
        }






// USER --------------------------------------------------------------------------------------------------------------------
// -------------------------------------------------------------------------------------------------------------------------

        public Nullable<User> LoginSQL(string username, string password, MainWindow mainWindow) // LOGIN
        {
            if (-1 != IsSqlConnected(mainWindow, "SELECT id,full_name,function,user_type FROM users WHERE username = '" + AddSlash(username) + "' AND password = '" + AddSlash(password) + "';"))
            {
                if (sqlReader.Read())
                {
                    return new User(
                        sqlReader.GetInt16("id"),
                        username,
                        sqlReader.GetString("full_name"),
                        sqlReader.GetString("function"),
                        sqlReader.GetBoolean("user_type"));
                }
                else
                    return new User(-1, "", "", "", false);
            }
            DBConnection.Close();
            return null;
        }

        public int DoesUserExistSQL(string username, MainWindow mainWindow) // CHECK USER EXIST
        {
            if (-1 != IsSqlConnected(mainWindow,"SELECT id FROM users WHERE username = '" + AddSlash(username) + "' LIMIT 1;"))
            {
                if (sqlReader.Read())
                    return 1;
                else
                    return 0;
            }
            DBConnection.Close();
            return -1; // in this case error
        }

        public List<User> GetUserListSQL(MainWindow mainWindow) // USER LIST
        {
            List<User> userlist = new List<User>();

            if (-1 != IsSqlConnected(mainWindow,"SELECT id,username,full_name,function,user_type FROM users WHERE user_type = 0 ;"))
            {
                while (sqlReader.Read())
                {
                    userlist.Add( new User(
                        sqlReader.GetInt16("id"),
                        sqlReader.GetString("username"),
                        sqlReader.GetString("full_name"),
                        sqlReader.GetString("function"),
                        sqlReader.GetBoolean("user_type")));
                }
            }
            DBConnection.Close();
            return userlist;
        }

        public bool CreateUserSQL(string username, string password,string full_name,string function, MainWindow mainWindow) // CREATE USER
        {
            string sqlRequest = "INSERT INTO users (username,password,full_name,function) VALUES ('" +
                AddSlash(username) + "','" +
                AddSlash(password) + "','" +
                AddSlash(full_name) + "','" +
                AddSlash(function) + "'); select last_insert_id();";

            int returnedId = IsSqlConnected(mainWindow, sqlRequest, 1);

            DBConnection.Close();

            if (returnedId > 0)
            {
                NewLogSQL(0, mainWindow.loginUser.Value.username, "Cree l'utilisateur "+ username, mainWindow);
                return true;// new User(returnedId, username, full_name, function);
            }
                
            else
                return false;
        }

        public bool RemoveUserSQL(int id, MainWindow mainWindow) // REMOVE USER
        {
            string sqlRequest = "DELETE FROM users WHERE id = " + id + ";";
            if (IsSqlConnected(mainWindow, sqlRequest, 1) > 0)
            {
                NewLogSQL(2, mainWindow.loginUser.Value.username, "Supprime l utilisateur Num "+ id, mainWindow);
                return true;
            }
            else
                DBConnection.Close();
            return false;
        }

        public bool UpdateUserSQL(int id,string username, string password, string full_name, string function, MainWindow mainWindow) // UPDATE USER
        {
            string query = "UPDATE users SET username = '" + AddSlash(username) + "', ";

            if (password.Length>0)
                query += "password = '" + AddSlash(password) + "', ";

            query += "full_name = '" + AddSlash(full_name) + "', function = '" + AddSlash(function) + "' WHERE id = "+id+";";

            int returnedId = IsSqlConnected(mainWindow,query, 1);

            DBConnection.Close();

            if (returnedId > 0)
            {
                NewLogSQL(1, mainWindow.loginUser.Value.username, 
                    "Modifie l utilisateur num " + id + 
                    " Utilisateur : "+ username +
                    (password.Length > 0 ? (" Mdp : " + password) : "") +
                    " Nom complet : " + full_name +
                    " Fonction : " + function
                    , mainWindow);
                return true;
            }
            else
                return false;
        }




// NcFile ------------------------------------------------------------------------------------------------------------------
// -------------------------------------------------------------------------------------------------------------------------

        public List<NcFile> GetNcFileListSQL(Boolean isHSE, MainWindow mainWindow, String SearchText = "", int validation = 0, int source=0, string StartCreationDate = "", string EndCreationDate="", int fixedNc = 0, string StartFixDate = "", string EndFixDate="") // NcFile LIST
        {
            List<NcFile> ncFilelist = new List<NcFile>();

            string querryString = "SELECT id,nc_user_id, state, nc_user_id, client, case_title, source, structure_name, creation_date, estimated_start_date, estimated_end_date, fix_date, is_valid, fix_user_id " +
                ",(SELECT full_name FROM users WHERE id = nc_user_id) AS full_name FROM ncfile WHERE type=" + isHSE;

            if(SearchText.Length>0) // search filter
            {
                querryString += " AND (case_title LIKE '%" + SearchText + "%'";
                querryString += " OR structure_name LIKE '%" + SearchText + "%'";
                querryString += " OR (SELECT full_name FROM users WHERE id = nc_user_id) LIKE '%" + SearchText + "%')";
            }

            if (validation > 0) // validation filter
                querryString += " AND is_valid = " + (validation - 1);

            if (source > 0) // source filter
                querryString += " AND source = " + (source - 1);

            if (fixedNc == 1) // fixed filter
                querryString += " AND fix_user_id IS NULL";
            else if (fixedNc == 2)
                querryString += " AND fix_user_id IS NOT NULL";
            

            // Creation Date
            if (!string.IsNullOrWhiteSpace(StartCreationDate) && !string.IsNullOrWhiteSpace(EndCreationDate))// in range
                querryString += " AND creation_date BETWEEN '" + StartCreationDate + "' AND '" + EndCreationDate + "'";
            else if (!string.IsNullOrWhiteSpace(StartCreationDate) && string.IsNullOrWhiteSpace(EndCreationDate))// greater than Date Start
                querryString += " AND creation_date >= '" + StartCreationDate + "'";
            else if (string.IsNullOrWhiteSpace(StartCreationDate) && !string.IsNullOrWhiteSpace(EndCreationDate))// less than Date End
                querryString += " AND creation_date <= '" + EndCreationDate + "'";


            // Creation Date
            if (!string.IsNullOrWhiteSpace(StartFixDate) && !string.IsNullOrWhiteSpace(EndFixDate))//in range
                querryString += " AND fix_date BETWEEN '" + StartFixDate + "' AND '" + EndFixDate + "'";
            else if (!string.IsNullOrWhiteSpace(StartFixDate) && string.IsNullOrWhiteSpace(EndFixDate))// greater than Date Start
                querryString += " AND fix_date >= '" + StartFixDate + "'";
            else if (string.IsNullOrWhiteSpace(StartFixDate) && !string.IsNullOrWhiteSpace(EndFixDate))// less than Date End
                querryString += " AND fix_date <= '" + EndFixDate + "'";


            querryString += " ORDER BY creation_date ASC;";
            



            if (-1 != IsSqlConnected(mainWindow,querryString))
            {
                while (sqlReader.Read())
                {
                    ncFilelist.Add(new NcFile(
                        sqlReader.GetInt16("id"),
                        sqlReader.GetInt16("nc_user_id"), 
                        sqlReader.GetInt16("state"),
                        sqlReader.GetString("full_name"),
                        sqlReader.GetString("client"),
                        sqlReader.GetString("case_title"),
                        sqlReader.GetBoolean("source"),
                        sqlReader.GetString("structure_name"),
                        sqlReader.GetString("creation_date"),
                        Convert.IsDBNull(sqlReader["estimated_start_date"]) ? "" : sqlReader.GetString("estimated_start_date"),
                        Convert.IsDBNull(sqlReader["estimated_end_date"]) ? "" : sqlReader.GetString("estimated_end_date"),
                        Convert.IsDBNull(sqlReader["fix_date"]) ? "" : sqlReader.GetString("fix_date"),
                        sqlReader.GetBoolean("is_valid"),
                        //sqlReader.GetInt16("fix_user_id")
                        sqlReader.IsDBNull(13) ? -1 : sqlReader.GetInt16("fix_user_id")
                        ));
                }
            }
            DBConnection.Close();

            return ncFilelist;
        }

        public Nullable<NcFileDetails> GetNcFileDetailSQL(int id, MainWindow mainWindow) // NcFile Detail
        {
            Nullable<NcFileDetails> ncFileDetails = null;

            string querryString = "SELECT description, n_plan, partial_set FROM ncfile WHERE id=" + id + ";";

            if (-1 != IsSqlConnected(mainWindow,querryString) && sqlReader.Read())
            {
                    ncFileDetails = new NcFileDetails(
                        sqlReader.GetString("n_plan"),
                        sqlReader.GetString("partial_set"), 
                        sqlReader.GetString("description"));
            }
            DBConnection.Close();

            return ncFileDetails;
        }

        public Nullable<NcFileFix> GetNcFileFixSQL(int id, MainWindow mainWindow) // NcFile Detail
        {
            Nullable <NcFileFix> ncFileFix = null;

            string querryString = "SELECT cause, action_description, action_type, fixer_full_name, fixer_function, fixer_structure_name, estimated_start_date, estimated_end_date, fix_date FROM ncfile WHERE id=" + id + ";";

            if (-1 != IsSqlConnected(mainWindow,querryString) && sqlReader.Read())
            {
                ncFileFix = new NcFileFix(
                    sqlReader.IsDBNull(0) ? "" : sqlReader.GetString("cause"),
                    // sqlReader.IsDBNull(1) ? -1 : sqlReader.GetInt16("fix_user_id"),
                    sqlReader.IsDBNull(1) ? "" : sqlReader.GetString("action_description"),
                    sqlReader.IsDBNull(2) ? -1 : sqlReader.GetInt16("action_type"),
                    sqlReader.IsDBNull(3) ? "" : sqlReader.GetString("fixer_full_name"),
                    sqlReader.IsDBNull(4) ? "" : sqlReader.GetString("fixer_function"),
                    sqlReader.IsDBNull(5) ? "" : sqlReader.GetString("fixer_structure_name"),
                    sqlReader.IsDBNull(6) ? "" : sqlReader.GetString("estimated_start_date"),
                    sqlReader.IsDBNull(7) ? "" : sqlReader.GetString("estimated_end_date"),
                    sqlReader.IsDBNull(8) ? "" : sqlReader.GetString("fix_date"));
            }
            DBConnection.Close();

            return ncFileFix;
        }

        public int CreateNcFileSQL(int nc_user_id,bool type, string case_title, string n_plan, string partial_set, string client, string structure_name, int source, string description, MainWindow mainWindow) // CREATE NcFile
        {
            string sqlRequest = "INSERT INTO ncfile (nc_user_id, type, case_title, n_plan, partial_set, client, structure_name, source, description, creation_date) VALUES (" +
                nc_user_id + "," +
                type + ",'" +
                AddSlash(case_title) + "','" +
                AddSlash(n_plan) + "','" +
                AddSlash(partial_set) + "','" +
                AddSlash(client) + "','" +
                AddSlash(structure_name) + "'," +
                source + ",'" +
                AddSlash(description) +
                "', NOW()); select last_insert_id();";
            int returnedId = IsSqlConnected(mainWindow, sqlRequest, 2);

            DBConnection.Close();
            if(returnedId > 0)
                NewLogSQL(0, mainWindow.loginUser.Value.username, "Cree Nc Num : " + returnedId, mainWindow);

            return returnedId;// > 0 ? true : false;
        }

        public bool RemoveNcFileSQL(int id, MainWindow mainWindow) // REMOVE NcFile
        {
            string sqlRequest = "DELETE FROM ncfile WHERE id = " + id + ";";
            if (IsSqlConnected(mainWindow, sqlRequest, 1) > 0)
            {
                NewLogSQL(2, mainWindow.loginUser.Value.username, "Supprime NC num : " + id, mainWindow);
                return true;
            }
            else
                DBConnection.Close();
            return false;
        }


        // FIX NcFile
        public bool addNcFileFix(int id,int fix_user_id, string Cause, string action_description, bool action_type, string fixer_full_name, string fixer_function, string fixer_structure_name, string estimated_start_date, string estimated_end_date, MainWindow mainWindow)
        {
            string query = "UPDATE ncfile SET" +
                " fix_user_id = "+ fix_user_id + "," +
                " cause = '" + AddSlash(Cause) + "'," +
                " action_description = '" + AddSlash(action_description) + "'," +
                " action_type = '" + action_type + "'," +
                " fixer_full_name = '" + AddSlash(fixer_full_name) + "'," +
                " fixer_function = '" + AddSlash(fixer_function) + "'," +
                " fixer_structure_name = '" + AddSlash(fixer_structure_name) + "'," +
                " estimated_start_date = '" + estimated_start_date + "'," +
                " estimated_end_date = '" + estimated_end_date + "'," +
                " state = 1"+
                " WHERE id = " + id + ";";

            int returnedId = IsSqlConnected(mainWindow,query, 1);

            DBConnection.Close();

            if (returnedId > 0)
            {
                NewLogSQL(1, mainWindow.loginUser.Value.username, "Leve NC Num : "+id, mainWindow);
                return true;
            }
                
            else
                return false;
        }

        public bool validateNcFileFix(int id, bool isValid, MainWindow mainWindow)
        {
            string query = "UPDATE ncfile SET is_valid = " + isValid;
            if (!isValid)
                query += " ,state = 1 , fix_date = NULL";
                
            query += " WHERE id = " + id + ";";

            int returnedId = IsSqlConnected(mainWindow,query, 1);

            DBConnection.Close();

            if (returnedId > 0)
            {
                NewLogSQL(1, mainWindow.loginUser.Value.username, "Valide NC num : " + id, mainWindow);
                return true;
            }
            else
                return false;
        }


        public bool finaliseNcFileFix(int id, MainWindow mainWindow)
        {
            string query = "UPDATE ncfile SET state = 2, fix_date = NOW() WHERE id = " + id + ";";

            int returnedId = IsSqlConnected(mainWindow, query, 1);

            DBConnection.Close();

            if (returnedId > 0)
            {
                NewLogSQL(1, mainWindow.loginUser.Value.username, "Realise NC num : " + id, mainWindow);
                return true;
            }
            else
                return false;
        }


        public bool resetNcFileFix(int id, MainWindow mainWindow)
        {

            string query = "UPDATE ncfile SET" +
                " fix_user_id = NULL," +
                " cause = NULL," +
                " action_description = NULL," +
                " action_type = NULL," +
                " fixer_full_name = NULL," +
                " fixer_function = NULL," +
                " fixer_structure_name = NULL," +
                " estimated_start_date = NULL," +
                " estimated_end_date = NULL ," +
                " is_valid = 0 ,"+
                " state = 0 ," +
                " fix_date = NULL" +
                " WHERE id = " + id + ";";

            int returnedId = IsSqlConnected(mainWindow,query, 1);

            DBConnection.Close();

            if (returnedId > 0)
            {
                NewLogSQL(1, mainWindow.loginUser.Value.username, " Reinitialise NC num : "+ id, mainWindow);
                return true;
            }
            else
                return false;
        }



        // IMAGES
        public List<BitmapImage> GetImageListSQL(int ncfile_id, MainWindow mainWindow) // NcFile Detail
        {
            List<BitmapImage> imageList = new List<BitmapImage>();

            string querryString = "SELECT imageFile, file_name, extension FROM imagedb WHERE ncfile_id=" + ncfile_id + ";";

            if (-1 != IsSqlConnected(mainWindow, querryString))// && sqlReader.Read())
                while (sqlReader.Read())
                {
                    imageList.Add(GeneralTools.BytessToImage((byte[])sqlReader["imageFile"]));
                }
            DBConnection.Close();

            return imageList;
        }

        public bool CreateImageSQL(int ncfile_id , List<ImageFile> imageByteArrayList, MainWindow mainWindow) // CREATE USER
        {
            String Querry = "INSERT INTO imagedb (ncfile_id,file_name,extension,imageFile) VALUES ";// (" + ncfile_id + ",?); select last_insert_id();";

            /*sqlCmd.Parameters.AddWithValue("@imageFile", imageByteArray);
            sqlCmd.Parameters.AddRange(0, imageByteArray);*/
            
            if(imageByteArrayList.Count > 0)
            {
                for (int i = 0; i < imageByteArrayList.Count; i++)
                {
                    Querry += "(" + ncfile_id + " ,'"+ AddSlash(imageByteArrayList[i].name) + "','"+ imageByteArrayList[i].extension + "', @imageFile_" + i.ToString() + "),";
                }
                Querry = Querry.Remove(Querry.Length - 1); // remove last ','

                sqlCmd.Parameters.Clear(); // clear previous parameters12
                for (int i = 0; i < imageByteArrayList.Count; i++) // second for loop insted of one to avoid some concurency errors with parameters
                {
                    /*var paramUserImage = new MySqlParameter("@imageFile_" + i.ToString(), MySqlDbType.Blob, imageByteArrayList[i].data.Length);
                    paramUserImage.Value = imageByteArrayList[i].data;
                    sqlCmd.Parameters.Add(paramUserImage);*/

                    sqlCmd.Parameters.AddWithValue("@imageFile_" + i.ToString(), imageByteArrayList[i].data);
                }

                int returnedId = IsSqlConnected(mainWindow, Querry, 1);

                DBConnection.Close();

                if (returnedId > 0)
                    return true;
            }
            return false;
        }

        public bool RemoveImageSQL(int ncfile_id, MainWindow mainWindow) // REMOVE images related to NcFile
        {
            if (IsSqlConnected(mainWindow, "DELETE FROM imagedb WHERE ncfile_id = " + ncfile_id + ";", 1) > 0)
                return true;
            else
                DBConnection.Close();
            return false;
        }


// Log ------------------------------------------------------------------------------------------------------------------
// -------------------------------------------------------------------------------------------------------------------------
        public void NewLogSQL(int action_type, string actor_user_name, string full_operation_detail, MainWindow mainWindow) // CREATE LOG
        {
            string sqlRequest = "INSERT INTO log (action_type,actor_user_name,full_operation_detail,action_date) VALUES (" +
                action_type + ",'" +
                AddSlash(actor_user_name) + "','" +
                AddSlash(full_operation_detail) + "'," +
                "NOW());";

            int returnedId = IsSqlConnected(mainWindow, sqlRequest, 1);

            DBConnection.Close();
        }


        public void RefreshLogListSQL(MainWindow mainWindow, ObservableCollection<Log> logList) // LOG LIST
        {
            logList.Clear();
            //logList.

            if (-1 != IsSqlConnected(mainWindow, "SELECT id,action_type,actor_user_name,full_operation_detail,action_date FROM log ORDER BY id DESC;"))
            {
                while (sqlReader.Read())
                {
                    logList.Add(new Log(
                        sqlReader.GetInt16("id"),
                        sqlReader.GetInt16("action_type"),
                        sqlReader.GetString("actor_user_name"),
                        sqlReader.GetString("full_operation_detail"),
                        sqlReader.GetString("action_date")));
                }
            }
            DBConnection.Close();
            //return logList;
        }


    }


}