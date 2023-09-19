using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Gyak2
{
    internal class Program
    {
        static void One()
        {
            Console.WriteLine("1. Even numbers: Give N to list even numbers to.");
            int n = int.Parse(Console.ReadLine());
            int cv = 0;
            while (n >= cv)
            {
                if (cv % 2 == 0) //ha 2-vel osztható
                {
                    Console.Write($"{cv}, ");
                }
                cv++;
            }
            Console.WriteLine("\nEnd of 1. feladat, press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }
        static void Two()
        {
            Console.WriteLine("2. Create your password:");
            string pass = Console.ReadLine();
            Console.Clear();
            int numofTries = 1;
            bool success = false;
            while (3 >= numofTries && success == false)
            {
                Console.WriteLine("Give your password");
                string passwordTry = Console.ReadLine();
                if (passwordTry == pass)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Success!");
                    Console.ForegroundColor = ConsoleColor.White;
                    success = true;
                }
                else if (numofTries == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Clear();
                    Console.WriteLine("Error! You have reached the maximum amount of tries!");
                    Console.ForegroundColor = ConsoleColor.White;
                    numofTries++;
                }
                else
                {
                    Console.WriteLine("Incorrect password, try again.");
                    numofTries++;
                }

            }
            Console.WriteLine("End of 2. feladat, press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }
        static void Three()
        {
            Console.Write("3. Random numbers against a given number. Give a number between 1-1000. ");
            int UsersNumber = int.Parse(Console.ReadLine());
            Random r = new Random();
            int randomNumber;
            int numofRandomTries = 0;
            do
            {
                randomNumber = r.Next(1, 1001);
                numofRandomTries++;
                Console.WriteLine($"The random number is {randomNumber}");
                if (randomNumber == UsersNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"The random number matches the user number. It took {numofRandomTries} tries.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            } while (UsersNumber != randomNumber);
            Console.WriteLine("End of 3. feladat, press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }
        static void Four()
        {
            Console.WriteLine("4. Give the number of starting players.");
            int numOfPlayers = int.Parse(Console.ReadLine());
            Random rNum = new Random();
            int whoStarts = rNum.Next(1, numOfPlayers + 1);
            Console.WriteLine($"Player {whoStarts} stars the throwing.");
            int currentPlayer = whoStarts;
            int thrownNumber;
            do
            {
                thrownNumber = rNum.Next(1, 7);
                Console.WriteLine("Press enter to throw the die.");
                Console.ReadKey(); //nem enterre, de vár a felhasználóra
                Console.WriteLine($"Player {currentPlayer} threw a {thrownNumber}.");
                if (thrownNumber == 6)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Player {currentPlayer} threw a 6, they may start the game.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                if (currentPlayer == numOfPlayers)
                {
                    currentPlayer = 1;
                }
                else
                {
                    currentPlayer++;
                }
            } while (thrownNumber != 6);
            Console.WriteLine("End of 4. feladat, press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }
        static void Five()
        {
            Random rSzam = new Random();
            int thoughtNumber = rSzam.Next(1, 1000);
            int userNumber;
            int numbOfTries = 0;
            do
            {
                Console.WriteLine("5. Give your guess of the number.");
                userNumber = int.Parse(Console.ReadLine());
                if (userNumber == thoughtNumber)
                {
                    numbOfTries++;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Congratulations, you guessed right, {thoughtNumber} was the number! It took {numbOfTries} tries.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (userNumber > thoughtNumber)
                {
                    Console.Clear();
                    Console.WriteLine($"The number in question is smaller than {userNumber}.");
                    numbOfTries++;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"The number in question is bigger than {userNumber}.");
                    numbOfTries++;
                }
            } while (userNumber != thoughtNumber);
            Console.WriteLine("End of 5. feladat, press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }
        static void Six()
        {
            Console.WriteLine("6. Give a number to check amount of divisors of..");
            int userNum = int.Parse(Console.ReadLine());
            if (userNum == 1 || userNum == 0)
            {
                if (userNum == 1)
                {

                    Console.WriteLine($"The number 1 is odd, but is neither prime nor composite.");
                }
                else
                {
                    Console.WriteLine($"The number 0 is even, but is neither prime nor composite.");
                }
            }
            else
            {


                if (userNum % 2 == 0)
                {
                    Console.WriteLine("The number is even.");
                }
                else
                {
                    Console.WriteLine("The number is odd.");
                }
                int amountOfDivisors = 0;
                for (int i = 2; i < userNum - 1; i++)
                {
                    if (userNum % i == 0)
                    {
                        amountOfDivisors++;
                    }
                }
                if (amountOfDivisors == 0)
                {
                    Console.WriteLine($"The number {userNum} is a prime, it has 0 real divisors.");
                }
                else
                {
                    Console.WriteLine($"The number {userNum} has {amountOfDivisors} real divisors, therefore it is a composite number.");
                }
            }
            Console.WriteLine("End of 6. feladat, press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }
        static void Seven()
        {
            Console.WriteLine("7. Factorials. Give a number");
            Console.Write("N = ");
            int factorialNum = int.Parse(Console.ReadLine());
            int productOfFactorial = 1;
            Console.Write($"{factorialNum}! = ");
            for (int i = factorialNum; i > 0; i--)
            {
                if (i == 1)
                {
                    Console.Write($"{i}");
                }
                else
                {
                    Console.Write($"{i}×");
                    productOfFactorial *= i;
                }
            }
            Console.WriteLine($" = {productOfFactorial}");
            Console.WriteLine("End of 7. feladat, press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }
        static void Eight()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (j == 0 && i == 0)
                    {
                        Console.Write("    ");
                    }
                    else if (j == 0 || i == 0)
                    {

                        Console.Write($"{j + i,3} ");
                    }
                    else
                    {
                        Console.Write($"{j * i,3} ");
                    }
                    if (j == 9)
                    {
                        Console.WriteLine("\n");
                    }
                }

            }
            Console.WriteLine("\nEnd of 8. feladat, press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }
        static void Nine()
        {
            Console.WriteLine("9. Give a time value in seconds");
            int timeInSeconds = int.Parse(Console.ReadLine());
            int givenTime = timeInSeconds;
            for (int i = 0; i < givenTime + 3; i++)
            {
                if (timeInSeconds % 60 >= 10 && timeInSeconds > 1)
                {

                    Console.WriteLine($"{timeInSeconds / 60}:{timeInSeconds % 60}");
                }
                else
                {
                    Console.WriteLine($"{timeInSeconds / 60}:0{timeInSeconds % 60}");
                }
                Thread.Sleep(1000);
                Console.Clear();
                if (timeInSeconds != 0)
                {
                    timeInSeconds -= 1;
                }
                else
                {
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Beep();
                }
            }
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("\nEnd of 9. feladat, press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }
        static void Ten()
        {
            Console.WriteLine("10. Give number in base 10 to convert into base 2.");
            int numInBaseten = int.Parse(Console.ReadLine());
            int originalnumInBaseTen = numInBaseten;
            string numInBasetwo = "";
            do
            {
                if (numInBaseten % 2 == 0)
                {
                    numInBasetwo += "0";
                }
                else
                {
                    numInBasetwo += "1";
                }
                if (numInBasetwo.Length % 9 ==8&&numInBasetwo.Length!=1)
                {
                    numInBasetwo += " ";
                }
                numInBaseten /= 2;
            } while (35 > numInBasetwo.Length);
            string invertedNumInBaseTwo = "";
            for (int i = numInBasetwo.Length-1; i > 0; i--)
            {
                invertedNumInBaseTwo += numInBasetwo[i-1];
            }
            //hiányzik: big endian formátum
            Console.WriteLine($"{originalnumInBaseTen} (10) = {invertedNumInBaseTwo}");
            Console.WriteLine("\nEnd of 10. feladat, press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }
        static void Eleven()
        {
            int credits = 100;
            int bet = 1;
            ConsoleKeyInfo input;
            do
            {
                Console.WriteLine($"11. Casino game. Your credits: {credits}");
                Console.WriteLine($"Give your bet. Up arrow increases and down arrow decreases your bet . \nPress Space to check your roll and Escape to exit the game.\nPress n to enter a custom value.\nYour bet: {bet}");
                input = Console.ReadKey(true);
                Console.Clear();

                if (input.Key.Equals(ConsoleKey.UpArrow) && credits > bet)
                {
                    bet++;
                }
                if (input.Key.Equals(ConsoleKey.N))
                {
                    Console.WriteLine($"Enter new value (1-{credits})");
                    int newBetNumber = int.Parse(Console.ReadLine());
                    if (newBetNumber > credits || 0 > newBetNumber)
                    {
                        Console.WriteLine("Invalid value.");
                        bet = 1;
                    }
                    else
                    {
                        bet = newBetNumber;
                    }
                }
                if (input.Key.Equals(ConsoleKey.DownArrow) && bet > 1)
                {
                    bet--;
                }
                if (input.Key.Equals(ConsoleKey.Spacebar))
                {
                    Random randomRoll = new Random();

                    int num1 = randomRoll.Next(1, 20);
                    int num2 = randomRoll.Next(1, 20);
                    int num3 = randomRoll.Next(1, 20);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"The rolls are {num1} {num2} {num3}");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (num1 == num2 && num2 == num3)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        credits += bet * 50;
                        Console.WriteLine($"Congratulations! You won the jackpot, a triple match! Your credits are now {credits}.");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (num1 == num2)
                    {
                        credits += bet * 10;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"You got a match! Your credits are now {credits}.");
                        Console.ForegroundColor = ConsoleColor.White;

                    }
                    else if (num2 == num3)
                    {
                        credits += bet * 10;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"You got a match! Your credits are now {credits}.");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (num1 == num3)
                    {
                        credits += bet * 10;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"You got a match! Your credits are now {credits}.");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        credits -= bet;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Sorry, no matches this time. Better luck next time! Your credits are {credits}.");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    bet = 1;
                }
            }
            while (credits > 0 && !input.Key.Equals(ConsoleKey.Escape));

            if (credits == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sorry, you ran out of credits. Game over!");
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.WriteLine("\nEnd of 11. feladat, press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }
        static void Twelve()
        {
            double priceOfCrypto = 30000;
            Random priceUporDown = new Random();
            double priceShift = 1.001;
            Console.Write("12. Cryptocurrency simulator. Enter the amount of hours you want to check:");
            int amountOfHOurs = int.Parse(Console.ReadLine());
            for (int i = 0; i < amountOfHOurs; i++)
            {

                Console.WriteLine($"The value of the cryptocurrency is {priceOfCrypto} at hour {i + 1}.");
                priceOfCrypto = priceOfCrypto * priceShift + priceUporDown.Next(-400, 350);
                Thread.Sleep(5);
            }
            Console.WriteLine("\nEnd of 12. feladat, press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }
        static void Main(string[] args)
        {
            Eleven();
            Console.WriteLine("END OF PROGRAM");
            Console.ReadKey();
        }
    }
}
