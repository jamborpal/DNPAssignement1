using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using Models;

namespace Assignment1.Login
{
    public class UserService : IUserService
    {
        private List<User> users;
        private string userFile = "users.json";

        public UserService()
        {
            string content = File.ReadAllText(userFile);
            users = JsonSerializer.Deserialize<List<User>>(content);
        }

        public User ValidateUser(string username, string password)
        {
            User first = users.FirstOrDefault(user => user.UserName.Equals(username));
            if (first == null)
            {
                throw new Exception("user not found");
            }

            if (!first.Password.Equals(password))
            {
                throw new Exception("Password is incorrect");
            }

            return first;
        }

        public void AddUser(string username, string password, string role)
        {
            User user = new User()
            {
                UserName = username,
                Password = password,
                Role = role
            };
            users.Add(user);
            writeUserFile(users);
        }

        private void writeUserFile(List<User> user)
        {
            string productAsJson = JsonSerializer.Serialize(user);
            File.WriteAllText(userFile, productAsJson);
        }

        public List<User> getUsers()
        {
            return users;
        }

        public void RemoveUser(User toRemove)
        {
            User toBeRemoved = users.First(t => t.UserName == toRemove.UserName);
            users.Remove(toRemove);
            writeUserFile(users);
        }
    }
}