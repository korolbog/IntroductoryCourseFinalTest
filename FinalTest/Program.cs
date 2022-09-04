/*
Написать программу,
которая из имеющегося массива строк формирует массив из строк,
длина которых меньше или равна трем (3) символам.
*/

int m = new Random().Next(1,2);
int n = new Random().Next(3,5);

string[,] inputTable = new string [m,n];
string [,] outputTable = new string [m,m];

Console.WriteLine("Введите первую строку: ");
inputTable[0,0] = Console.ReadLine();

Console.WriteLine("Введите вторую строку: ");
inputTable[0,1] = Console.ReadLine();

Console.WriteLine("Введите третью строку: ");
inputTable[0,2] = Console.ReadLine();

Console.WriteLine("Введите четверту строку: ");
inputTable[0,3] = Console.ReadLine();






