int Max(int arg1, int arg2, int arg3) // это входные аргументы функции Max
{
    int result = arg1;                //  -  это
    if (arg2 > result) result = arg2; //  -  тело
    if (arg3 > result) result = arg3; //  -  функции
    return result;                   // это возвращаемый результат
}

//               0     1   2   3  4   5   6    7   8
int[] array = { 1111, 211, 31, 41, 15, 61, 17, 18, 19 }; // объявляем массив

//array[0] = 12;
//Console.WriteLine(array[8]);

//вызываем метод(функцию) Max, внутри передаваемых аргументов, вместо чисел передаем также вызов 
//функции Max, но уже с числовыми значениями аргументов
int result = Max(                       //       arg1       arg2     arg3
    Max(array[0], array[1], array[2]),  // Max(array[0], array[1], array[2]) - это arg1
    Max(array[3], array[4], array[5]),  // Max(array[3], array[4], array[5]) - это arg2
    Max(array[6], array[7], array[8])   // Max(array[6], array[7], array[8]) - это arg3
);

Console.WriteLine(result);

