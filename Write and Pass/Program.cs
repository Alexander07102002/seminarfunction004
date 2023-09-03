/*Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

using System.Collections.ObjectModel;

void FillArray (int [] collection) {
    int length = collection.Length;
    int index =0;
    Console.WriteLine();
    while (index<length) {
        collection[index]=int.Parse(Console.ReadLine());
        index++;
    }
}

void PrintArray (int[] col) {
    int len = col.Length;
    int count = 0;
    Console.WriteLine();
    while (count<len) {
        Console.WriteLine(col[count]);
        count++;
    }
}

int[] array = new int [8];
FillArray(array);
PrintArray(array);
Console.WriteLine();