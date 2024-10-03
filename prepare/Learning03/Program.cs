using System;

class Program
{
    static void Main(string[] args)
    { //Aqui na classe principal, eu uso Fraction nome da fracao = new Fraction para invocar a classe
      //e invoco os construtores com fracao1. e assim por diante.
      
        Fraction fracao1 = new Fraction();
        Console.WriteLine(fracao1.GetFraction());
        Console.WriteLine(fracao1.GetDecimalValue());

        Fraction fracao2 = new Fraction(5);
        Console.WriteLine(fracao2.GetFraction());
        Console.WriteLine(fracao2.GetDecimalValue());

        Fraction fracao3 = new Fraction(3, 4);
        Console.WriteLine(fracao3.GetFraction());
        Console.WriteLine(fracao3.GetDecimalValue());

        Fraction fracao4 = new Fraction(1, 3);
        Console.WriteLine(fracao4.GetFraction());
        Console.WriteLine(fracao4.GetDecimalValue());
    }
}