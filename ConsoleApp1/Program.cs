string text = "123 Привет, это тестовая строка 456.";

foreach (char c in text)
{
    if (char.IsDigit(c))
    {
        text = text.Replace(c, '#');
    }
}

Console.WriteLine(text);