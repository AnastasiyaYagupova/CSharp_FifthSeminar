/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементом массива.
[3.3 7.76 22 2 78.67] -> 76.67
*/

void FillArray(double[] collection)
{
Random rand = new Random();
int Length = collection.Length;
    for (int i = 0; i < Length; i++)
    {
     collection[i] = rand.Next(10000)/100.0;
    }
} 

void PrintArray(double[] collection)
{
    int Length = collection.Length;
    int index = 0;  
     while(index < Length)
    {
        Console.WriteLine(collection[index]);
        index++;
    }
}

double FindMinMaxDifference(double[] collection)
{
    int index = 0;
    double max = collection[index];
    double min = collection[index];
    int Length = collection.Length;
    while(index < Length)
    {
        if(min > collection[index])
        {
            min = collection[index];
            index++;
        }
        else if(max < collection[index])
        {
            max = collection[index];
            index++;
        }
        else
        {
            index++;
        }
        
    }
    double diffirence = max - min;
    return diffirence;
}

double[] Array = new double[5];
FillArray(Array);
PrintArray(Array);
double resultat = FindMinMaxDifference(Array);
Console.WriteLine($"Разность {resultat}");
