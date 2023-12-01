using static System.Net.Mime.MediaTypeNames;

namespace Parprogrammering
{
    internal class Program
    {
        static void Main()
        {
            /* Reverser Stringen!
      Lag et program hvor du kan skrive inn en tekst, og når du sender teksten inn vil du få tilbake teksten reversert. Gjør dette uten å bruke innebygde reverse metoder
      Bygg videre ved å legge til flere ting man kan gjøre med stringen, eksempel:
       Alternativer for hva man vil gjøre, trykk 1, 2 eller 3 for å reversere, konvertere til uppercase eller lowercase*/

            Console.WriteLine("Skriv inn teksten du vil gjøre noe med");
            string userInput = Console.ReadLine();


            while (true)
            {
                Console.WriteLine("Velg hva du vil gjøre");
                Console.WriteLine("1: Reversere tekst");
                Console.WriteLine("2: Konvertere til upperCase");
                Console.WriteLine("3: Konvertere til lowercase");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                    string reverseText = ReversedText(userInput);
                    Console.WriteLine($"Reversert tekst: {reverseText}");
                    break;

                    case "2":
                    string upperCase = ToUppercase(userInput);
                    Console.WriteLine($"Uppercase tekst: {upperCase}");
                    break;

                    case "3":
                    string lowerCase = ToLowercase(userInput);
                    Console.WriteLine($"Lowercase tekst: {lowerCase}");
                    break;

                    default: 
                        Console.WriteLine("Ugyldig valg. Prøv igjen");
                        break;
                }

            }
        }
        static string ReversedText(string text)
        {
            char[] charArray = text.ToCharArray();     //charArray konverterer til tegnarray. Detter gjøres ved å bruke ToCharArray() metoden, som konverterer strengen til en array av tegn
            int start = 0;      //starter på første bokstav(index) start representerer starten av arrayet, og end representerer slutten av arrayet.
            int end = charArray.Length - 1;
        
            while (start < end)
            {

                char temp = charArray[start];
                charArray[start] = charArray[end];     //Bytter om posisjonene for start og end
                charArray[end] = temp;

                start++;
                end--;
            }

            return new string(charArray); //blir reversert tengarrayet konvertert til en streng ved hjelp av new string(charArray) og retunert
        }
        static string ToUppercase(string text)
        {
            char[] charArray = text.ToCharArray();
            int i = 0;

            while (i < charArray.Length)
            {
                charArray[i] = char.ToUpper(charArray[i]);
                i++;
            }
            return new string(charArray);
        }

        static string ToLowercase(string text)
        {
            char[] charArray = text.ToCharArray();
            int i = 0;

            while ( i < charArray.Length)
            {
                charArray[i] = char.ToLower(charArray[i]);
                i++;
            }
            return new string(charArray);
        }
    }
    
}

