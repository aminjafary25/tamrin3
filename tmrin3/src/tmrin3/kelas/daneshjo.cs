using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tmrin3.kelas
{
    public class daneshjo:person
    {
        private int code;

        public int Code
        {
            get { return code; }
            set { code = value; }
        }
        ///////////////////////////////////////

        private string reshte;

        public string Reshte
        {
            get { return reshte; }
            set { reshte = value; }
        }

        ///////////////////////////////////////

        private string vorodi;

        public string Vorodi
        {
            get { return vorodi; }
            set { vorodi = value; }
        }
        ///////////////////////////////////////////////////////////////

       public ICollection<dars> Dars;
    }

}
