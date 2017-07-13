using System;
using System.Collections.Generic;

namespace random
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            // Create a list
            List<int> numbers = new List<int>();

            // Populate the list
            for(int i = 0; i < 20; i++){
                numbers.Add(random.Next(1,50));
            }

            List<int> squares = new List<int>();

            foreach(int num in numbers){
                squares.Add(num*num);
            }

            squares.RemoveAll(num => num % 2 != 0);
        }
    }
}
