/*** Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

Console.Clear();
int [,] Array (int n, int m, int min, int max){
    int [,] result = new int [n,m];
    for (int i = 0; i<n; i++){
        for(int j =0; j<m; j++){
            result[i,j] = new Random().Next(min, max);
        }
    }
    return result;
}
void PrintEl(int [,] Array, int n, int m){
    int el = -1;
    for (int i = 0; i<Array.GetLength(0); i++){
        for(int j =0; j<Array.GetLength(1); j++){
            if ((i==n) && (j==m))
             el = Array[i,j];
        }}
        if (el ==-1) 
        Console.Write($"Элемента с индексами [{n},{m}] в этом массиве нет");
        else Console.Write($"Элемент с индексами [{n},{m}] в этом массиве -> {el}");
}
void PrintArray(int [,] Array){
    for (int i = 0; i<Array.GetLength(0); i++){
        Console.WriteLine();
        for(int j =0; j<Array.GetLength(1); j++){
             Console.Write($"{Array[i,j]} ");
        }}
}

Console.WriteLine("Введите индекс строки искомого элемента:");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите индекс столбца искомого элемента:");
int m = int.Parse(Console.ReadLine());
int[,] array = Array(5,5, 0, 10);
PrintArray(array);
Console.WriteLine();
PrintEl(array, n, m);
