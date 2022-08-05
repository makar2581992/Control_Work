string[] array1 = new string[8] { "name", "fio", "prof", "world", "QA", "234", "QAT", "programm" };   // задаем 2 массива одинаковой длины
string[] array2 = new string[array1.Length];

void SecondArray(string[] array1, string[] array2) // функция проверки первого массива заданному условию, в данном случае - проверка длины строк
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}

void PrintArray(string[] array) // функция вывода массива на печать
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

Console.WriteLine();
SecondArray(array1, array2);
PrintArray(array2);
Console.WriteLine();
