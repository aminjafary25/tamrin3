using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tmrin3.kelas
{
    public class ostad:person
    {
        private int code;

        public int Code
        {
            get { return code; }
            set { code = value; }
        }

        ////////////////////////////

        private string madrak;

        public string Madrak
        {
            get { return madrak; }
            set { madrak = value; }
        }

        ////////////////////////////

        private string reshte;

        public string Reshte
        {
            get { return reshte; }
            set { reshte = value; }
        }

    }
}
