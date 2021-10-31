int RightOrderSize(int[] collection) // Исключение элементов нарушения возрастания
{
    int length = collection.Length;
    int index = 1;
    int currentElement = collection[0];
    int size = 0;

    while (index < length)
    {
        if (collection[index] > currentElement)
        {
            currentElement = collection[index];
            size = size + 1;
        }
        index++;
    }

    return size;

}

void RightOrderFill(int[] collection, int[] size)
{
    int length = collection.Length;
    int index = 1;
    int indexB = 1;
    int currentElement = collection[0];
    size[0] = collection[0];

    while (index < length)
    {
        if (collection[index] > currentElement)
        {
            currentElement = collection[index];
            size[indexB] = collection[index];
            indexB++;
        }
        index++;
    }

}

void FillArray(int[] collection) // Объявляем метод FillArray, который будет заполнять массив 
{
    int length = collection.Length; //присваиваем переменной length значение, соответствующее количеству
                                    //элементов в аргументе collection
    int index = 0;                  //устанавливаем счетчик index в нуль
    while (index < length)          //запускаем заполнение объявляя цикл до значения переменной length
    {                                                           // тело цикла
        collection[index] = new Random().Next(1, 10);       //заполняем аргумент collection случайными числами
        //index = index + 1;                                //увеличиваем счетчик на 1
        index++;
    }                                                           //тело цикла
}

void PrintArray(int[] col)
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

void PrintTask(string[] text) // Объявляем метод PrintTask   
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

void WaitUser() //метод (процедура) ожидание пользователя
{
    Console.WriteLine("Нажмите ENTER, когда будете готовы продолжить");

    while (true)
    {
        if (Convert.ToString(Console.ReadLine()) == "")
        {
            break;
        }

    }
}

int SizeOfArray() //Метод ожидающий ввода числа элементов массиваи осуществляющий проверку ввода
{
    int Size = 0;
    while (true)
    {
        Console.WriteLine("Введите число элементов массива");
        if (int.TryParse((Console.ReadLine()), out int number))
        {
            Size = number;
            Console.Clear();
            break;
        }
        else
        {
            Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
        }
    }
    return Size;
}

string[] array = {"Задача", "Cформировать случайным образом целочисленный массив A",
              "из натуральных двузначных чисел.", "Создать на его основе масив B, отбрасывая те, которые:",
              "1  нарушают порядок возрастания", "2  больше среднего арифметического элементов A",
              "3  чётные"};

PrintTask(array);

WaitUser();

int[] A = new int[Convert.ToInt32(SizeOfArray())];

FillArray(A);
Console.WriteLine("Элементы массива A:");

PrintArray(A);
Console.WriteLine();

int[] B = new int[Convert.ToInt32(RightOrderSize(A)) + 1];

RightOrderFill(A, B);

Console.WriteLine("Элементы массива B:");
Console.WriteLine();

PrintArray(B);
Console.WriteLine();



