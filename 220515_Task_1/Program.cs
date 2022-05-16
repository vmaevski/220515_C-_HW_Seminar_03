// 1. Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно полиндромом ("зеркальным"). 

void Polindrom_1(int num)
{
    string Text = ($"NO. The number {num} is not a Polyndrom.");
    string str = num.ToString();
    if (str[0] == str[4] && str[1] == str[3])
    {
        Text = ($"Yes. The number {num} is the Polyndrome.");
    }
    Console.WriteLine(Text);
}

void Polindrom_2(int num)
{
    Console.WriteLine("Sorryan, method 2 in development...");
}
Console.WriteLine("Method 1:");
Polindrom_1(12412);
Polindrom_1(23432);
Polindrom_1(12821);

Console.WriteLine("Method 2:");
Polindrom_2(12412);
Polindrom_2(23432);
Polindrom_2(12821);