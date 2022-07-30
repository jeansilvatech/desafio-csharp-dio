using System;
using csharp_projeto.src.Entities;


    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 23, "Knight");
            Wizard jennica = new Wizard("Jennica", 23, "White Wizard");
        
            Console.WriteLine(arus.Attack());
            Console.WriteLine(jennica.Attack());
            Console.WriteLine(jennica.Attack(20));

            
        }
        
    }
