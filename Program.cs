using System;

namespace majasdarbs
{
    class Program
    {
        static void Main(string[] args)
        {
            string yesno;
            int sessijuSkaititajs = 1;
            string userId = "Anonīmais";

            do
            {
                Console.Clear();
                string currentUser = userId;
                Console.WriteLine("Sessija numurs {0}, Lietotājs: {1}", sessijuSkaititajs, currentUser);
                Console.WriteLine("---------------------------------------");
                if (sessijuSkaititajs == 1) { userId = Lietotajs(HelloUser()); };
                sessijuSkaititajs++;
                //------Viss izpildams kodz zemāk---------

                ReizTabula();
                Console.Write("Lai turpināt, nospied enter: ");
                Console.ReadLine();
                Zvaigznes();
                Console.Write("Lai turpināt, nospied enter: ");
                Console.ReadLine();
                SkaitamAtpakal();


                //------Te izpildams kods beidzas---------
                Console.WriteLine("----------------------------------------");
                Console.Write("Vēlies atkartot visu no jauna? (y/n): ");
                yesno = Console.ReadLine();
            }
            while (yesno == "y");
        }
        //-------Šeit sākas funkcijas---------

        static void SkaitamAtpakal() // 3) Uzdevums, atpakaļskaitīšana
        {
            Console.WriteLine("--------------Uzdevums uz atpakaļskaitīšanu--------------");
            int i;
            for (i = 10; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }


        static void Zvaigznes() // 2) Uzdevums - zvaigžņu izvads
        {
            string zvaigznes = "*";
            Console.WriteLine("--------------Uzdevums ar zvaigznītēm--------------");

            while (zvaigznes != "****")
            {
                Console.WriteLine(zvaigznes);
                zvaigznes = zvaigznes + "*";
            }
        }

        static void ReizTabula() //1) uzdevums reizrēķina tabula 
        {
            Console.WriteLine();
            Console.WriteLine("--------------------uzdevums par reizrēķina tabulu------------------");
            Console.Write("Kuram skaitlim no 1 līdz 10 tu gribētu redzēt reizrēķina tabulu?: ");
            int izvads = 0;
            string ievads = Console.ReadLine();
            int number;
            
            bool result = Int32.TryParse(ievads, out number); // Šī ir pārbaude vait tiešām numurs
            if (result)
            {
                izvads = number;
                //Console.WriteLine("Converted '{0}' to {1}.", ievads, number);
            }
            else
            {
                Console.WriteLine("Man tavs ievads neisskatījies pēc cipara!");
            } //pārbaudes beigas
			while (number < 1 || number > 10)
			{
				Console.Write("Tu izbēlējies vai nu pa daudz, va pa maz. Ievadi skaitli no 1 līdz 10: ");
				number = Convert.ToInt16(Console.ReadLine());
			}

			Console.WriteLine();
			Console.WriteLine("---------------reizrēķina tabula uz {0}----------------", izvads);
			for (int i = 1; i <= 10; i++)
			{
				int a = izvads, b;
				b = a * i;
				Console.WriteLine("{0} * {1} = {2}", a, i, b);
			}
			Console.WriteLine();

        }

        static string Lietotajs(string lietotajs)
        {
            string kaslieto;
            kaslieto = lietotajs;
            return kaslieto;
        }
        static string HelloUser() //---Iepazišanas funkcija
        {
            string userID = "Anonīmāis";

            Console.WriteLine("čau! Esmu C# programma. ");
            Console.Write("Vēlies iepazīties? (y/n): ");
            string yesno = Console.ReadLine();

            switch (yesno)
            {
                case "n":
                    Console.WriteLine("Labs ir, saukšu tevi par {0} ;) ", userID);
                    yesno = "n";
                    break;

                case "y":
                    Console.WriteLine("Forši! Kā man tevi saukt? ");
                    userID = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Prieks iepazīties, {0}!", userID);
                    yesno = "y";
                    break;

                default:
                    Console.Write("Runā skaļāk - slikti dzirdu (iepazīties = y, palikt anonīmām = n ): ");
                    yesno = Console.ReadLine();
                    if (yesno == "y")
                    {
                        goto case "y";
                    }
                    else
                    {
                        if (yesno == "n")
                        {
                            goto case "n";
                        }
                        else
                        {
                            goto default;
                        }
                    }
            }
            return userID;
        }

    }//-------class beigas--------------
}