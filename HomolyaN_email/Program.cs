using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomolyaN_email
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) { 
                Console.Clear();
                Console.WriteLine("0. Kilépés");
                Console.WriteLine("1. emailek listázása");
                Console.WriteLine("2. új email");
                Console.WriteLine("3. email törlése");
                Console.WriteLine("4. érvényes emailek listázása");
                
                string valasztas=Console.ReadLine();
                switch (valasztas)
                {
                    case "0": return;
                    case "1": Console.WriteLine("emailek listázása"); break;
                    case "2": Console.WriteLine("új emailek");break;
                    case "3": Console.WriteLine("email törlése"); break;
                    case "4": Console.WriteLine("érvényes listázása");break;
                    default : Console.WriteLine("rossz parancs");break;
                }
                Console.ReadLine();
            }
        }
    }
}
