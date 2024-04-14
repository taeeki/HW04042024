string str = "Плохой день.";

string substring = "Плохой";


str = str.Substring(substring.Length);
Console.WriteLine($"Результат удаления: {str}");

str = str.Insert(0, "Хороший"); //Хороший день!!!!!!!!!
str = str.Insert(str.Length - 1, "!!!!!!!!!");
Console.WriteLine($"Результат добавления: {str}");

str = str.Substring(0, str.Length - 1) + "?";

Console.WriteLine($"Результат замены: {str}");
 