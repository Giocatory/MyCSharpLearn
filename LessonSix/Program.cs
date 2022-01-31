//////////////////////////////////////////////////
/*          ARRAY           */

// int[] myArray = new int[5];
Array myArray = Array.CreateInstance(typeof(int), 5);
myArray.SetValue(1, 0); // (value, index)
myArray.SetValue(2, 1); // myArray[1] = 2
// myArray.SetValue(3, 5); // Error, выход за пределы массива

foreach (int i in myArray)
{
    Console.Write($"{i} ");
} // 1 2 0 0 0
Console.WriteLine();


/*          LIST            */

List<int> list = new();
List<int> list2 = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };

list.Add(1);
list2.Add(2);

Console.WriteLine(list[0]); // 1
list.AddRange(list2);

for (int i = 0; i < list.Count; i++)
{
    Console.Write($"{list[i]} ");
} // 1 1 2 3 4 5 6 7 2
Console.WriteLine();
list.Sort();
for (int i = 0; i < list.Count; i++)
{
    Console.Write($"{list[i]} ");
} // 1 1 2 2 3 4 5 6 7
Console.WriteLine();
Console.WriteLine(list.Min()); // 1
Console.WriteLine(list.Max()); // 7


/*          DICTIONARY          */

Dictionary<long, string> phoneBook = new() // or simple: new Dictionary<long, string>()
{
    { 89149149112, "Deni" },
    { 89149149113, "Niko" }
};
phoneBook.Add(89149149114, "Mike");
phoneBook.Add(89149149115, "Taty");
phoneBook.Add(89149149116, "Maro");

Console.WriteLine(phoneBook[89149149114]); // Mike

Console.WriteLine("Keys:");
Dictionary<long, string>.KeyCollection phoneBookKeys = phoneBook.Keys;
foreach (var key in phoneBookKeys)
{
    Console.WriteLine(key);
}
/*Keys:
89149149112
89149149113
89149149114
89149149115
89149149116*/
Console.WriteLine("Values:");
Dictionary<long, string>.ValueCollection phoneBookValues = phoneBook.Values;
foreach (var value in phoneBookValues)
{
    Console.WriteLine(value);
}
/*Values:
Deni
Niko
Mike
Taty
Maro*/
Console.WriteLine($"All Dictionary ({phoneBook.Count} values):");
foreach (var info in phoneBook)
{
    Console.WriteLine($"{info.Key} -> {info.Value}");
}
/*All Dictionary(5 values):
89149149112->Deni
89149149113->Niko
89149149114->Mike
89149149115->Taty
89149149116->Maro*/