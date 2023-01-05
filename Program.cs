 /*
// Задача 10.  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Write("Input a number");
int num = Convert.ToInt32(Console.ReadLine());
int ed(int num)
{
    int sot = num / 10;
    int result = sot % 10;
    return result;
}
int result = ed(num);
Console.WriteLine(result);
*/

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
Console.Write("Input a number of day a week");
int num = Convert.ToInt32(Console.ReadLine());
bool wek(int num)
{
    if (num == 6 || num == 7) return true;
    else return false;
}
bool result = wek(num);
Console.WriteLine(result);
*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*

Console.Write("Input a number");
int num = Convert.ToInt32(Console.ReadLine());
string text = Convert.ToString(num);
if (text.Length > 2)
{
  Console.WriteLine("третья цифра" + text[2]);
}
else 
{
  Console.WriteLine("третьей цифры нет");
}

*/

// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
Console.WriteLine("Input a five size number");
int num = Convert.ToInt32(Console.ReadLine());

void number(int num)
  {
    int a = num % 10;
    int b = (num / 10) % 10;
    int c = (num / 1000) % 10;
    int e = num / 10000;
     if (a + b == c + e)
     {
      Console.WriteLine("Полиндром");
     }
     else
     {
      Console.WriteLine("не полиндром");
     }


  }
number(num);
*/

// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/*
Console.WriteLine("введите число координаты x,y,z");
double x = Convert.ToDouble(Console.ReadLine());
double x1 = Convert.ToDouble(Console.ReadLine());
double y = Convert.ToDouble(Console.ReadLine());
double y1 = Convert.ToDouble(Console.ReadLine());
double z = Convert.ToDouble(Console.ReadLine());
double z1 = Convert.ToDouble(Console.ReadLine());
double Distance(double x, double x1, double y, double y1, double z, double z1)
{
    if (x > x1)
    {
    x = x - x1;
    }
else
{
    x = x1 - x;
}
if (y > y1)
    {
    y = y - y1;
    }
else
{
    y = y1 - y;
}
if (z > z1)
    {
    z = z - z1;
    }
else
{
    z = z1 - z;
}
double gip = Math.Sqrt(Math.Pow(z,2) * Math.Pow(x,2));
double Distance = Math.Sqrt(Math.Pow(gip,2) * Math.Pow(y,2));
Console.WriteLine(Distance + " расстояние от точки А до Б");
return Distance;
}
Distance(x, x1, y, y1, z, z1);

*/

// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
Console.WriteLine("Input a number N");
int n = Convert.ToInt32(Console.ReadLine());

 void Qub(int n)
{
  double x = 1;

  while(x <= n)
  {
    double y = Math.Pow(x,3);
    Console.WriteLine(y);
    x=x+1;
  }


}
Qub(n);
*/

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
double stpn(double num, double num1)
{
  double count = 1;
  if (num1 > 0 && num > 0)
  {
    count = Math.Pow(num,num1);
  }
  return count; 
}

Console.WriteLine("Input a number A");
double num = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input a number B");
double num1 = Convert.ToDouble(Console.ReadLine());

double result = stpn(num, num1);
Console.WriteLine(result);
*/

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int sum(int num)
{
  int summ = 0;
  while (num > 0)
  {
    summ = summ + num % 10;
    num /= 10;
  }
  return summ;
}

Console.WriteLine("Input a number");
int num = Convert.ToInt32(Console.ReadLine());

int result = sum(num);
Console.WriteLine(result);
*/

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
/*
int [] CreateRandomArray(int size, int min, int max)
{
  int [] array = new int[8];
  for(int i=0; i<8; i++) 
  {
    array[i] = new Random().Next(min, max +1);
  }
  return array; 
}

void ShowArray(int[] array)
{ 
  for(int i=0; i<array.Length; i++) 
  {
    Console.Write(array[i] + " ");
  }
}

Console.WriteLine("Input a min");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a max");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(8,min,max);
ShowArray(newArray);
*/

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] CreateRandomArray(int size, int min, int max)
{
  int [] array = new int[size];
  for(int i=0; i<size; i++) 
  {
    array[i] = new Random().Next(100, 1000 +1);
  }
  return array; 
}
void ShowArray(int[] array)
{ 
  for(int i=0; i<array.Length; i++) 
  {
    Console.Write(array[i] + " ");
  }
}
Console.WriteLine("Input a size");
int size = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(size,100,1000);
ShowArray(newArray);

int Sum(int[] array)
{
  int count = 0;
  for(int i=0; i<array.Length; i++) 
  {
    if (array[i] % 2 == 0 )
    count++;
  }
  return count;
  
}
int result = Sum(newArray);
Console.WriteLine(result);
*/

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int[] CreateRandomArray(int size, int min, int max)
{
  int [] array = new int[size];
  for(int i=0; i<size; i++) 
  {
    array[i] = new Random().Next(min, max +1);
  }
  return array; 
}
void ShowArray(int[] array)
{ 
  for(int i=0; i<array.Length; i++) 
  {
    Console.Write(array[i] + " ");
  }
}
Console.WriteLine("Input a size");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a min");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a max");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(size,min,max);
ShowArray(newArray);

