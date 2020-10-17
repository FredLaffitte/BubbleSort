using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====================================================");
            Console.WriteLine("===============utilizando Bubble Sort================");
            Console.WriteLine("=====================================================");
            Console.WriteLine("=====Ordenando a sequência: 69, 55, 45, 98, 13=======");
            int[] arr = { 69, 55, 45, 98, 13 };
            int temp;
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            Console.Write("Ordenação -> ");
            foreach (int p in arr)
                Console.Write(p + " ");
            Console.Read();
        }
    }
}
