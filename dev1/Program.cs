//Начало программы не здесь, а где-то там внизу, где начинаются вызовы методов
//здесь же я объявил методы (функции и процедуры), необходимые для выполнения алгоритмов

int RightOrdersize(int[] collection)  // Объявил метод (функцию), возвращающую значение sizeB, то есть
{                                     //выясняющую сколько элементов нужно зарезервировать под массив В,
                                      //в качестве аргумента в функцию загружаю элементы массива А.
    int length = collection.Length;      //переменная length хранит количество элементов входящего аргумента
    int currentElement = collection[0];  //в currentElement сохраняю значение первого элемента аргумента
    int index = 1;                       //так как первый(нулевой элемент) будем сравнивать со следующим элементом, счетчик цикла должен быть больше номера индекса на единицу
    int sizeB = 0;                       //размер массива В - искомая величина, до начала работы обнуляею значение

    while (index < length)
    {
        if (collection[index] > currentElement)
        {
            currentElement = collection[index]; // сравниваю элементы массива в цикле
            sizeB = sizeB + 1;                  // при каждом нахождении правильного элемента, счетчик числа элементов массива В увеличиваю на 1
        }
        index++;
    }

    return sizeB;  //ура-ура! вот оно, искомое значение, ради чего весь сыр-бор
}

void RightOrderFill(int[] collection, int[] sizeB) //Данный метод является процедурой, т.к. не возвращает значений,
{                                                  //а просто выполняет действия. Алгоритм идентичен методу RightOrdersize,
    int length = collection.Length;                //отличие только в одном действии - заполнении массива B выбранными значениями
    int index = 1;      //счечик, равный количеству элементов в массиве А
    int indexB = 1;     //счетчик, равный количеству элементов в массиве В
    int currentElement = collection[0];
    sizeB[0] = collection[0];

    while (index < length)
    {
        if (collection[index] > currentElement) //отбор нужных значений
        {
            currentElement = collection[index]; //отбор нужных значений
            sizeB[indexB] = collection[index];  //заполнение массива В
            indexB++;
        }
        index++;
    }

}

void PrintOverAverage(int[] collectionA, int[] collectionB)    // данный метод определяет среднее арифметическое массива А
{                                                   //и выводит на экран элементы массива В, превышающие это значение
    int lengthA = collectionA.Length;
    int index = 0;
    int sum = 0;

    while (index < lengthA)
    {
        {
            sum = sum + collectionA[index];
        }
        index++;
    }
    Console.WriteLine($"Среднее арифметическое элементов массива А = {sum / lengthA}");

    int lengthB = collectionB.Length;
    index = 0;
    Console.Write("Элементы массива B, превышающие среднее арифметическое массива A: ");
    while (index < lengthB)
    {
        if (collectionB[index] > (sum / lengthA))
        {
            Console.Write($" {collectionB[index]}");
        }
        index++;
    }
    Console.WriteLine();
}

void Even(int[] collectionB)    //данный метод определяет и выводит на экран четные элементы массива В
{
    int lengthB = collectionB.Length;
    int index = 0;
    Console.Write("Четные элементы массива B: ");
    while (index < lengthB)
    {
        if (collectionB[index] % 2 == 0)
        {
            Console.Write($" {collectionB[index]}");
        }
        index++;
    }
    Console.WriteLine();
}


void FillArray(int[] collection) // Объявляем метод FillArray, который будет заполнять массивы 
{
    int length = collection.Length; //присваиваем переменной length значение, соответствующее количеству
                                    //элементов в аргументе collection
    int index = 0;                  //устанавливаем счетчик index в нуль
    while (index < length)          //запускаем заполнение объявляя цикл до значения переменной length
    {                                                           // тело цикла
        collection[index] = new Random().Next(10, 100);     //заполняем аргумент collection случайными числами                          
        index++;                                            //увеличиваем счетчик на 1
    }                                                           //тело цикла
}

void PrintArray(int[] col)      // этот метод отвечает за вывод на экран содержимого массивов
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
    Console.WriteLine();
}

