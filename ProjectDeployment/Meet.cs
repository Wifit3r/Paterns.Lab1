using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDeployment
{
    internal class Meet:Action
    {
        public string StartTime;
        public string EndTime;
        public Meet(string startTime, string endTime, string date, string description, List<User> users) : base(date, description, users)
        {
            
            this.StartTime = startTime;
            this.EndTime = endTime;
        }
        public override string ToString()
        {
            string users = string.Join(", ", UsersList.Select(user => user.login));
            return $"Action [Date: {Date}, Description: {Description}, Key: {key}, Users: {users}, start at: {StartTime}, end: {EndTime}]";
        }
        public Meet ActCopy(Meet toCopy)
        {
            Meet toReturn = new Meet(this.StartTime, this.EndTime,this.Date ,this.Description, this.UsersList);
            toReturn.key = this.key;
            return toReturn;
        }
    }
}
