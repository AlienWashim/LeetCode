string str1 = Console.ReadLine();
string str2 = Console.ReadLine();
if (str1.Length != str2.Length){
    Console.WriteLine("No");
}

if (str1.OrderBy(c => c).SequenceEqual(str2.OrderBy(c => c)))
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}