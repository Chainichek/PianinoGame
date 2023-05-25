using Npgsql;
using PianinoGame.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PianinoGame.Database
{
    public class Connection
    {
        private NpgsqlConnection con;
        private static Connection mConnection;
        public Connection()
        {
            var bitHost = "db.bit.io";
            var bitApiKey = "v2_43UpL_gjutm8AuznMTivwETmqiYWt"; // from the "Password" field of the "Connect" menu

            var bitUser = "appAccount";
            var bitDbName = "Wilidon/pianino";

            var cs = $"Host={bitHost};Username={bitUser};Password={bitApiKey};Database={bitDbName}";

            con = new NpgsqlConnection(cs);
            con.Open();


        }

        public static Connection GetInstanse()
        {
            if (mConnection == null)
            {
                mConnection = new Connection();
            }
            return mConnection;
        }
        
        public void insertUser(string name, int score)
        {
            var sql = "INSERT INTO rating (name, score) VALUES('" + name + "', '" + score + "');";

            var cmd = new NpgsqlCommand(sql, con);
            cmd.ExecuteNonQuery();
        }

        public List<RatingDTO> GetUsers()
        {
            var sql = "WITH A(name, score) AS \r\n(SELECT name, MAX(score) as \"score\" FROM rating GROUP BY name ORDER BY name ASC)\r\n\r\nSELECT name, score FROM A ORDER BY score DESC;";

            var cmd = new NpgsqlCommand(sql, con);

            NpgsqlDataReader reader = cmd.ExecuteReader();
            DataTable schemaTable = reader.GetSchemaTable();

            List<RatingDTO> users = new List<RatingDTO>();
            while (reader.Read())
            {
                RatingDTO user = new RatingDTO((string) reader[0],
                   (int) reader[1]);
                users.Add(user);
             }
            reader.Close();
            return users;
        }
    }
}
