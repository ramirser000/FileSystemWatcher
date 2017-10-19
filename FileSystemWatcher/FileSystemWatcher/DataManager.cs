using System;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Data;

namespace MyFileSystemWatcher
{
    class DataManager
    {
        private static string databaseFilePath = "myData.db";
        private static SQLiteConnection conn;
        private static SQLiteCommand comm;
        private static int ID = 0, EXT = 1, FILENAME = 2, PATH = 3, EVENT = 4, DATE = 5;


        public static void start()
        {
            try
            {
                if (!System.IO.File.Exists(databaseFilePath))
                {

                    SQLiteConnection.CreateFile(databaseFilePath);
                    conn = new SQLiteConnection("Data Source =" + databaseFilePath + ";Compress=True;");
                    conn.Open();
                    comm = conn.CreateCommand();
                    comm.CommandText = "CREATE TABLE watched_files " +
                                        "(id INTEGER primary key, extension varchar(10), filename TEXT, path TEXT, event varchar(20), date varchar(20));";
                    comm.ExecuteNonQuery();

                }
                else
                {
                    conn = new SQLiteConnection("Data Source =" + databaseFilePath + ";Compress=True;");
                    conn.Open();
                    comm = conn.CreateCommand();
                    comm.CommandText = "CREATE TABLE IF NOT EXISTS watched_files " +
                        "(id INTEGER primary key, extension varchar(10), filename TEXT, path TEXT, event varchar(20), date varchar(20));";
                    comm.ExecuteNonQuery();

                }
            }
            catch (Exception)
            {
                DialogResult dialog = MessageBox.Show("Database error, goodbye.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (dialog == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
        }

        public static void stop()
        {
            try
            {
                conn.Close();
            }
            catch (Exception)
            {
                MyMessageBox();
            }
        }


        public static void WriteToDataBase(string[] values)
        {

            string[] v = new string[values.Length];

            for (int i = 0; i < values.Length; i++)
            {
                v[i] = "\"" + values[i] + "\"";
            }

            try
            {
                comm.CommandText = "INSERT INTO watched_files " +
                                        "(extension, filename, path, event, date) " +
                                        "VALUES (" + v[EXT] + "," + v[FILENAME] + "," + v[PATH] + "," + v[EVENT] + "," + v[DATE] + ")";
                comm.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MyMessageBox();
            }

        }


        public static void UpdateGrid(DataGridView grid, string ext)
        {

            try
            {
                
                
                if(ext == null || ext == "")
                {
                    comm.CommandText = "SELECT * " +
                            "FROM watched_files;";
                }else
                {
                    comm.CommandText = "SELECT * " +
                            "FROM watched_files " +
                            "WHERE extension = @exten COLLATE NOCASE;";

                    comm.Parameters.Add(new SQLiteParameter("@exten", ext));
                }

                



                DataSet dataSet = new DataSet();
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter();
                dataAdapter.SelectCommand = comm;
                dataAdapter.Fill(dataSet);

                grid.DataSource = dataSet.Tables[0].DefaultView;
            }
            catch (Exception)
            {
                MyMessageBox();
            }

        }

        public static void clear()
        {
            comm = conn.CreateCommand();
            comm.CommandText = "DROP TABLE  IF EXISTS watched_files;";
            comm.ExecuteNonQuery();

            comm.CommandText = "CREATE TABLE IF NOT EXISTS watched_files " +
                        "(id INTEGER primary key, extension varchar(10), filename TEXT, path TEXT, event varchar(20), date varchar(20));";
            comm.ExecuteNonQuery();
        }

        private static void MyMessageBox()
        {
            DialogResult dialog = MessageBox.Show("Database error, goodbye.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (dialog == DialogResult.OK)
            {
                Application.Exit();
            }


        }

    }
}
