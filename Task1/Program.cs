Console.Clear();
Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);
bool exit = false;
int k = 2;
int[] group = new int[n];
group[0] = k - 1;
Console.Write($"-Группа {1}: " + group[0]);
for (int i = 1; i <= n; i++)
{
    if (k >= n) break;
    else
    {
        Console.WriteLine();
        group[0] = k;
        Console.Write($"-Группа {i + 1}: " + group[0]);
        for (int j = 1; j < n; j++)
        {
            for (int m = 0; m < j; m++)
            {
                if ((k + 1) > n | (k + 1) % group[m] == 0)
                {
                    exit = true;
                    j = n;
                    k = k + 1; break;
                }
                else exit = false;
            }
            if (exit == false)
            {
                group[j] = k + 1;
                k = k + 1;
                Console.Write(" " + group[j]);
            }
        }
    }
}