using LibreriaMatematica;
using System;

namespace Matematica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inserisci il primo numero: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Inserisci il secondo numero: ");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Quale operazione vuoi fare? (A/S/D/P/Max/Min)");
            string risposta = Console.ReadLine();

            double risultato;
            switch (risposta)
            {
                case "Max":
                    risultato = Operazioni.Max(n1, n2);
                    break;
                case "Min":
                    risultato = Operazioni.Min(n1, n2);
                    break;
                case "A":
                    risultato = Operazioni.Somma(n1, n2);
                    break;
                case "S":
                    risultato = Operazioni.Sottrazione(n1, n2);
                    break;
                case "D":
                    risultato = Operazioni.Divisione(n1, n2);
                    break;
                case "P":
                    risultato = Operazioni.Potenza(n1, n2);
                    break;
                default:
                    throw new Exception("Scelta non valida");
                    Console.WriteLine(risultato);
                    try
                    {
                        risultato = Operazioni.Divisione(n1, n2);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        risultato = double.NaN;
                    }
            }


            Console.WriteLine(risultato);
            Console.ReadLine();

            int somma = Operazioni.Somma(n1, n2);
            Console.WriteLine(somma);

            int sottrazione = Operazioni.Sottrazione(n1, n2);
            Console.WriteLine(sottrazione);

            double divisione = Operazioni.Divisione(n1, n2);
            Console.WriteLine(divisione);
            Console.ReadLine();

            double potenza = Operazioni.Potenza(n1, n2);
            Console.WriteLine(potenza);
            Console.ReadLine();

            double max = Operazioni.Max(n1, n2);
            Console.WriteLine(max);
            Console.ReadLine();

            double min = Operazioni.Min(n1, n2);
            Console.WriteLine(min);
            Console.ReadLine();
        }
    }
}
