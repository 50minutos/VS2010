using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;

namespace _100_Drives
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var di in DriveInfo.GetDrives())
            {
                Console.WriteLine("nome: {0}", di.Name);
                Console.WriteLine("formato: {0}", di.DriveFormat);
                Console.WriteLine("tipo: {0}", di.DriveType);
                Console.WriteLine("pronto: {0}", di.IsReady);
                Console.WriteLine("raíz: {0}", di.RootDirectory);
                Console.WriteLine("tamanho: {0}", di.TotalSize / 1024 / 1024);
                Console.WriteLine("livre: {0}", di.AvailableFreeSpace / 1024 / 1024);
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
