using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX18SimpleClasses
{
    class Box
    {
        int Højde;
        int Længde;
        int Bredde;
        int Volume;
        int Surface;


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
            VolumeCalc();
            SurfaceCalc();
            Console.WriteLine($"Kassen har følgende mål: \nhøjde: {Højde}\nlængde: {Længde}\nbredde: {Bredde}\nVolume: {Volume}\noverflade: {Surface}");
        }

        public void SurfaceCalc()
        {
            Surface = (Højde * Bredde)*2 + (Længde * Bredde)*2 + (Længde * Højde)* 2;
        }



    }
}
