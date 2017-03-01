using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eve_Market_Data
{
    class DatabaseInterface
    {
        private static SQLiteConnection dbConnection;
        public DatabaseInterface()
        {
            FileInfo dbFile = new FileInfo("EveMarketData.sqlite");
            if (!dbFile.Exists)
            {
                SQLiteConnection.CreateFile("EveMarketData.sqlite");
                using (dbConnection = new SQLiteConnection("Data Source=EveMarketData.sqlite;Version=3;"))
                {
                    dbConnection.Open();
                    string sql = "create table items (typeID int, name text, margin real, volume real, rank int)";
                    SQLiteCommand command = new SQLiteCommand(sql, dbConnection);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void InsertItemStatement(int id, string name, double margin = 0, double volume = 0, int rank = 0)
        {
            string sql = string.Format("insert into items (typeID,name,margin,volume,rank) values ({0},{1},{2},{3},{4})", id, name, margin, volume, rank);
            ExecuteNonQuery(sql);
        }

        public void QueryStatement()
        {
            string sql = string.Format("");

        }

        protected void ExecuteNonQuery(string sql)
        {
            using (dbConnection = new SQLiteConnection("Data Source=EveMarketData.sqlite;Version=3;"))
            {
                dbConnection.Open();
                SQLiteCommand command = new SQLiteCommand(sql, dbConnection);
                command.ExecuteNonQuery();
            }
        }

        protected void ExecuteQuery(string sql)
        {
            using (dbConnection = new SQLiteConnection("Data Source=EveMarketData.sqlite;Version=3;"))
            {
                dbConnection.Open();
                SQLiteCommand command = new SQLiteCommand(sql, dbConnection);
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        //TODO: implement queries
                    }
                }
                
            }
        }
    }
}
