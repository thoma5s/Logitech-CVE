using System;
using System.Threading;

namespace CVE {
    class Program {
        static void Main(string[] args) {
            if (!Mouse.Open()) Console.WriteLine("Failed");
            else {
                Console.WriteLine("Success\n\n");

                for (int i = 0; i < 100; i++) {
                    Thread.Sleep(20);
                    Console.WriteLine("[+] Moving mouse\n");
                    Mouse.Move(0, 5, 0, 0);
                }

                Mouse.Close();
            }

            Console.ReadKey();
        }
    }
}