using Npgsql;
using PianinoGame.Models;
using System.Collections.Generic;
using System.Data;

namespace PianinoGame.Database
{
    public class Connection
    {
        private static readonly string ConnectionString = $"Host={Properties.Settings.Default.DbHost};" +
                                                          $"Username={Properties.Settings.Default.DbLogin};" +
                                                          $"Password={Properties.Settings.Default.DbPassword};" +
                                                          $"Database={Properties.Settings.Default.DbName}";

        public Connection()
        {
        }

        public void InsertUser(string name, int score)
        {
            using (var connection = new NpgsqlConnection(ConnectionString))
            {
                connection.Open();
                var cmd = connection.CreateCommand();
                cmd.CommandText = "INSERT INTO rating (name, score) VALUES(@name, @score)";
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@score", score);

                cmd.ExecuteNonQuery();
            }
        }

        public async void InsertUserAsync(string name, int score)
        {
            using (var connection = new NpgsqlConnection(ConnectionString))
            {
                connection.Open();
                var cmd = connection.CreateCommand();
                cmd.CommandText = $"INSERT INTO rating (name, score) VALUES(@name, @score)";
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@score", score);

                await cmd.ExecuteNonQueryAsync();
            }
        }
        // TODO ну типа вынести execute в отедельный метод все дела
        public List<RatingDTO> GetUsers()
        {
            using (var connection = new NpgsqlConnection(ConnectionString))
            {
                connection.Open();
                var cmd = connection.CreateCommand();
                cmd.CommandText = $"WITH A(name, score) AS (" +
                                  "SELECT name, MAX(score) as score FROM rating GROUP BY name ORDER BY name ASC)" +
                                  "SELECT name, score FROM A ORDER BY score DESC";
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        DataTable schemaDataTable = reader.GetSchemaTable();
                        List<RatingDTO> users = new List<RatingDTO>();
                        while (reader.Read())
                        {
                            users.Add(new RatingDTO(reader.GetString(0), reader.GetInt32(1)));
                        }

                        return users;
                    }
                }

                return null;
            }
        }

        public List<RatingDTO> GetPersonalUsers(string name)
        {
            using (var connection = new NpgsqlConnection(ConnectionString))
            {
                connection.Open();
                var cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT score FROM rating WHERE name = @name ORDER BY score DESC";
                cmd.Parameters.AddWithValue("@name", name);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        DataTable schemaDataTable = reader.GetSchemaTable();
                        List<RatingDTO> users = new List<RatingDTO>();
                        while (reader.Read())
                        {
                            users.Add(new RatingDTO(name, reader.GetInt32(0)));
                        }

                        return users;
                    }
                }

            }

            return null;
        }
    }
}
