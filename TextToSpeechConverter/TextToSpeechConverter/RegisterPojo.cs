using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextToSpeechConverter
{
    internal class RegisterPojo
    {
        string username;
        string email;
        string contact;
        string password;

        public string Username { get => username; set => username = value; }
        public string Email { get => email; set => email = value; }
        public string Contact { get => contact; set => contact = value; }
        public string Password { get => password; set => password = value; }
    }
}
