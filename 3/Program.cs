string str = "teamwithsomeofexcersicesabcwanttomakeitbetter";
if (str.Split("abc").Length > 1)
{
    string str1 = str.Split("abc")[0];
    string str2 = str.Split("abc")[1];
    Console.WriteLine($"{str1}\n{str2}");
}
else
    Console.WriteLine("Разделить нельзя");
