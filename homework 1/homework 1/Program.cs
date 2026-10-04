
Console.WriteLine("Hello C#");
Console.WriteLine("------------------");
Console.WriteLine("Eda Paksoy");
Console.WriteLine("Computer Engineering");
Console.WriteLine("2nd Year (2024)");
Console.WriteLine("------------------");
Console.WriteLine($"Now:{DateTime.Now}");
Console.WriteLine("------------------");
Console.Write("Enter a temperature(°C):");
double celsius = double.Parse(Console.ReadLine());
double fahrenheit = celsius * 9 / 5 + 32;
Console.WriteLine("fahrenheit:" + fahrenheit);


