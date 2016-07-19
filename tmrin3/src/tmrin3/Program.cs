using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tmrin3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var s = new kelas.daneshjo
            {
                codemelli=1222,
                Code=3333,
                name="amin",
                family="jafary",

                Dars=new List<kelas.dars>
                {
                    new kelas.dars
                    {
                        codedars=23,
                        vahed=3,
                        name="riyazi"
                    },
                    new kelas.dars
                    {
                        codedars=24,
                        vahed=2,
                        name="zaban"
                    }
                }
            };

            Console.WriteLine("name         family       code daneshjo       tedade dars        jame vahed");
            Console.WriteLine("       :-)    ");
            Console.WriteLine("       :-/    ");
            Console.Write("{0}         {1}           {2}                {3}                  {4}",s.name,s.family,s.Code,s.Dars.Count,s.Dars.Sum(x=>x.vahed));
            Console.ReadLine();
        }
    }
}
