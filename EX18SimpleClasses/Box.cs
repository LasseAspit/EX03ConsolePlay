using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX18SimpleClasses
{
    class Box
    {
        public int Højde { get; set; }
        public int Længde { get; set; }
        public int Bredde { get; set; }
        private int Volume { get; set; }
        private int Surface { get; set; }   


        public Box(int højde, int længde, int bredde)
        {
            Højde = højde;
            Længde = længde;
            Bredde = bredde;
            int volume;
        }

        public void VolumeCalc()
        {
            Volume = Højde * Længde * Bredde;
        }


        public void PrintInfo()
        {
            SurfaceCalc();
            VolumeCalc();
            Console.WriteLine($"Kassen har følgende mål: \nhøjde: {Højde}\nlængde: {Længde}\nbredde: {Bredde}\nVolume: {Volume}\noverflade: {Surface}");
        }

        public void SurfaceCalc()
        {
            Surface = (Højde * Bredde)*2 + (Længde * Bredde)*2 + (Længde * Højde)* 2;
        }



    }
}
