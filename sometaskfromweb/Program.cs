using System;

namespace dudljump
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] RandomizeArray (int[] array) {
            for (int i = 0; i < array.Length; i++ ) {
                array[i] = new Random().Next(1,4);
            }
            return array;
           }

           void PrintArray(int[] array) {
            for (int i = 0; i < array.Length; i++ ) {
                Console.WriteLine($" {array[i]} ");
            }
           }

          int CheckForSuccesJump(int[] array) {
            int check = 0;
            for (int i = 0; i < array.Length; i++ ) {
                i += array[i];
                Console.WriteLine($"i = {i}");
                if (i>array.Length) {
                   check = 0;
                   break;
                }
                else {
                    if (i == array.Length-1) {
                        check = 1;
                        break;
                    }
                }
            }
            return check;
           }

        
         int[] arr = new int[4];
         int[] randomedArr = RandomizeArray(arr);
         PrintArray(randomedArr);
        Console.WriteLine(CheckForSuccesJump(randomedArr));

           
        }

    
    }
}
