// Вид 1
// void Method1()
// {
//     Console.WriteLine("Автор Троян Юлия");
// }
// Method1();

// Вид 2
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// // Method2(msg: "Текст сообщения");

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// Method21(msg: "Текст", count: 4);
// Method21(count: 4, msg: "новый текст");

// Вид 3

// int Method3()
// {
//     return DateTime.Now.Year;
// }

// int year = Method3();
// Console.WriteLine(year);

// Вид 4
// string Method4(int count, string c)
// {
//     int i=0;
//     string result = String.Empty;
//     while (i< count)
//     {
//         result = result + c;
//         i++;
//     }
//     return result;
// }
// string res = Method4(10, "Я всё могу!");
// Console.WriteLine(res);

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

// string res = Method4(10, "z");
// Console.WriteLine(res);

// string Method4(int count, string text)
// {
//     string result = String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }
// string res = Method4(10, "z");
// Console.WriteLine(res);

// Создаем цикл for внутри которого находится другой цикл for
// Напишем программу, которая выводит таблицу умнажения

// Задача. Работа с текстом.
// Дан текст. В тексте нужно все пробелы записать черточками,
// маленькие буквы "к" заменить большими "К", а большие "С" 
// заменить маленькими "с".

// Ясна ли задача?

// string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
//            + "ежели бы вас поставили вместо нашего милого Винценгероде,"
//            + "вы бы взяли приступом согласие прусского короля."
//            + "Вы так красноречивы. Вы дадите мне чаю?";
//string s = "qwerty"
//          012345
//s [3] //r
// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;
//     int Length = text.Length;
//     for (int i = 0; i < Length; i++)
//     {
//         if (text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }

//     return result;
// }
// string newText = Replace(text, ' ', '|');
// System.Console.WriteLine(newText);

// System.Console.WriteLine();
// newText = Replace(newText, 'к', 'К');
// System.Console.WriteLine(newText);


// 1. Найти позицию минимального элемента 
// в не отсортированной части массива.
// 2. Произвести обмен этого значения со значением первой неотсортированной позиции.
// 3. Повторять пока есть не отсортированный элементы.

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);