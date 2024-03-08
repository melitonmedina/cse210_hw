using System;

class Program
{
    static void Main(string[] args)
    {
        //string magicRandom;
        string guess;
        //int magicNumber;
        int answerNumber;
        Random randomGenerator = new Random();
        int number = 0;
        int count = 0;
     
        
        
    

        do
        {
            if (number == 0)
            {
                number = randomGenerator.Next(1, 100);
                Console.WriteLine($"What is the magic number? {number}");
            }
            
            //magicRandom = Console.ReadLine();
            //magicNumber = int.Parse(magicRandom);

            Console.Write("What is your guess? ");
            guess = Console.ReadLine();
            answerNumber = int.Parse(guess);

            // the if statement
            if (number > answerNumber)
            {
                Console.WriteLine("Higher");
                count++;
            

            }
            else if ( number < answerNumber)
            {
                Console.WriteLine("Lower");
                count++;
                

            }
            else
            {
                count++;
                Console.Write($"You guessed it in {count} tries!\nDo you want to play again? ");
                string continuePlay = Console.ReadLine();
                
                
                if (continuePlay == "yes")
                {
                    number = 0;
                    count = 0;
                } 
                else
                {
                    number = answerNumber;
                    
                }
            }


        } while (number != answerNumber);
        



    }
}