using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloSP
{
    class IDEditar
    {

        private static string _IdMaquina = "";
        public static string IdMaquina
        {
            get { return _IdMaquina; }
            set { _IdMaquina = value; }
        }

        private static string _IdAddOn = "";
        public static string IdAddOn
        {
            get { return _IdAddOn; }
            set { _IdAddOn = value; }
        }
    }
}
