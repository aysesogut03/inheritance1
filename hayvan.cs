using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    public class hayvan
    {
        public string hayvanİsim;
        public string hayvanCinsiyet;
        public string hayvanRengi;
        private int hayvanYas;
        

        public void hayvanBilgisiGoster()
        {
            Console.WriteLine("hayvanın ismi:" + hayvanİsim);
            Console.WriteLine("hayvan cinsiyeti:" + hayvanCinsiyet);
            Console.WriteLine("hayvan rengi:" + hayvanRengi);
           
        }
    }
}
