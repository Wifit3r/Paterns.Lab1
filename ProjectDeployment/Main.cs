using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDeployment
{
    static class Program
    {
        public static void Main()
        {
            User user2 = new User("user2", "email2@mail.com");
            User user1 = new User("user1",  "email1@mail.com");
            User user3 = new User("user3",  "email@mail.com");
            user1.SetPassword("password11");
            user2.SetPassword("password22");
            user3.SetPassword("password33");


            List<User> users = new List<User>();
            users.Add(user1);
            users.Add(user3);
            users.Add(user2);
           
            List<User> Busers = new List<User>();
            Busers.Add(user2);
            Busers.Add(user3);
            Meet meet1 = new Meet("10:00", "12:00", "12.10.2024", "description", users);
            Calendar MyCalendar = new Calendar();
            MyCalendar.AddAction(meet1);
            Console.WriteLine(user3);
            Console.WriteLine(meet1);
            BirthDay bd = new BirthDay(user1, "22.12.2024", "some description", Busers);
            Console.WriteLine(bd);
            MyCalendar.AddAction(bd);
            Meet meet2 = MyCalendar.copyAction(meet1);
            
            meet2.StartTime = "14:00";
            meet2.EndTime = "16:00";
            Console.WriteLine(meet2);
            Console.WriteLine(meet1);
            var actionCopy = MyCalendar.copyAction(bd);
            actionCopy.Description = "Description new";
            Console.WriteLine(actionCopy);
            Console.WriteLine(bd);
            Action newAct = new Action("24.09.2024", "some desc", users);
            var NewActionCopy = MyCalendar.copyAction(newAct);
            NewActionCopy.Description = "NEW desc";
            Console.WriteLine(newAct);
            
            Console.WriteLine(NewActionCopy);
        }
    }
}
