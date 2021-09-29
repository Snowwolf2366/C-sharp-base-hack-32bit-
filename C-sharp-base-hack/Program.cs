using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace ConsoleApp3
{
    using C_sharp_base_hack;
    class Program
    {
        static void Main(string[] args)
        {
            Process proc = Process.GetProcessesByName("")[0];

            var hProc = api.OpenProcess(api.ProcessAccessFlags.All, false, proc.Id);

            var modBase = api.GetModuleBaseAddress(proc, "exe");

            var modBase2 = api.GetModuleBaseAddress(proc.Id, "exe");

            System.Console.WriteLine("Last Error: " + Marshal.GetLastWin32Error());


            Console.ReadKey();
        }
    }
}