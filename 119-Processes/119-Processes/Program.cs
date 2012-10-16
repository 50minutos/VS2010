using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace _119_Processes
{
    class Program
    {
        static void Main(string[] args)
        {
            var processos =
                            Process
                              .GetProcesses()
                              .Where(process => process.WorkingSet64 > 30 * 1024 * 1024)
                              .OrderByDescending(process => process.WorkingSet64)
                              .Select(process => new
                              {
                                  process.Id,
                                  Nome = process.ProcessName,
                                  MemoriaConsumida = process.WorkingSet64 / 1024.0F / 1024
                              });

            ObjectDumper.Write(processos);

            Console.ReadKey();
        }
    }
}
