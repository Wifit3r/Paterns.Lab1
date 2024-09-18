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
            Date = Date;
            Description = description;
            UsersList = users;
        }
        public override string ToString()
        {
            s
            for(int i = 0;i<UsersList.Count; i++)
            {

            }
            return $"Action [Date: {Date}, Description: {Description}, Key: {key}, Users: {users}, Birthday boy: {man.login}]";
        }
    }
}
