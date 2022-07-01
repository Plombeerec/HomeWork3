//Напишите программу, 
//которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.


void FindAQube (double n)
{
    double count = 0;
    while (count <= n)
    {
        double qube = Math.Pow(count ,3);
        Console.Write(qube + ", ");
        count++;
    }
    return; 
}
Console.WriteLine("Введите число");
double number = Convert.ToInt32(Console.ReadLine());
FindAQube(number);