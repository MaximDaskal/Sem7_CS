
//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
float [,] Create2DArrayFloatNums(int raw, int column,  float minVal, float maxVal)
{
    float [,] Result = new float[raw, column];
    float space = maxVal - minVal; // определили диапазон из которого должны быть получены значения элементов массива
   
    for(int i = 0; i<Result.GetLength(0); i++)
    {
        for(int j =0; j<Result.GetLength(1); j++)
        {
            float ranNum = Convert.ToSingle(Math.Round((new Random().NextSingle()), 3)); // Получили значение из диапазона [0.000; 1.000]
            Result[i,j] = Convert.ToSingle(Math.Round((ranNum*space + minVal), 3));//  Получили вещественное  число из диапазона [minVal; maxVal]
        }
        
    }
    return Result;
}


void Show2DArray(float [,] array)
{
    Console.WriteLine("Your array is: ");
    for(int i =0; i< array.GetLength(0); i++)
    {
        for(int j =0; j<array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]:f3} ");
        }
        Console.WriteLine("");        
    }
    Console.WriteLine("");
}

float elemFloat(float [,] array, int raw, int col)
{
    return array[raw, col];
}



Console.Write("Input raw size of your array: ");
int RawSize = Convert.ToInt32(Console.ReadLine());

Console.Write("Input column size of your array: ");
int ColSize = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min value of your array: ");
float minV = Convert.ToSingle(Console.ReadLine());

Console.Write("Input max value of your array: ");
float maxV = Convert.ToSingle(Console.ReadLine());

float [,] tDArr = Create2DArrayFloatNums(RawSize, ColSize, minV, maxV);

Show2DArray(tDArr);

// тут реализация задачи 50.
Console.Write("Input raw number of your array: ");
int RawNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Input column number of your array: ");
int ColNum = Convert.ToInt32(Console.ReadLine());
if(RawNum>tDArr.GetLength(0)-1 || ColNum>tDArr.GetLength(1)-1)// Если нету такого элемента в массиве
Console.WriteLine("There is not such an element in array");
else 
Console.WriteLine($"your element is: {elemFloat(tDArr, RawNum, ColNum)}");




/*
//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


int [,] Create2DArrayIntNums(int raw, int column,  int minVal, int maxVal)
{
    int [,] Result = new int[raw, column];
       
    for(int i = 0; i<Result.GetLength(0); i++)
    {
        for(int j =0; j<Result.GetLength(1); j++)
        {
            Result[i,j] = new Random().Next(minVal, maxVal+1);
        }
    }
    return Result;
}

float [] Average(int [,] intArray)
{
    float k =0;
    float [] Result = new float[intArray.GetLength(1)];
    for(int i =0; i<intArray.GetLength(1); i++)
    {
        for(int j=0; j<intArray.GetLength(0); j++)
        {
            k = k + intArray[j,i];
        }
        Result[i] = Convert.ToSingle(Math.Round((k/intArray.GetLength(0)) , 2));
        k = 0;
    }
    return Result;
}

void Show2DIntArray(int [,] array)
{
    Console.WriteLine("Your array is: ");
    for(int i =0; i< array.GetLength(0); i++)
    {
        for(int j =0; j<array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine("");        
    }
    Console.WriteLine("");
}



void ShowArray(float [] arrayF)
{
    Console.Write("Среднее арифметическое элементов каждого столбца: ");
    for(int i =0; i< arrayF.Length; i++)
    {
        Console.Write($"{(arrayF[i])} ");
    }
    Console.WriteLine("");
    
}


Console.Write("Input raw size of your array: ");
int RawSize = Convert.ToInt32(Console.ReadLine());

Console.Write("Input column size of your array: ");
int ColSize = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min value of your array: ");
int minV = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max value of your array: ");
int maxV = Convert.ToInt32(Console.ReadLine());

int [,] Res = Create2DArrayIntNums(RawSize, ColSize, minV, maxV);
Show2DIntArray(Res);
ShowArray(Average(Res));

*/


