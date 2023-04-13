/*** Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */
 
Console.Clear();
double [,] Array (int n, int m, int min, int max){
    double [,] result = new double [n,m];
    for (int i = 0; i<n; i++){
        for(int j =0; j<m; j++){
            result[i,j] = new Random().Next(min, max);
        }
    }
    return result;
}
void PrintArray(double [,] Array){
    for (int i = 0; i<Array.GetLength(0); i++){
        Console.WriteLine();
        for(int j =0; j<Array.GetLength(1); j++){
             Console.Write($"{Array[i,j]} ");
        }}
}

void average (double [,] Array){
    double avg = 0;
    double sum = 0;
    double [] result = new double [Array.GetLength(1)];
    for (int i = 0; i<Array.GetLength(1); i++){
        for(int j =0; j<Array.GetLength(0); j++){
        sum += Array[j,i];
        }
        avg = sum/Array.GetLength(0);
        Console.Write($"{avg:f1}; ");
        sum = 0;}

}
Console.WriteLine("Введите количество строк в массиве");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве");
int m = int.Parse(Console.ReadLine());
double [,] array = Array(n,m,0,10);
PrintArray(array);
Console.WriteLine();
Console.WriteLine();
Console.Write("Среднее арифметическое каждого столбца:  ");
average(array);