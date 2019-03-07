using System;

namespace LinearSearch
{
    public class LS
    {
        public static int Searching(int[] array, int x)
        {
            int n = array.Length;
            for(int i = 0; i < n; i++)
            {
                if(array[i] == x)
                {
                    return i;
                }
            }
            return -1;
        }

        static void Main()
        {
            
        int[] array = {5, 6, 10, 20, 35};
        int x = 35;

        int result = Searching(array, x);
        if(result == -1)
            System.Console.WriteLine("element not found");
        else
            System.Console.WriteLine("element found at " + result);


        }
    }
}

        
