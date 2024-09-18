using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProjectDeployment
{
    internal class BirthDay : Action
    {
        public User man;
        public BirthDay(User man, string date, string description, List<User> users):base(date,description,users)
        {
            this.man = man;
            Date = date;
            Description = description;
            UsersList = users;
        }
        public override string ToString()
        {
            return $"Action [Date: {Date}, Description: {Description}, Key: {key}, Users: {UsersList}, Birthday boy: {man.login}]";
        }
    }
}
