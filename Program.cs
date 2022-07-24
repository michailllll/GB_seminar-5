// задайте массив, найти сумму положительных и отрицательных элемннтов


// int[] CreateRandomArray(int size)
// {
//     int [] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//     array[i] = new Random().Next(100, 1000);
//     }
//     return array;
// }

// void ShowArray (int[] array)
// {
// for (int i = 0; i < array.Length; i++)
// {
//    Console.Write(array[i] + ",");
// }
// Console.WriteLine();
// }

// int sizeArray = new Random().Next(1, 20);

// int[] MyArray = CreateRandomArray (sizeArray);

// ShowArray(MyArray);

// int quantEven = 0;
// for(int i = 0; i < MyArray.Length; i++)
// {
//     if (MyArray[i] % 2 == 0)
//     {
//         quantEven = quantEven + 1;
//     }
    
// }

// Console.WriteLine($"Количество четных {quantEven}");


// программа задает одномерный массив, заполненный случайными числами. показывает сумму элементов, стоящих на нечётных позициях.

// int[] CreateRandomArray(int size)
// {
//     int [] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//     array[i] = new Random().Next(1, 10);
//     }
//     return array;
// }

// void ShowArray (int[] array)
// {
// for (int i = 0; i < array.Length; i++)
// {
//    Console.Write(array[i] + ",");
// }
// Console.WriteLine();
// }

// int sizeArray = new Random().Next(1, 20);

// int[] MyArray = CreateRandomArray (sizeArray);

// ShowArray(MyArray);

// int SumNotEvenPos = 0;
// for(int i = 0; i < MyArray.Length; i++)
// {
//     if (i % 2 != 0)
//     {
//         SumNotEvenPos = SumNotEvenPos + MyArray[i];
//     }
    
// }
// Console.WriteLine($"Сумма на нечетных позициях {SumNotEvenPos}");

// программа задает массив вещественных чисел. выводит разницу между максимальным и минимальным элементом массива

int[] CreateRandomArray(int size)
{
    int [] array = new int[size];
    for (int i = 0; i < size; i++)
    {
    array[i] = new Random().Next(1, 10);
    }
    return array;
}

void ShowArray (int[] array)
{
for (int i = 0; i < array.Length; i++)
{
   Console.Write(array[i] + ",");
}
Console.WriteLine();
}

int sizeArray = new Random().Next(1, 20);

int[] MyArray = CreateRandomArray (sizeArray);

ShowArray(MyArray);

int min = MyArray.Min();
int max = MyArray.Max();
int result = max - min;



Console.WriteLine($"Разница между максимальным и минимальным элементами {result}");

