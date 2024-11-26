string text = File.ReadAllText(@"C:\DataSprint5\InPutDataFileTask5V0.txt");
string[] strings = text.Split(',');
List<string> result = new List<string>();
foreach (string str in strings)
{
    if (int.TryParse(str.Trim(), out int number) && number % 5 == 0)
    {
        result.Add(str);
    }
}
File.WriteAllLines(@"C:\DataSprint5\InPutDataFileTask5V0.txt", result);
Console.WriteLine(String.Join("\n", result));