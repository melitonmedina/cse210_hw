using System;

class Program
{
    static void Main(string[] args)
    {
        //needed variables
        List<int> numList = new List<int>() ;
        int exit = 1;
        int newNumber;
        double sum = 0;
        int bigNum = 0;
        int smallPositive = 0;


        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (exit == 1)
        {
            Console.Write("Enter a number: ");
            string answer = Console.ReadLine();
            newNumber = int.Parse(answer);
            if (newNumber !=0)
            {
                numList.Add(newNumber);
                sum = sum + newNumber;

            }

          

            if (newNumber == 0)
            {
                Console.WriteLine($"The sum is : {sum}");
                double average = (sum/numList.Count) ;
                //Console.WriteLine(numList.Count);
                Console.WriteLine($"The average is : {average}");

                //Finding the largest number
                for (int i = 0; i < numList.Count; i++)
                {
                    if (numList[i] > 0 )
                    {

                        if (bigNum < numList[i])
                         {
                            bigNum = numList[i];
                         }
                        
                    }

                }

                // finding the smalles positive number
                for (int j = 0; j < (numList.Count - 1) ; j++)
                {
                    if (numList[j] > 0 )
                    {
                        if (numList[j] > numList[j +1])
                        {
                            smallPositive = numList[j+1];

                        }
                        else
                        {
                            smallPositive = numList[j];
                        }
                           
                    }
                    
                }

                


                Console.WriteLine($"The largest number is: {bigNum}");
                Console.WriteLine($"The smallest positive number is : {smallPositive} ");

                //Sorting the list
                numList.Sort();
                Console.WriteLine("The sorted list is: ");
                foreach (int num in numList)
                {
                    Console.WriteLine(num);
                }              
                exit = 2;
            }
            


        }

        }

    }