int Sum(int[] array)
{
  int sum = 0;
  int count = 0;
  for(int i=0; i<array.Length; i++) 
  {
    if (array[i] % 2 == 1)
    sum=sum+array[i];
    count++;
  }
  return sum;
  
}
int result = Sum(newArray);
Console.WriteLine(result);
 */
 
//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
/*
double[] CreateRandomArray(int size, int min, int max)
{
  double[] array = new double[size];
  for(int i=0; i<size; i++) 
  {
    array[i] = (new Random().NextDouble()+min)*(max/min);
  }
  return array; 
}
void ShowArray(double[] array)
{ 
  for(int i=0; i<array.Length; i++) 
  {
    Console.Write(array[i] + " ");
  }
}
Console.WriteLine("Input a size");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a min");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a max");
int max = Convert.ToInt32(Console.ReadLine());

double FindMax(double[] array) 
{ 
    double maxi = array[0]; 
    for (int i = 0; i < array.Length; i++) 
    { 
        if (array[i] > maxi) maxi = array[i]; 
    } 
    return maxi; 
} 

double FindMin(double[] array) 
{ 
    double minn = array[0]; 
    for (int i = 0; i < array.Length; i++) 
    { 
        if (array[i] < minn) minn = array[i]; 
    } 
    return minn; 
} 

double[] newArray = CreateRandomArray(size,min,max);
ShowArray(newArray);
double result1 = FindMax(newArray);
double result2 = FindMin(newArray);

Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна {FindMax(newArray) - FindMin(newArray)}");
*/
 
 //Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
Console.Write("Input a numbers");
int num = Convert.ToInt32(Console.ReadLine());
int name(int num)
{
    int count = 0;
    if (num>count) count++;
    return count;
}
int result = name(num);
Console.WriteLine(result); 
 */

//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
 Console.WriteLine("Input a size");
int size = Convert.ToInt32(Console.ReadLine());
int i = 0;
int count = 0;
int[] A = new int [size];
for (i = 0; i < size; i++)
{     
  Console.WriteLine("Input every numbers other");
A[i] = Convert.ToInt32(Console.ReadLine());
}
  for (i = 0; i < size; i = i + 1)
  {
  if (A[i] > 0)
{
count = count + 1;
Console.WriteLine("число " + A[i] + " больше 0, тогда количество чисел больше  0 = " + count);
}
else
{
Console.WriteLine("число " + A[i] + " меньше 0, тогда количество чисел больше  0 = " + count);
}
  }
*/

// Задача 43.
/*
Console.Write("Введите k1: ");
var k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
var b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
var k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
var b2 = Convert.ToDouble(Console.ReadLine());

var x = (b1 - b2)/(k1 - k2);
var y = (k1 * (b2 - b1)) / ( k1 - k2) + b1;
Console.WriteLine("будет пересекаться в точке " + x + ";" + y );
*/

//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
int m=3, n=4;
double [,] array = new double[m,n];
Random rand = new Random();
for (int i = 0; i < m; i++)
{
  for (int j = 0; j < n; j++)
  {
    array[i,j]= (double)rand.Next(-100,100)/10;
    Console.Write(array[i,j] + " ");
  }
  Console.WriteLine();
}
*/
/*
double[,] CreateRandom2dArray()
{
    Console.Write("Введите количество строк: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите min: ");
    int minValue = Convert.ToInt32(Console.ReadLine()) * 100;
    Console.Write("Введите max: ");
    int maxValue = Convert.ToInt32(Console.ReadLine()) * 100;

    double [,] array = new double[m,n];
    Random rand = new Random();

    for(int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            array[i,j] = (double)rand.Next(minValue, maxValue)/100;
    return array;
}


void Show2dArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
*/

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
Console.WriteLine("введите max");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите min ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите m ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите n ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m,n];
Console.WriteLine("введите значение");
int number = Convert.ToInt32(Console.ReadLine());
FillArray (array);
FindElementaryArray (array, number);

 void FillArray (int [,] arraytofill)
 {
  for (int i = 0; i < arraytofill.GetLength(0); i++)
  {
    for (int j = 0; j < arraytofill.GetLength(1); j++)
    {
      array[i,j] = new Random().Next(min,max); 
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }

 }

 void FindElementaryArray (int [,] findelement, int usernumber)
{
  bool number = false;
  for (int i = 0; i < findelement.GetLength(0); i++)
  {
    for (int j = 0; j < findelement.GetLength(1); j++)
    {
      if (findelement [i,j] == usernumber)
      Console.WriteLine("число находится по индексам " + i + " " +j); 
      number = true;
    }
  }
  if (!number)
  {
    Console.WriteLine("Такого значения нет");
  }
}
*/

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
Console.WriteLine("Enter min:");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter max:");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter n:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter m:");
int m = Convert.ToInt32(Console.ReadLine());
int [,]arr=new int [n, m];
double []sum=new double [m];
Random ran = new Random();

for (int i=0; i<n; i++)
{
    for(int j=0; j<m; j++)
    {
        arr[i, j] = ran.Next(min, max);

        Console.Write(arr[i, j] + "\t");
    }
    Console.WriteLine();
}

for (int i=0; i<m; i++)
{
    for(int j=0; j<n; j++)
    {
        sum[i] += arr[j, i];
    }
}

for (int i=0; i<m; i++)
{
    Console.Write((sum[i] / n)  + " ");
}

*/