namespace bazza_danni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int izbor = 0;

            while (izbor != 4)
            {
                Console.WriteLine("\n--- BROINI SISTEMI ---");
                Console.WriteLine("1. Dvoichna v desetichna");
                Console.WriteLine("2. Osmichna v desetichna");
                Console.WriteLine("3. Shestnadesetichna v desetichna");
                Console.WriteLine("4. Izhod");

                Console.Write("Izberi opcia: ");
                izbor = int.Parse(Console.ReadLine()!);

                if (izbor == 1)
                {
                    Console.Write("Vuvedi dvoichno chislo: ");
                    string chislo = Console.ReadLine()!;

                    int rezultat = 0;

                    for (int i = 0; i < chislo.Length; i++)
                    {
                        int cifra = chislo[i] - '0';
                        rezultat = rezultat * 2 + cifra;
                    }

                    Console.WriteLine("Desetichno: " + rezultat);
                }
                else if (izbor == 2)
                {
                    Console.Write("Vuvedi osmichno chislo: ");
                    string chislo = Console.ReadLine()!;

                    int rezultat = 0;

                    for (int i = 0; i < chislo.Length; i++)
                    {
                        int cifra = chislo[i] - '0';
                        rezultat = rezultat * 8 + cifra;
                    }

                    Console.WriteLine("Desetichno: " + rezultat);
                }
                else if (izbor == 3)
                {
                    Console.Write("Vuvedi 16-tichno chislo: ");
                    string chislo = Console.ReadLine()!;

                    int rezultat = 0;

                    for (int i = 0; i < chislo.Length; i++)
                    {
                        int cifra = 0;

                        if (chislo[i] >= '0' && chislo[i] <= '9')
                        {
                            cifra = chislo[i] - '0';
                        }
                        else if (chislo[i] >= 'A' && chislo[i] <= 'F')
                        {
                            cifra = chislo[i] - 'A' + 10;
                        }
                        else if (chislo[i] >= 'a' && chislo[i] <= 'f')
                        {
                            cifra = chislo[i] - 'a' + 10;
                        }

                        rezultat = rezultat * 16 + cifra;
                    }

                    Console.WriteLine("Desetichno: " + rezultat);
                }
                else if (izbor == 4)
                {
                    Console.WriteLine("Krai na programata!");
                }
                else
                {
                    Console.WriteLine("Nevalidna opcia!");
                }
            }
        }
    }
}
