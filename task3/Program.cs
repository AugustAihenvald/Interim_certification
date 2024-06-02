
// Функция создания массива и его заполнение случайными числами!
/*int[] CreateArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max);
    }
    return array;
} */

void PrintReversArray(int[] array, int index)
{

    if (index >= 0)
    {
        Console.Write($"{array[index]} ");
        PrintReversArray(array, index - 1);
    }
}
//Вызов функции и вывод элеменов массива
//int[] array2=CreateArray(10, 1, 100) 
//PrintReversArray(array2, array2.Length - 1);

int[] array2 = { 1, 5, 8, 6, 3, 12, 2, 14, 9, 10 };
PrintReversArray(array2, array2.Length - 1);
