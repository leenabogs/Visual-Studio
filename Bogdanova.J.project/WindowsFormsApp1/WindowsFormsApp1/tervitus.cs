using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class tervitus
    {
        public string nimi;
        public string vastust;

        public string tere()
        {
            if (nimi != "")
            {
                vastust = "Привет, " + nimi + "!";
            }
            else
            {
                vastust = "Введите Ваше имя!!!";
            }
            return vastust;
        }

    }
}
