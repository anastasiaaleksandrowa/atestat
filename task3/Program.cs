// Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

using System;


class Program

{

  static void Main(string[] args)

  {
    int[] array = new int[5];
    {
      for (int i = 0; i < array.Length; i++)
      {
        array[i] = new Random().Next(1, 100);
      }

      PrintArrey(array);
      Console.WriteLine();
      PrintArrayReversed(array, array.Length - 1);

    }
    static void PrintArrey(int[] myArray, int i = 0)
    {
      if (i < myArray.Length)
      {
        Console.Write(myArray[i] + " ");
        PrintArrey(myArray, i + 1);
      }
    }


    static void PrintArrayReversed(int[] array, int index)

    {

      if (index >= 0)

      {

        Console.Write(array[index] + " ");

        PrintArrayReversed(array, index - 1);

      }

    }

  }
}