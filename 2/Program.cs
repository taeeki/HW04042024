string[] str = { "Welcome ", "to ", "the ", "TMS ", "lesons." };
string concat_str = "";
for (int i = 0; i < str.Length; i++)
{
    concat_str += string.Concat(str[i]);
}
Console.WriteLine(concat_str);