using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jarmu_park
{
    class auto
    {
        private string szin;
        private string tipus;
        private double uzemAnyag;
        private double fogyaszt;
        private double km;
        private double megtehetoKM;

        public auto(string szin, string tipus, double fogyaszt)
        {
            this.szin = szin;
            this.tipus = tipus;
            this.fogyaszt = fogyaszt;
            this.uzemAnyag = 0;
            this.km = 0;
            this.megtehetoKM = 0;
        }
        public void Tankol(double mennyit)
        {
            uzemAnyag += mennyit;
            megtehetoKM = uzemAnyag / fogyaszt * 100;
        }
        public void Megy(double km)
        {
            this.km += km;
            uzemAnyag -= (km * fogyaszt / 100);
            
            Megteheto();
        }
        public void Állapot()
        {
            Console.WriteLine($"{tipus} - {szin}");
            Console.WriteLine($"Km óra: {km} km");
            Console.WriteLine($"Üzemanyag: {uzemAnyag} l");
            Console.WriteLine($"Megtehető km: {megtehetoKM}");
           
            Console.WriteLine("------------------------------------------------");

        }
        private void Megteheto()
        {
            megtehetoKM = uzemAnyag / fogyaszt * 100;
        }
    }
}
