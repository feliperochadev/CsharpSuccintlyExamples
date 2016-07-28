using System;
using Syncfusion;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        //1
        //Console.Write("Greetings");       
        
        //2 and 3
        // double hypotenuse = Calc.Pythagorean(2, 3);
        // Console.WriteLine($"Hypotenuse: {hypotenuse}");

        //4
        //int count = 7;
        //char keyPressed = 'Q';
        //string title = "Weekly Report";
        
        //5
        //string title;
        //6
        //title = "Weekly Report";


        //7 and 8
        // int total = int.Parse("359");
        // string message = 7.ToString();

        // //9
        // double preciseLength = 5.61;
        // int roundedLength = (int)preciseLength;

        // //10
        // decimal price = 9.95m;

        // //11
        // char cr = '\u0013';

        // //12
        // int crUnicode = (int)cr;

        // //13
        // int val1 = 5;
        // int val2 = ++val1;
        // int val3 = 2;
        // int val4 = val3--;

        // //14
         decimal priceGain = 2.5m;
        // string action = priceGain > 2m ? "Buy" : "Sell";

        // //15
        // DateTime currentTime = DateTime.Now;
        // string shortDateString = currentTime.ToShortDateString();
        // string longDateString = currentTime.ToLongDateString();
        // string defaultDateString = currentTime.ToString();
        // DateTime Tomorrow = currentTime.AddDays(1);

        // //16
        // int result1 = 2 + 3 * 5;
        // int result2 = (2 + 3) * 5;

        // //17
        // string name = "Joe";
        // string helloViaConcatenation = "Hello, " + name + "!";
        // Console.WriteLine(helloViaConcatenation);

        // //18 and 19
        // string helloviaStringFormat = string.Format("Hello, {0}!", name);
        // Console.WriteLine(helloviaStringFormat);

        // //20
        // string item = "bread";
        // decimal amount = 2.25m;
        // Console.WriteLine("{0, -10}{1:C}", item, amount);

        // //21
        // Console.WriteLine($"{item}   {amount}");

        // //22
        // Console.WriteLine($"{nameof(item)}: {item,-10} {nameof(amount)}: {amount:C}");

        // //23
        // string action2 = "Sell";
        // if(priceGain > 2m)
        // {
        //     action2 = "Buy";
        // }

        // //24
        // string action3 = "Do Nothing";
        // if(priceGain <= 2m)
        // {
        //     action3 = "Sell";
        // }
        // else
        // {
        //     action3 = "Buy";
        // }

        // //25
        // string action4 = null;
        // if(priceGain <= 2m)
        // {
        //     action4 = "Sell";
        // }else if (priceGain > 2m && priceGain <= 3m)
        // {
        //     action4 = "Do Nothing";
        // }
        // else
        // {
        //     action4 = "Sell";
        // }

        //26
        string currentWeather = "rain";
        string equipment = null;
        switch (currentWeather)
        {
            case "sunny":
                equipment = "sunglasses";
                break;
            case "rain":
                equipment = "umbrella";
                break;
            case "cold":    
            default:
                equipment = "jacket";
                break;
        }

        //27
        int [] oddNumbers = {1, 3, 5};
        int firstOdd = oddNumbers[0];
        int lastOdd = oddNumbers[2];

        //28
        string [] names = new string[3];
        names[1] = "Joe";

        //29
        List<decimal> stockPrices = new List<decimal>();
        stockPrices.Add(56.23m);
        stockPrices.Add(72.80m);
        decimal secondStockPrice = stockPrices[1];

        //30
        double[] temperatures = {72.3, 73.8, 75.1, 74.9};
        for (int i = 0; i < temperatures.Length; i++)
        {
            Console.WriteLine(i);
        }

    }
}
