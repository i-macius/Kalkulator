int[,] t = new int[3,3];
Random r = new Random();
for (int i = 0; i < t.GetLength(0); i++)
{
    for (int j = 0; j < t.GetLength(1); j++)
    {
        t[i,j] = r.Next(1,10);
        Console.Write(t[i, j] + " ");
    }
Console.WriteLine();
}


