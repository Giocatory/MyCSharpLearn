// new syntax switch 
do
{
    try
    {
        Console.Write("Введите цифру от 0 до 9: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(number switch
        {
            1 => "Вы ввели цифру 1",
            2 => "Вы ввели цифру 2",
            3 => "Вы ввели цифру 3",
            4 => "Вы ввели цифру 4",
            5 => "Вы ввели цифру 5",
            6 => "Вы ввели цифру 6",
            7 => "Вы ввели цифру 7",
            8 => "Вы ввели цифру 8",
            9 => "Вы ввели цифру 9",
            0 => "Вы ввели цифру 0",
            _ => "Вы ввели цифру в неверном диапазоне",
        });
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
} while (true);