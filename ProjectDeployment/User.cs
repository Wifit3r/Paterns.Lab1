using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDeployment
{
    public class User
    {
        public string login { get; set; }
        private string password;
        public string email { get; set; }

        public User(string Login, string email) { 
            this.login = Login;
            this.email = email;
        }
        public void SetPassword(string Pass)
        {
            if (Validation.pasValidation(Pass))
            {
                password = Pass;
            }
            else
            {
                throw new Exception("Password is to week");
            }
        }
        public override string ToString()
        {
            return $"login ={this.login}, email = {this.email}";
        }
    }
}
