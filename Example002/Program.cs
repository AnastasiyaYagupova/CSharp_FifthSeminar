/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

void FillArray(int[] collection)
{
Random rand = new Random();
int Length = collection.Length;
    for (int i = 0; i < Length; i++)
    {
     collection[i] = rand.Next(-100, 101);
    }
} 

int SumOfNumbersOfOddPositions(int[] collection)
{
    int position = 0;
    int resultat = 0;
    int Length = collection.Length;
    while(position < Length)
    {
        resultat = resultat + collection[position];
        position = position + 2;
    }
    return resultat;
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
FillArray(Array);
PrintArray(Array);
int answer = SumOfNumbersOfOddPositions(Array);
Console.WriteLine($"Сумма эдементов, стоящих на нечётных позициях {answer}");
