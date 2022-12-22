// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// double[,] Create2dArray(int rows, int cols){
//     double[,] array = new double[rows, cols];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//            array[i,j] = Math.Round((new Random().NextDouble()*100), 2);
//         }
//     }
//     return array;
// }

// void Show2dArray(double[,] array){
// for(int i = 0; i < array.GetLength(0); i++){
//     for (int j = 0; j <  array.GetLength(1); j++){
//         Console.Write(array[i,j] + " ");
//     }
//     Console.WriteLine();
//  }
// }

// Console.Write("Enter numb of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter numb of cols: ");
// int n = Convert.ToInt32(Console.ReadLine());

// double [,] myArray = Create2dArray(m, n);
// Show2dArray(myArray);

//     Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4


//   int [,] Create2dArray(int rows, int cols, int min, int max){
//     int[,] array = new int[rows, cols];
//     for(int i = 0; i < rows; i++){
//         for (int j = 0; j <  cols; j++){
//             array[i,j]= new Random().Next(min,max+1);
//         }
//      }
//      return array;
//     }

//   void Show2dArray(int[,] array){
//     for(int i = 0; i < array.GetLength(0); i++){
//         for (int j = 0; j <  array.GetLength(1); j++){
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//      }
//     }

//   void ElementValue (int[,] array, int i, int j){
//     if(i< array.GetLength(0) && j <  array.GetLength(1)){
//       Console.Write($"Element value is: {array[i, j]}");
//     }
//     else
//     Console.Write($"Such an element does not exist.");
//   }


// Console.Write("Enter numb of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter numb of cols: ");
// int cols = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter min: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter max: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int[,] array = Create2dArray(rows, cols, min, max);
// Show2dArray(array);
// Console.WriteLine();  
// Console.WriteLine("Enter value of row: ");
// int row = Convert.ToInt32(Console.ReadLine());   
// Console.WriteLine("Enter value of column: ");
// int column = Convert.ToInt32(Console.ReadLine());  
// Console.WriteLine();  
// ElementValue(array, row, column);  


//    Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

  int [,] Create2dArray(int rows, int cols, int min, int max){
    int[,] array = new int[rows, cols];
    for(int i = 0; i < rows; i++){
        for (int j = 0; j <  cols; j++){
            array[i,j]= new Random().Next(min,max);
        }
     }
     return array;
  }
  
  void Show2dArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j <  array.GetLength(1); j++){
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
     }
  }

  void ArithmeticMean(int[,] array){

     
    for (int j = 0; j < array.GetLength(1); j++)
    {    double summ = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
          summ = summ+array[i,j];
          // Console.WriteLine(summ);
        }
       Console.Write($"{Math.Round((summ/array.GetLength(0)),1)} ");
    }
    
}


Console.Write("Enter numb of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter numb of cols: ");
int cols = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter numb of min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter numb of max: ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] array = Create2dArray(rows, cols, min, max);
Show2dArray(array);
System.Console.WriteLine();
ArithmeticMean(array); 

    