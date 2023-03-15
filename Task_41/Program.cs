// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Вводим массив чисел через запятую

int[] GetArrayIntFromUs(int countElementsInArray)
{
    Console.WriteLine("Введите числа, которые хотите добавить в массив через Enter:");
    int[] arrayInt = new int[countElementsInArray];
    for(int i = 0; i < countElementsInArray; i++)
    {
        arrayInt[i] = int.Parse(Console.ReadLine());
    }

    return arrayInt;
}

// -----------------------------------------------------------------------------------

// Напечатать массив
void PrintIntArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i == array.Length - 1)
        {
            Console.WriteLine($"{array[i]}]");
            break;
        }
        Console.Write($"{array[i]}, ");
    }
}

// -----------------------------------------------------------------------------------

// Считаем количество чисел, которые больше нуля, в массиве
int CountMoreZeroInArrayInt(int[] arrayInt)
{
    int count = 0;
    for(int i = 0; i < arrayInt.Length; i++)
    {
        if(arrayInt[i] > 0)
        {
            count++;
        }
    }

    return count;
}

// -----------------------------------------------------------------------------------

Console.Write("Введите какое количество чисел вы хотите добавить в массив: ");
int countElementsInArray = int.Parse(Console.ReadLine());

int[] arrayInt = GetArrayIntFromUs(countElementsInArray);
PrintIntArray(arrayInt);
Console.WriteLine($"Количество чисел в введенном массиве больше 0 = {CountMoreZeroInArrayInt(arrayInt)}");



