﻿using System;
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

        public static string _Marca_Modelo = "";
        public static string Marca_Modelo
        {
            get { return _Marca_Modelo; }
            set { _Marca_Modelo = value; }
        }

    }


}
