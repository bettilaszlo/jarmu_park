using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jarmu_park
{
    class Program
    {
        static void Main(string[] args)
        {
            //auto a = new auto();


            auto lada = new auto("piros", "Lada 2112", 11);
            auto trabant = new auto("zöld", "Trabant 1.1", 8);

            lada.Tankol(20);
            trabant.Tankol(20);

           lada.Állapot();
           trabant.Állapot();

            
            Console.WriteLine("Mennyit megy a lada: ");
            int km = int.Parse(Console.ReadLine());
            lada.Megy(km);
            lada.Állapot();

            Console.WriteLine("Mennyit megy a trabant: ");
            int km1 = int.Parse(Console.ReadLine());
            trabant.Megy(km1);
            trabant.Állapot();

            /*lada.fogyaszt = 11;
            lada.km = 212342;

            trabant.fogyaszt = 8;
            trabant.km = 302999;*/


            Console.ReadKey();
        }
    }
}
