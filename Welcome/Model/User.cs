using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Welcome.Others;

namespace Welcome.Model
{
    public class User
    {
        private string _name;
        private string _password;
        private string _email;
        private UserRolesEnum _role;
        private String _faculty_number;


        public User(string names, string password,String faculty_number, string email, UserRolesEnum role)
        {
            _name = names;
            _faculty_number = faculty_number;
            _password = password;
            _email = email;
            _role = role; 
        }
        public User(string names, string password, UserRolesEnum role)
        {
            _name = names;
            _password = password;
            _role = role;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value.ToUpper(); }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public UserRolesEnum Role
        {
            get { return _role; }
            set { _role = value; }
        }
    }
}
