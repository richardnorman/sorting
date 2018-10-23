using System;

namespace InsertionSort
{
    class Insertion_Sort
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            //create an array with a random size from 5-15
            var randomArray = new int[random.Next(5,15)];

            for (var i = 0; i < randomArray.Length; i++)
            {
                //fill array with random integers ranging from 1 to 99
                randomArray[i] = random.Next(1, 100);
            }

            //print unsorted array for reference
            Console.WriteLine("The unsorted array is: " + string.Join(" ", randomArray));

            //now that we have a full array, begin insertion sort
            for (var i = 1; i < randomArray.Length; i++)
            {
                int j = i;
                while (randomArray[j] < randomArray[j-1])
                {
                    //store temporary value and swap if element on left is larger than selected element
                    int temp = randomArray[j-1];
                    randomArray[j - 1] = randomArray[j];
                    randomArray[j] = temp;
                    j -= 1;
                    //prevents out of bounds exception, occurs when smallest number in array is sorted
                    if (j == 0)
                    {
                        break;
                    }
                }
            }

            //print sorted array
            Console.WriteLine("The sorted array is: " + string.Join(" ", randomArray));
        }
    }
}
