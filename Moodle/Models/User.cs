﻿namespace Moodle.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Username { get; set; }
        public string Name { get; set; }

        public string Password { get; set; }

        public  int Degree_Id { get; set; }

        public User()
        {
                
        }
    }
}
