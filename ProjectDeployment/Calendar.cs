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
        public void AddAction(Meet act)
        {
            this.actions.Add(act);
        }
        public void AddAction(BirthDay act)
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
        public Meet copyAction(Meet copyMeet)
        {
            string st = copyMeet.StartTime;
            string et = copyMeet.EndTime;
            string dat = copyMeet.Date;
            string desc = copyMeet.Description;
            List<User> us = copyMeet.UsersList;
            Meet copy = new Meet(st,et,dat,desc,us);
            return copy;
        }
        public BirthDay copyAction(BirthDay copyBirthDay)
        {
            User peop = copyBirthDay.man;
            string dat = copyBirthDay.Date;
            string desc = copyBirthDay.Description;
            List<User> us= copyBirthDay.UsersList;
            BirthDay copy = new BirthDay(peop, dat, desc, us);
            return copy;
        }
        
    }
}
