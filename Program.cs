using System;

namespace classWork
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Number:");
            // int number = int.Parse(Console.ReadLine());
            // for (int i = 0; i <= 10; i++)
            // {
            //     Console.WriteLine($"{number} x {i} = {i*number}");
            // }
            // {
            //     Console.WriteLine("Nayti nechyotnye chisla: ");
            //     Console.WriteLine("ot Chisla: ");
            //     int beginnerNumber = int.Parse(Console.ReadLine());

            //     Console.WriteLine("Do Chisla: ");
            //     int toNumber = int.Parse(Console.ReadLine());
            //     for (int i = beginnerNumber; i <= toNumber; i++)
            //     {
            //         if (i % 2 == 0){
            //             Console.WriteLine(i);
            //         }
            //     }

            // }
            // {
            //     int iForWhile = 0;
            //     while (iForWhile < 10){
            //         Console.WriteLine(iForWhile);
            //         iForWhile++;
            //     }
            // }
            // {
            //     int number = 5;
            //     int numberOfTry = 3;

            //     while (numberOfTry != 0){
            //         Console.WriteLine("Gues number 1-100");
            //         int inPutNumber = int.Parse(Console.ReadLine());
            //         if (inPutNumber == number){
            //             Console.WriteLine("You win!");
            //          break;
            //         } else {
            //             Console.WriteLine($"ostalos' {numberOfTry} popitok!");
            //             numberOfTry--;
            //         }
            //     }
            // }
            // {
            //     string moyUchitel = "Azizjon";
            //     int popitki = 2;

            //     while (popitki != 0){
            //         Console.WriteLine("Guess the name of my teacher: ");
            //         string inputName = Console.ReadLine();
            //         if (inputName == moyUchitel){
            //             Console.WriteLine("You guess!");
            //         break;
            //         } else {
            //             Console.WriteLine($"You have {popitki} try)");
            //             popitki--;
            //         }
            //     }
            // }
            {
                Console.WriteLine("Enter number: ");
                int firstNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter number: ");
                int secondNumber = int.Parse(Console.ReadLine());
                int summa = 0;

                for (int i= firstNumber; i <= secondNumber; i++){
                    summa += i;
                    
                }
                Console.WriteLine(summa);

                
            }
        }
    }
}
