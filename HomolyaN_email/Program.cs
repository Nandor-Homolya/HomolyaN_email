using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HomolyaN_email
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> e_mailok = new List<String>();
            e_mailok.Add("alma1@kört.hu");
            e_mailok.Add("alma2@dfdfdf.hu");
            e_mailok.Add("alma3@sdsddsd.hu");
            e_mailok.Add("solteszz@kkszki.hu");
            e_mailok.Add("alma1@kört.com");
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
                    case "1":
                        Console.Clear();
                        Console.WriteLine("emailek listázása");
                        int sorszam = 0;
                            foreach (String e_mail in e_mailok)
                        {
                            Console.WriteLine($"{sorszam++}  {e_mail}");
                        }
                            break;
                    case "2": Console.WriteLine("új emailek");
                        Console.WriteLine("Adja meg a z új email címet:");
                        String uj = Console.ReadLine();
                        e_mailok.Add(uj);
                        break;
                    case "3": Console.WriteLine("email törlése");
                        Console.WriteLine("Adja meg a törlendő email azonosítóját: ");
                        int index= Convert.ToInt32(Console.ReadLine());
                        e_mailok.RemoveAt(index);
                        break;
                    case "4": Console.WriteLine("érvényes emailok listája");
                        foreach (String email in e_mailok)
                        {
                            if (email.Contains(".") && email.Contains("@"))
                            {
                                Console.WriteLine(email);
                            }
                        }
                        break;
                    default : Console.WriteLine("rossz parancs");break;
                }
                Console.ReadLine();
            }
        }
    }
}
