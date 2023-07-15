using System;
using Npgsql;
using PianinoGame.Models;
using System.Collections.Generic;
using System.Data;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using PianinoGame.Models.dto;

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

        public void saveGameResult(int userId, int score)
        {
            HttpClient client = new HttpClient();
            StringBuilder postData = new StringBuilder();
            postData.Append("{\"user_id\": \"");
            postData.Append(userId);
            postData.Append("\", \"score\": ");
            postData.Append(score);
            postData.Append("}");
            
            StringContent myStringContent = new StringContent(postData.ToString(), Encoding.UTF8, "application/json");
            var responce = client.PostAsync("http://194.187.122.28:8080/games", myStringContent);
           
        }

        public UserDto InsertUser(string name)
        {
            HttpClient client = new HttpClient();
            StringBuilder postData = new StringBuilder();
            postData.Append("{\"name\": \"");
            postData.Append(name);
            postData.Append("\"}");
            
            StringContent myStringContent = new StringContent(postData.ToString(), Encoding.UTF8, "application/json");
            var responce = client.PostAsync("http://194.187.122.28:8080/users", myStringContent);
            if (responce.Result.StatusCode == HttpStatusCode.OK)
            {
                return new UserDto(3, "asdasdas");
                var ratings = JsonSerializer.Deserialize<UserDto>(responce.Result.ToString());
                return ratings;
            }

            return null;
        }

        public async void InsertUserAsync(string name, int score)
        {
        }
        
        public List<RatingDTO> GetUsers()
        {
            HttpClient client = new HttpClient();
            var responce = client.GetStringAsync("http://194.187.122.28:8080/ratings").Result;
            var ratings = JsonSerializer.Deserialize<List<RatingDTO>>(responce.ToString());
            return ratings;
        }

        public List<RatingDTO> GetPersonalUsers(int userId)
        {
            HttpClient client = new HttpClient();
            var responce = client.GetStringAsync("http://194.187.122.28:8080/ratings/" + userId).Result;
            var ratings = JsonSerializer.Deserialize<List<RatingDTO>>(responce.ToString());
            return ratings;
        }
    }
}
