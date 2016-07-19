using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tmrin3.kelas
{
    public class karmand:person
    {
        private int code;

        public int Code
        {
            get { return code; }
            set { code = value; }
        }

        /////////////////////////////

        private string semat;

        public string Semat
        {
            get { return semat; }
            set { semat = value; }
        }

        ////////////////////////////

        private string daneshkade;

        public string Daneshkade
        {
            get { return daneshkade; }
            set { daneshkade = value; }
        }
    }
}
