int[,] array = { { -5, 11, -4 }, { 1, 2, -4 }, { 4, 8, 3 } };
int rowsum = 1;
for (int j = 0; j < array.GetLength(1); j++)
{
    rowsum *= array[0, j];
}
Console.WriteLine(rowsum.ToString());