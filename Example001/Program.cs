/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int FillArrayParityCheck(int[] collection)
{
Random rand = new Random();
int count = 0;
int Length = collection.Length;
    for (int i = 0; i < Length; i++)
    {
     collection[i] = rand.Next(100, 1000);
     if(collection[i] % 2 == 0)
     {
        count++;
     }
     else
     {
        continue;
     }
    }
    return count;
}

void PrintArray(int[] collection)
{
    int Length = collection.Length;
    int index = 0;  
     while(index < Length)
    {
        Console.WriteLine(collection[index]);
        index++;
    }
}

int[] Array = new int[5];
int times = FillArrayParityCheck(Array);
PrintArray(Array);
Console.WriteLine($"Чётных чисел в массиве {times}");
