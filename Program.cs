// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// int Method1() {
// int a = 0;
// int[]array = new int [new Random().Next()];
// Console.Write("Массив, заполненный случайными положительными трёхзначными числами: ");
// foreach (int i in array){
//     array[i]= new Random().Next(100,1000);
//     Console.Write($"{array[i]} ");
// if (array[i]%2 == 0){
//     a++;
// }
// }
// return a;
// }
// int res = Method1();
// Console.Write("Количество четных чисел в массиве: "+ res);



// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

// int Method2(){
//     int a = 0;
// int[]array = new int [123];
// Console.Write("Одномерный массив из 123 случайных чисел: ");
// foreach (int i in array ){
//     array[i]= new Random().Next();
//     Console.Write($"{array[i]} ");
//     if (array[i]>=10 && array[i]<=99){
// a++;
//     }
// }
// return a;
// }
// int res = Method2();
// Console.WriteLine("");
// Console.Write("Количество элементов массива, значения которых лежат в отрезке [10,99]: "+ res);

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// int Method3 (){
//     int[]array = new int [5];
//     int sum = 0;
//     Console.Write("Одномерный массив из случайных чисел: ");
//     for (int i = 0; i < array.GetLength(0); i++){
//         array[i]= new Random().Next(1,20);
//         Console.Write($"{array[i]} ");
//         if (i % 2 > 0) {
//             sum=sum+array[i];
//         }
//     } 
//     return sum;
// }
// int res = Method3();
// Console.Write("Сумма элементов, стоящих на нечетных позициях: "+ res);



// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.

// double Method4(){
//     double[]array= new double [5];
//     double max = array[0];
//     double min = array[0];
//     for (int i = 0; i < array.GetLength(0); i++){
//         array[i]= new Random().Next(0,1843789);
//         Console.Write(" "+array[i]," ");
//         if (array[i] > max){
//             max = array[i];
//         }
//         else 
//         if (array[i] < min){
//             min = array[i];
//         }
        
//     }
//     double a;
//     a = max - min;
//     return a;
// }
// double res = Method4();
// Console.WriteLine("");
// Console.Write("Разница между максимальным и минимальным элементом массива: " + res);


// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// void Method5(){
//     int[]array= new int [new Random().Next(0,100)];
//     int n = array.GetLength(0);
//     for (int i = 0; i < n; i++){
//         array[i] = new Random().Next(0,100);
//         Console.Write(array[i]+" ");
//     }

//     Console.Write("\n");
    
   
//     int mid = n/2+(n%2);
//     int[]res= new int [mid];
//     for (int i = 0; i < mid; i++){
//         if (i!=(n-i-1)){
//             res[i] = array[i] + array[n-i-1];
//         }
//         else {
//             res[i]=array[i];
//         }
//         Console.Write(res[i]+" ");

//     }
    
// }
// Method5();