void PrintTask(string[] text) // Объявляем метод PrintTask (выводит условие задачи)
{
    int length = text.Length; //присваиваем переменной length значение, соответствующее количеству
                              //элементов в аргументе text
    int index = 0;                  //устанавливаем счетчик index в нуль
    Console.Clear();
    while (index < length)          //запускаем заполнение объявляя цикл до значения переменной length
    {                                                           // тело цикла
        Console.WriteLine(text[index]);       //заполняем аргумент text случайными числами
        //index = index + 1;                                //увеличиваем счетчик на 1
        index++;
    }                                                           //тело цикла
}

void WaitUser() //метод (процедура) ожидание пользователя, для того, чтобы дать прочитать условие
{
    Console.WriteLine("Нажмите ENTER, когда будете готовы продолжить");

    while (true)
    {                                                       //цикл повторяется до тех пор, пока
        if (Convert.ToString(Console.ReadLine()) == "")     //не нажата клавиша Enter
        {
            break;                                          //по выполнению условия прерываю цикл
        }

    }
}

int SizeOfArray() //Метод ожидающий ввода числа элементов массива и осуществляющий проверку ввода
{
    int size = 0; //переменная size хранит размер массива А, который задает пользователь
    while (true)
    {
        Console.WriteLine("Введите число элементов массива (целочисленное значение)");
        if (int.TryParse((Console.ReadLine()), out int number)) //извлекаем из строки ввода символы и пытаемся присвоить им вещественный тип числа
        {
            size = number;  //если получилось, запоминаем число
            Console.Clear();
            break;          //очищаем экран и выходим из цикла
        }
        else
        {
            Console.WriteLine("Не удалось распознать число, попробуйте еще раз."); //если не получилось, запрашиваем по новой
        }
    }
    return size;        // возвращаем значение метода (функции) в программу
}

string[] array = {                  //поигрался с текстовым значением элементов в массиве
                    "Задача",
                    "Cформировать случайным образом целочисленный массив A",
                    "из натуральных двузначных чисел.",
                    "Создать на его основе: ",
                    "1)  массив B, отбрасывая те, которые нарушают порядок возрастания",
                    "2)  элементы массива В, которые больше среднего арифметического элементов массива A",
                    "3)  чётные элементы массива В."
                };

// Т Е Л О       П Р О Г Р А М М Ы
//---------------------------------

PrintTask(array);  // программа состоит из последовательного вызова методов

WaitUser();

int[] A = new int[Convert.ToInt32(SizeOfArray())]; //создаю массив А, на основе заданного пользователем числа элементов
                                                   // заполняю его нулями
FillArray(A);
Console.WriteLine("Элементы массива A:");

PrintArray(A);
Console.WriteLine();

int[] B = new int[Convert.ToInt32(RightOrdersize(A)) + 1];

RightOrderFill(A, B);

Console.WriteLine("Сформируем массив B (включаем в него элементы массива А, не нарушающие порядок возрастания):");

PrintArray(B);
Console.WriteLine();

PrintOverAverage(A, B);
Console.WriteLine();

Even(B);
Console.WriteLine();





//LITTER
//int[] D = new int[Convert.ToInt32(AverageNumber(A))];
// Console.WriteLine();
// Console.WriteLine("Элементы массива В, превышающие среднее арифметическое:");
// PrintArray(D);
// int AverageNumber(int[] collection)
// {
//     int length = collection.Length;
//     int index = 0;
//     int sum = 0;

//     while (index < length)
//     {
//         {
//             sum = sum + collection[index];
//         }
//         index++;
//     }

//     index = 0;
//     int sizeD = 0;

//     while (index < length)
//     {
//         if (collection[index] > (sum / length))
//         {
//             sizeD = sizeD + 1;
//         }
//         index++;
//     }
//     Console.WriteLine($"Среднее арифметическое элементов массива А = {sum / length}");
//     Console.WriteLine($"Число элементов в массиве А, превышающих среднее арифметическо равно {sizeD}");
//     return sizeD;
// }
