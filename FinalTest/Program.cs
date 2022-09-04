/*
Написать программу,
которая из имеющегося массива строк формирует массив из строк,
длина которых меньше или равна трем (3) символам.
*/

int m = new Random().Next(1,2);
int n = new Random().Next(3,5);

string[,] inputTable = new string [m,n];
string [,] outputTable = new string [m,m];

int k = 0;
int l = 0;

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.WriteLine($"Введите строку {j+1} из {n}: ");
        inputTable[i,j] = Console.ReadLine();
        
        if (inputTable[i,j].Length <= 3)
        {
            outputTable[k,l] += $"{inputTable[i,j]} \t";
        }
    }
}
Console.WriteLine("Выходной массив:");
Console.WriteLine(outputTable[k,l]);







