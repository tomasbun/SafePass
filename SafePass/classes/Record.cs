using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafePass
{
    class Record
    {
        private string Name { get; set; }
        private string Username { get; set; }
        private string Password { get; set; }

        public Record(string name, string username, string password)
        {
            Name = name;
            Username = username;
            Password = password;
        }

        public string Display_details()
        {
            return Name + " " + Username + " " + Password;
        }

        public void SetName(string n)
        {
            Name = n;
        }
               
        public void SetUsername(string u)
        {
            Username = u;
        }

        public void Setpassword(string p)
        {
            Password = p;
        }

        public string GetName()
        {
            return Name;
        }

        public string GetUsername()
        {
            return Username;
        }

        public string GetPassword()
        {
            return Password;
        }



    }
}
