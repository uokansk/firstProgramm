int Max(int arg1, int arg2, int arg3) // функция
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

// массив

int[] array = { 1, 2, 3, 4, 511, 6, 7, 8, 9 };
array[0] = 55;

int maxAll = Max(Max(array[0], array[1], array[2]), 
                 Max(array[3], array[4], array[5]), 
                 Max(array[6], array[7], array[8]));

Console.WriteLine(maxAll);
// Console.WriteLine(array[4]);