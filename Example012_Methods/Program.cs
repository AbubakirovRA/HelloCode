// Основные группы методов в C#



// ПЕРВАЯ ГРУППА
//--------------
//Методы, которые ничего на принимают и ничего не возвращают

//ПРИМЕР:
// void Method1()
// {
//     Console.WriteLine("Автор....");
// }
// Method1();



// ВТОРАЯ ГРУППА
//-----------------
//  Методы, которые ничего не возращают, но могут принимать какие-либо аргументы

//ПРИМЕР
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2("Текст сообщения");

//Демонстрация использования того, что именованные аргкменты можно задавать в любом порядке,
//то есть при вызове метода задать аргументы явно: Method (msg: "Текст сообщения",count: 4);
// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++; // выражение, увеличивающее счетчик цикла программисты называют "ИНКРЕМЕНТ",
//                  // уменьшающее - "ДЕКРЕМЕНТ"
//     }
// }
// Method21("Текст второго метода", 4);                 //если аргументы заданы неявно, то они должны стоять на позициях
//                                                      //соответствующих позициям входных аргументов метода, при объявлении метода
// Method21(count: 4, msg: "Пример с именованными аргументами");     // если аргументы именованы, то порядок их указания, при вызове метода не важен


// ТРЕТЬЯ ГРУППА
//-----------------
//  Методы, которые ЧТО-ЛИБО возращают, но ничего не принимают

//ПРИМЕР
// int Method3()       //Если метод что-то возвращает, то при его объявлении в обязательном
//                     //порядке указывается тип данных который он возвращает
// {
//         return DateTime.Now.Year; //Если метод что-то возвращает, то обязателен оператор return
// }
// // Method2("Текст сообщения");

// Method3();
// int year = Method3();
// Console.WriteLine(year);

// ЧЕВЕРТАЯ ГРУППА
//-----------------
//  Методы, которые ЧТО-ЛИБО возращают И могут принимать какие-либо аргументы

// //ПРИМЕР
// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty; //данная запись равнозначна записи string result = "", то есть пустое значение

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

// string res = Method4(10, "z+");
// Console.WriteLine(res);


//НОВЫЙ ОПЕРАТОР ЦИКЛА FOR
//------------------------

//СИНТАКСИС :
//          for(int i=0;i<10;i++)
//              {
//                  Console.WriteLine(i);
//              }

// string Method4(int count, string text)
// {
//     string result = String.Empty;

//     for (int i = 0; i < 10; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }

// string res = Method4(10, "z+");
// Console.WriteLine(res);

//ВЛОЖЕННЫЙ ЦИКЛ ДЛЯ ВЫВОДА ТАБЛИЦЫ УМНОЖЕНИЯ
//-------------------------------------------

// void MultiplicationTable()
// {
//     for (int i = 2; i <= 10; i++)
//     {
//         for (int j = 2; j <= 10; j++)
//         {
//             Console.WriteLine($"{i} x {j} = {i * j}");
//         }
//         Console.WriteLine();
//     }
// }

// MultiplicationTable ();

// // // Дан текст. В тексте нужно все пробелы заменить черточками, 
// // // маленькие буквы “к” заменить большими “К”,
// // // a большие “С” заменить маленькими “с”.
// // // Ясна ли задача?

// string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
//             + "ежели бы вас послали вместо нашего милого Винценгероде,"
//             + "вы бы взяли приступом согласие прусского короля. "
//             + "Вы так красноречивы. Вы дадите мне чаю?";

// string ReplaceText(string text, char oldValue, char newValue) //Тип данных char — это целочисленный тип данных, 
//                                                               // который используется для представления символов. 
//                                                               // То есть, каждому символу соответствует определённое 
//                                                               // число из диапазона [0; 255]. Тип данных char также ещё 
//                                                               // называют символьным типом данных, так как графическое 
//                                                               // представление символов в С++ возможно благодаря char.
// {
//     string result = string.Empty;
//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if (text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + text[i];
//     }
//     return result;
// }

// string newText=ReplaceText(text, ' ', '|');

// Console.WriteLine(newText);
// Console.WriteLine();

// newText=ReplaceText(text, 'к', 'К');

// Console.WriteLine(newText);
// Console.WriteLine();

//ФУНКЦИИ В ПРОГРАММИРОВАНИИ

// СОРТИРОВКА ВЫБОРОМ
//1. Найти позицию минимального элемента
// в неотсортированной части массива
// 2. Произвести обмен этого значения со
// значением первой неотсортированной позиции
// 3. Повторять пока есть неотсортированные элементы

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

Console.Write("Задан массив ");
PrintArray(arr);

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

void SelectionSortMax(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition]) maxPosition = j;
        }
        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}

SelectionSort(arr);
Console.Write("Сортировка с увеличением  ");
PrintArray(arr);

SelectionSortMax(arr);
Console.Write("Сортировка с уменьшением  ");
PrintArray(arr);
