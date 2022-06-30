//Напишите программу, которая принимает на вход пятизначное число 
//и проверяет, является ли оно палиндромом.

void Palindromus(int n)
{
    if ((n > 10000) & (n  < 100000))
    {
        int llNumber = n %100000 / 10000;
        int lrNumber = n %10 / 1;
        int mlNumber = n %10000 / 1000;
        int mrNumber = n %100 / 10;

        if ((llNumber == lrNumber) && (mlNumber == mrNumber))
        {
            Console.WriteLine(n +" is a Pallindrom");
        }
        else
        {
            Console.WriteLine(n+ " is not a Pallindrom");
        }
    }
    else
    {
        Console.WriteLine("Введено некорректное число!");
    }
    
}


Console.WriteLine("Введите пятизначное число, для проверки, является ли оно паллиндромом");
int number = Convert.ToInt32(Console.ReadLine());
Palindromus(number);