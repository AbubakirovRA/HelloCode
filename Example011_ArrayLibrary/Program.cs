﻿void FillArray(int[] collection) // Объявляем метод FillArray, который будет заполнять массив 
// array (см. НАЧАЛО программы) случайными числами, int-указывает, что числа будут целочисленными. 
//В качестве аргумента массива, то есть коллекции каких-то его элементов,
// мы указываем имя этого аргумента, допустим это будет имя collection. После передачи методу в качестве
//аргумента массива array, collection будет соответствовать списку элементов массива array. Сразу
//после запуска это будет 10 нулей.

    // В языке C# методы делятся на методы, которые возвращают значения (в других языках это функции)
    // и методы, которые после работы ничего не возвращают (в других языках - процедуры)
    // чтобы объявить метод, который ничего не возвращает, используется оператор void.
    // Для объявления метода-функции ничего специально не предпринимается, в конце метода для возврата значения
    // используется оператор return
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
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; //НАЧАЛО ЗДЕСЬ!!!
// Объвляем массив array, элементы массива явно не прописываем, при помощи оператора
//NEW - создать, указываем только его размер. В данном примере - 10. После создания
//этот массив заполнится нулями автоматически. Для заполнения массива мы создали метод
//FillArray (в начале кода)

FillArray(array); //вызываем метод array, в качества аргумента передаем ему массив заполненый нулями array
                  //после того как метод отработает, мы получим заполненый случайными числами массив
array[4] = 4;     //принудительно меняем значение 4-го элемента массива на 4
array[6] = 4;     //принудительно меняем значение 6-го элемента массива на 4

PrintArray(array);//вызываем метод PrintArray, чтобы вывести на экран элементы массива
Console.WriteLine(); //отделяем следующую информацию пустой строкой

int pos = IndexOf(array, 444); //вызываем метод IndexOf, чтобы найти в массиве позицию конкретного элемента
Console.WriteLine(pos);        //выводим на экран результат метода IndexOf
