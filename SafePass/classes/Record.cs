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
        private string Type { get; set; }
        private string Username { get; set; }
        private string Password { get; set; }

        public Record(string name, string type, string username, string password)
        {
            Name = name;
            Type = type;
            Username = username;
            Password = password;
        }

        public string Display_details()
        {
            return Name + " " + Type + " " + Username + " " + Password;
        }

        public void SetName(string n)
        {
            Name = n;
        }

        public void SetType(string t)
        {
            Type = t;
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

        public string Get_Type()
        {
            return Type;
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
