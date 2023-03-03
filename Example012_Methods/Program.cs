// // Method 1
// void Method()
// {
//     Console.WriteLine("Andrey");
// }

// // Vizov

// Method();

// // Method 2 Ничего не возвращает, но принимает аргументы

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

// // Method21(msg: "Текст сообщения", count: 4);

// // Method 3 Что-то возвращает, но ничего не принимает

// int Method3()
// {
//     return DateTime.Now.Year;
// }

// int year = Method3();
// // Console.WriteLine(year);

// // Method4 Что-то принимает и что-то возвращает

// string Method4(int count, string c)
// {
//     int i = 0;
//     string result = string.Empty;

//     while (i < count)
//     {
//         result = result + c;
//         i++;
//     }
//     return result;
// }

// string res = Method4(10, "Абра-Кадабра ");
// // Console.WriteLine(res);

// // Method4 через цикл for

// string Method41(int count, string c)
// {
//     string result = string.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result = result + c;
//     }
//     return result;
// }

// string res41 = Method41(10, "Абра-Кадабра ");
// // Console.WriteLine(res41);

// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         // Console.WriteLine($"{i} x {j} = {i * j}");
//     }

//     // Console.WriteLine();
// }

// // ------Работа с текстом------
// // Дан текст. В тексте нужно все пробелы заменить черточками,
// // маленькие буквы "к" заменить большими "К",
// // а большие "С" заменить маленькими "с".

// string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
//             + "ежели бы вас послали вместо нашего милого Винценгероде,"
//             + "вы бы взяли приступом согласие прусского короля. "
//             + "Вы так красноречивы. Вы дадите мне чаю? Спасибо!" ;

// // string s = "qwerty"
// //             012345
// // s[3] // r

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = string.Empty;

//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if (text[i] == oldValue) result =result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }


//     return result;
// }

// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine("-------------------------------------");

// newText = Replace(newText,'к','К');
// Console.WriteLine(newText);
// Console.WriteLine("-------------------------------------");

// newText = Replace(newText,'С','с');
// Console.WriteLine(newText);

// -----------------------------------------------------------
// Работа с массивами. Сортировка массива выбором минимального
// -----------------------------------------------------------

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[minPosition]) minPosition = j; // Изменение знака <> меняет порядок сортировки
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);            // Вывод несортированного массива
SelectionSort(arr);         // Сортировка массива

PrintArray(arr);            // Вывод сортированного массива