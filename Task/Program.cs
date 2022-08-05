
// Написать программу, которая из имеющегося массива строк формирует массив строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
//  либо задать на старте выполнения алгоритма. При решении не рекомедуется пользоваться коллекциями,
//   лучше обойтись исключительно массивами.


string[] array = new string[] { "hello", "123", ":-)", "-2", "world" };
string[] resArray = new string[array.Length];

void ResultArray(string[] arr1, string[] arr2)
{

    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i].Length <= 3)
        {
            arr2[i] = arr1[i];
        }
    }
}

void PrintArray(string[] arr3)
{
    for (int i = 0; i < arr3.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < arr3.Length - 1) Console.Write(arr3[i]);
        else Console.Write(arr3[i] + " ] ");


    }
}

ResultArray(array, resArray);
PrintArray(resArray);
