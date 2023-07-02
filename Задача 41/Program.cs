// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// ===================НАЧАЛО===================
void PrintArray(int[] arrayForPrint)
{
    System.Console.WriteLine("[" + string.Join(", ", arrayForPrint) + "]");
}

int[] ReadArray(string text)
{
    System.Console.WriteLine(text);
    int[] massive = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
    return massive;
}

int Number0(int[] arr)
{
    int sum=0;
    for(int i=0;i<arr.Length;i++)
    {
        if(arr[i]>0)
        sum=sum+1;
    }
    return sum;
}

void Main()
{
    int[] array=ReadArray("Введите числа через пробел: ");
    PrintArray(array);
    System.Console.WriteLine($"Чисел больше нуля в массиве: {Number0(array)}");
}
// -----------------------------------------------------------------------------

Main();
// ===================КОНЕЦ===================