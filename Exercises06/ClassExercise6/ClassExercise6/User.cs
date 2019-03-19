using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercise6
{
    class User
    {
        public User(int id, string username, string password)
        {
            Id = id;
            Username = username;
            Password = password;
            Messages = new string[3];
            Messages[0] = "Congratulations ! You are logged successfully.";
            Messages[1] = "Sorry, your username or password is not correct! Please try again.";
            Messages[2] = "Something went wrong ! Please try again.";
        }
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string[] Messages;
    }
}
