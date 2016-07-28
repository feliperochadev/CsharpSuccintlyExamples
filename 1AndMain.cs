using System;
using Syncfusion;
class Program
{
    static void Main()
    {
        //1
        //Console.Write("Greetings");       
        
        //2 and 3
        double hypotenuse = Calc.Pythagorean(2, 3);
        Console.WriteLine($"Hypotenuse: {hypotenuse}");
        //Crypto.AesManaged aes = new Crypto.AesManaged();
        Console.ReadKey();

    }
}
