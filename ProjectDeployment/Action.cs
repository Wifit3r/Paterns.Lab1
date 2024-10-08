﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDeployment
{
    public class Action : IClonable
    {
        public string Date;
        public List<User> UsersList;
        public string Description; 
        protected int key;
        
        public Action(string date, string description, List<User> users)
        {
            Date = date;
            Description = description;
            key = generateKey();
            UsersList = users;
        }
        public int generateKey()
        {
            Random random = new Random();
            int key = random.Next(0, 100);
            return key;
        }
        public override string ToString()
        {
            string users = string.Join(", ", UsersList.Select(user => user.login));
            return $"Action [Date: {Date}, Description: {Description}, Key: {key}, Users: {users}]";
        }
         public Action ActCopy(Action ToCopy)
        {
            return new Action(Date, Description, UsersList);
        }
    }
}
