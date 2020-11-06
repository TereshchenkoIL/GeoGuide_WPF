
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directory
{
    class User
    {
        [JsonProperty]
        private string name;
        [JsonProperty]
        private string password;

        public User(string _name, string pas)
        {
            Name = _name;
            Password = pas;
        }

        public string Name
        {
            private set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }

        public string Password
        {
            private set
            {
                password = value;
            }
            get
            {
                return password;
            }
        }


    }
}
