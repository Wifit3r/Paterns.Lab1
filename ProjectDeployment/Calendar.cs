using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDeployment
{
    internal class Calendar
    {
        List<Action> actions = new List<Action>();
        public void AddAction(User man, string date, string description, List<User> users)
        {
            BirthDay act = new BirthDay(man, date, description, users);
            actions.Add(act);
        }
        public void AddAction(string startTime, string endTime, string date, string description, List<User> users)
        {
            Meet act = new Meet(startTime, endTime, date, description, users);
            actions.Add(act);
        }
        public void AddAction(Action act)
        {
            actions.Add(act);
        }
        public void showActions() {
            {
                foreach (Action act in actions)
                {
                    Console.WriteLine((Convert.ToString(act)));
                }
            }
        }
        public Action copyAction(Action toCopy)
        {
            Action act = toCopy;
            act.ActCopy(toCopy);
            return act;
        }
        public Meet copyAction(Meet toCopy)
        {
            Meet meet = toCopy;
            Meet toReturn = meet.ActCopy(toCopy);
            return toReturn;
        }
        public BirthDay copyAction(BirthDay toCopy)
        {
            BirthDay birthDay = toCopy;
            BirthDay toReturn = birthDay.ActCopy(toCopy);
            return toReturn;
        }
        
    }
}
