using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloSP.Models
{
    class CurrentUser
    {

        private static string _IDUser = "";
        public static string IDUser
        {
            get { return _IDUser; }
            set { _IDUser = value; }
        }

        private static string _username = "";
        public static string username
        {
            get { return _username; }
            set { _username = value; }
        }

        private static string _email = "";
        public static string email
        {
            get { return _email; }
            set { _email = value; }
        }

        private static string _group = "";
        public static string group
        {
            get { return _group; }
            set { _group = value; }
        }

    }
}
