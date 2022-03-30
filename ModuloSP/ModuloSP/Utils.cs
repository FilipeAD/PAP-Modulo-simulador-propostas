using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloSP
{
    public class Utils
    {
        public static string conString = @"Data Source=serversofttests\sqlexpress;Initial Catalog=estagio_2022_12_ano_Filipe;User ID=estagio;Password=Pass.123";


        public static string _GroupSearch = "";
            public static string GroupSearch
        {
                get { return _GroupSearch; }
                set { _GroupSearch = value; }
            }

    }


}
