//Importere mange navne
using System;
using System.Diagnostics;

namespace Main
{
  class Program
  {
    static void Main(string[] args)
    {
      int age = 20; // Variabel der hedder age som har værdien 20. int står for integer, som er et heltal.
      // anden måde at lave variabler på 
      int age2;
      age2 = 30;

      Console.WriteLine(age);
      Console.WriteLine(age2);
      // Bruges til at udskrive variabler i konsollen. Max og Min er for at vise den største og mindste værdi som en variabel kan have
      Console.WriteLine(int.MaxValue);
      Console.WriteLine(int.MinValue);

      // double er en anden type variabel. Grunden til at det hedder double er fordi at det kan have decimaler, i modsætning til int som kun kan have heltal.
      double negative = -10.23;
      Console.WriteLine(negative);
      Console.WriteLine(double.MaxValue);
      Console.WriteLine(double.MinValue);

      // long er også en anden type variabel
      long bigNumber = 90000000L; // L'et i slutningen er for at fortælle at det er en long variabel, ellers ville den blive lavet som en int.
      int anotherNumber = 9000000L; // Dette vil give en fejl, fordi 9000000L er for stort til at være en int. Det skal være 9000000 i stedet.
      // casting er når man konverterer en variabel fra en type til en anden som vi gør her

      Console.WriteLine(bigNumber);
      Console.WriteLine(long.MaxValue);
      Console.WriteLine(long.MinValue);

    }
  }
}

// Hvordan man laver variabler
// For at lave dem kan man f.ek.s skrive int som står for integers