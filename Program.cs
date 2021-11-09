using System;
using System.Windows;
namespace CurrencyCalculator
{
    class Program
    {
        public static void readAndClear() { //Functie voor de stappen om terug te keren naar het begin
            Console.WriteLine("\n\n");
            Console.WriteLine("Press enter to return to start...");
            Console.Read();
            Console.Clear();
            Console.Read();
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Dit zorgt er voor dat de codes worden omgezet in tekens
            bool program = true; //Voor de while loop, om te zorgen dat de gebruiker na conversie terugkeert naar het begin van het programma
            while (program == true)
            {
                string firstCurrency; //Eerste ingegeven munteenheid door gebruiker
                double firstAmount; //Het ingegeven bedrag van de gebruiker
                string secondCurrency; //De gewenste munteenheid
                double secondAmount; //Het bedrag met de nieuwe munteenheid na conversie
                string euroSign = "\u20AC"; //Codes voor de munteenheid tekens
                string poundSign = "\u00A3";
                string dollarSign = "$";
                string yenSign = "\u00A5";
                string bitcoinSign = "\u20BF";

                Console.WriteLine("WELCOME TO THE CURRENCY CONVERTER!\n");
                Console.WriteLine("Please insert your current currency (Euro, Pound, Dollar, Yen, Bitcoin): ");
                firstCurrency = Console.ReadLine().ToLower(); //ToLower zodat inputs met hoofdletters worden omgezet
                Console.WriteLine();
                Console.WriteLine("Please insert the amount of money you want to convert: ");
                while (!double.TryParse(Console.ReadLine(), out firstAmount)) { //Kijkt of er cijfers ingevoerd worden
                    Console.WriteLine();
                    Console.Clear();
                    Console.WriteLine("Please enter numbers only!\n");
                    Console.WriteLine("Please insert the amount of money you want to convert: ");
                    continue;
                }
                Console.WriteLine();
                Console.WriteLine("What is the currency you want to convert to? (Euro, Pound, Dollar, Yen, Bitcoin): ");
                secondCurrency = Console.ReadLine().ToLower();
                Console.WriteLine();

                if (firstCurrency == "euro") { //Als Euro de eerste ingevoerde munteenheid is
                    switch (secondCurrency) {
                        case "pound":
                            secondAmount = firstAmount * 0.86;
                            Console.WriteLine(euroSign + firstAmount.ToString() + " is equal to " + poundSign + secondAmount.ToString()); //De amounts worden omgezet naar strings om ze te kunnen weergeven
                            readAndClear();
                            continue;
                        case "dollar":
                            secondAmount = firstAmount * 1.16;
                            Console.WriteLine(euroSign + firstAmount.ToString() + " is equal to " + dollarSign + secondAmount.ToString());
                            readAndClear();
                            continue;
                        case "yen":
                            secondAmount = firstAmount * 130.90;
                            Console.WriteLine(euroSign + firstAmount.ToString() + " is equal to " + yenSign + secondAmount.ToString());
                            readAndClear();
                            continue;
                        case "bitcoin":
                            secondAmount = firstAmount * 0.000017;
                            Console.WriteLine(euroSign + firstAmount.ToString() + " is equal to " + bitcoinSign + secondAmount.ToString());
                            readAndClear();
                            continue;
                        default:
                            break;
                    }
                } else if (firstCurrency == "pound") {
                    switch (secondCurrency) {
                        case "euro":
                            secondAmount = firstAmount * 1.17;
                            Console.WriteLine(poundSign + firstAmount.ToString() + " is equal to " + euroSign + secondAmount.ToString()); //De amounts worden omgezet naar strings om ze te kunnen weergeven
                            readAndClear();
                            continue;
                        case "dollar":
                            secondAmount = firstAmount * 1.36;
                            Console.WriteLine(poundSign + firstAmount.ToString() + " is equal to " + dollarSign + secondAmount.ToString());
                            readAndClear();
                            continue;
                        case "yen":
                            secondAmount = firstAmount * 153.07;
                            Console.WriteLine(poundSign + firstAmount.ToString() + " is equal to " + yenSign + secondAmount.ToString());
                            readAndClear();
                            continue;
                        case "bitcoin":
                            secondAmount = firstAmount * 0.000020;
                            Console.WriteLine(poundSign + firstAmount.ToString() + " is equal to " + bitcoinSign + secondAmount.ToString());
                            readAndClear();
                            continue;
                        default:
                            break;
                    }
                } else if (firstCurrency == "dollar") {
                    switch (secondCurrency) {
                        case "euro":
                            secondAmount = firstAmount * 0.82;
                            Console.WriteLine(dollarSign + firstAmount.ToString() + " is equal to " + euroSign + secondAmount.ToString()); //De amounts worden omgezet naar strings om ze te kunnen weergeven
                            readAndClear();
                            continue;
                        case "pound":
                            secondAmount = firstAmount * 0.74;
                            Console.WriteLine(dollarSign + firstAmount.ToString() + " is equal to " + poundSign + secondAmount.ToString());
                            readAndClear();
                            continue;
                        case "yen":
                            secondAmount = firstAmount * 112.82;
                            Console.WriteLine(dollarSign + firstAmount.ToString() + " is equal to " + yenSign + secondAmount.ToString());
                            readAndClear();
                            continue;
                        case "bitcoin":
                            secondAmount = firstAmount * 0.000015;
                            Console.WriteLine(dollarSign + firstAmount.ToString() + " is equal to " + bitcoinSign + secondAmount.ToString());
                            readAndClear();
                            continue;
                        default:
                            break;
                    }
                } else if (firstCurrency == "yen") {
                    switch (secondCurrency) {
                        case "euro":
                            secondAmount = firstAmount * 0.0076;
                            Console.WriteLine(yenSign + firstAmount.ToString() + " is equal to " + euroSign + secondAmount.ToString()); //De amounts worden omgezet naar strings om ze te kunnen weergeven
                            readAndClear();
                            continue;
                        case "pound":
                            secondAmount = firstAmount * 0.0065;
                            Console.WriteLine(yenSign + firstAmount.ToString() + " is equal to " + poundSign + secondAmount.ToString());
                            readAndClear();
                            continue;
                        case "dollar":
                            secondAmount = firstAmount * 0.0088;
                            Console.WriteLine(yenSign + firstAmount.ToString() + " is equal to " + dollarSign + secondAmount.ToString());
                            readAndClear();
                            continue;
                        case "bitcoin":
                            secondAmount = firstAmount * 0.00; //lmao
                            Console.WriteLine(yenSign + firstAmount.ToString() + " is equal to " + bitcoinSign + secondAmount.ToString());
                            readAndClear();
                            continue;
                        default:
                            break;
                    }
                } else if (firstCurrency == "bitcoin") {
                    switch (secondCurrency) {
                        case "euro":
                            secondAmount = firstAmount * 57.46481;
                            Console.WriteLine(bitcoinSign + firstAmount.ToString() + " is equal to " + euroSign + secondAmount.ToString()); //De amounts worden omgezet naar strings om ze te kunnen weergeven
                            readAndClear();
                            continue;
                        case "pound":
                            secondAmount = firstAmount * 49.12606;
                            Console.WriteLine(bitcoinSign + firstAmount.ToString() + " is equal to " + poundSign + secondAmount.ToString());
                            readAndClear();
                            continue;
                        case "dollar":
                            secondAmount = firstAmount * 66.52980;
                            Console.WriteLine(bitcoinSign + firstAmount.ToString() + " is equal to " + dollarSign + secondAmount.ToString());
                            readAndClear();
                            continue;
                        case "yen":
                            secondAmount = firstAmount * 7.51862581; //lmao
                            Console.WriteLine(bitcoinSign + firstAmount.ToString() + " is equal to " + yenSign + secondAmount.ToString());
                            readAndClear();
                            continue;
                        default:
                            break;
                    }
                } else {
                    Console.Clear();
                    Console.WriteLine("That is not a valid currency.");
                    readAndClear();
                    continue;
                }
            }
        }
    }
}
