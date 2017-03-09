using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndkøbsApp.Model
{
    class Indkøb
    {
        public string Vare { get; set; }
        public int Pris { get; set; }



        public override string ToString()
        {
            return Vare + ", " + Pris + "kr.";
        }


    }
}
