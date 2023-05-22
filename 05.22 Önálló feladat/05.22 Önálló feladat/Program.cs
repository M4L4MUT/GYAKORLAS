using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._22_Önálló_feladat
{
    class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Kérem, adjon meg három szót:");
            

            Console.Write("Első szó: ");
            string szo1 = Console.ReadLine();

            Console.Write("Második szó: ");
            string szo2 = Console.ReadLine();

            Console.Write("Harmadik szó: ");
            string szo3 = Console.ReadLine();
            Console.ResetColor();
            bool talalt1 = false;
            bool talalt2 = false;
            bool talalt3 = false;
            bool talalt4 = false;
            foreach (char betu in szo1)
            {
                if (szo2.Contains(betu) && szo3.Contains(betu))
                {
                    talalt1 = true;
                    break;
                }
                if(szo2.Contains(betu))
                {
                    talalt2 = true;
                    break;
                }
                if (szo3.Contains(betu))
                {
                    talalt3 = true;
                    break;
                }
                else
                {
                    talalt4 = true;
                    break;
                }
            }

            if (talalt1)
            {
                Console.WriteLine("Van olyan betű, amely mindhárom szóban előfordul.");
            }
            if (talalt2)
            {
                Console.WriteLine("Van olyan betű amely csak az első és a második szóban szerepel.");
            }
            if (talalt3)
            {
                Console.WriteLine("Van olyan betű amely csak az első és a harmadik szóban szerepel.");
            }
            if (talalt4)
            {
                Console.WriteLine("Nincs olyan betű amely az első szóban szerepel és a második vagy a harmadik szóban is megtalálható.");
            }

            Console.ReadLine();
        }
    }
}
