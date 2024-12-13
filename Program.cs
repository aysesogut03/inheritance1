using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    public class Program
    {
        static void Main(string[] args)
        {
            kedi kedi1 = new kedi();
            kedi1.hayvanRengi = "siyah";
            kedi1.hayvanİsim = "boncuk";
            kedi1.hayvanCinsiyet = "dişi";

            kedi1.kediGozRengi = "yeşil";
            Console.WriteLine("kedi göz rengi:"+ kedi1.kediGozRengi);

            kedi1.kediuyuyor();
            kedi1.hayvanBilgisiGoster();
            Console.ReadLine();
        }
    }
}
