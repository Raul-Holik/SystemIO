using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SystemIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite destinaciju direktorija. ");
            string destinacija=Console.ReadLine();

            if (Directory.Exists(destinacija))
            {
                Console.WriteLine("Datoteke: ");
                foreach (string datoteka in Directory.GetFiles(destinacija))
                {
                    Console.WriteLine(datoteka);
                }
                string putanjaPodDir = destinacija + "\\TEST";
                if (!Directory.Exists(putanjaPodDir))
                {
                    Directory.CreateDirectory(putanjaPodDir);
                }
                Console.WriteLine("Poddirektoriji: ");
                foreach (string podDir in Directory.GetDirectories(destinacija))
                {
                    Console.WriteLine(podDir);
                }
                Directory.Delete(putanjaPodDir);

                Console.WriteLine("Nakon brisanja direktorija TEST. ");
                foreach (string podDir in Directory.GetDirectories(destinacija))
                {
                    Console.WriteLine(podDir);
                }
            
            }
            else
            {
                Console.WriteLine("Ne postoji željena destinacija. ");
            }
            Console.ReadKey();
        }
    }
}
