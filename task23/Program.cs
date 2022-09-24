/*
Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

int[] getAllSquareFromNumber(int number) 
{   
    int[] result = new int[number];
    for (int i = 0; i < number; i++)
    {
        result[i] = (int)(Math.Pow(i+1, 3));
    }
    
    return result;
}
int getNumberFromUser(string userInformation)
{
    int result = 0;
    while (result == 0)
    {
        Console.Write(userInformation);
        string userLine = Console.ReadLine();
        int.TryParse(userLine,out result);
        if (result == 0 && userLine != "0") 
        {
            Console.WriteLine($"Введите целое число, вы ввели {userLine}");
        }
        else
        {
            break;
        }
    }
    return result;
}

int num = getNumberFromUser("Введите число: ");
int[] exponentiation = getAllSquareFromNumber(num);
foreach ( var value in exponentiation ) 
{
    Console.Write(value + " ");
}