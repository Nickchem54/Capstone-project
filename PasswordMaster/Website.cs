using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordSaver
{
    class Website
    {
        #region FIELDS

        private string _name;
        private string _email;
        private string _password;

        #endregion

        #region PROPERTIES

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        #endregion

        #region CONSTRUCTORS
        public Website()
        {

        }

        public Website(string name)
        {
            _name = name;
        }
        #endregion
        #region
        public string WebsitPassword()
        {
            return _name + " is " + Password + ".";
        }
        #endregion
    }

}