void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] != 0) Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);
bool exit = false;
int[] row = new int[n + 2];
row[0] = 1;
for (int i = 1; i < n; i++)
{
    row[i] = row[i - 1] + 1;
    /* Console.Write(row[i] + " "); */
}
Console.WriteLine();
int[,] group = new int[n + 1, n + 1];
int k = 1;
group[0, 0] = 1;

for (int i = 1; i <= n; i++)
{
    if (row[k] == 0) break;
    else
    {
        group[i, 0] = row[k];
        /* Console.WriteLine($"group[{i}, 0]={row[k]}"); */
        for (int j = 1; j < n; j++)
        {
            /* Console.WriteLine("row[k]=" + row[k]); Console.ReadLine(); */
            for (int m = 0; m < j; m++)
            {
                /* Console.WriteLine("row[k+1] % group[i, m]=" + row[k + 1] + "%" + group[i, m] + "=" + row[k + 1] % group[i, m]);
                Console.ReadLine(); */
                if (row[k + 1] % group[i, m] == 0)
                {
                    exit = true;
                    j = n; /* Console.WriteLine(j); */
                    k = k + 1; break;
                }
                else exit = false;
            }
            if (exit == false)
            {
                group[i, j] = row[k + 1];
                k = k + 1;
                /* Console.WriteLine($"group[{i},{j}]=" + group[i, j] + " " + k); */
            }
        }
    }
}


PrintArray(group);

