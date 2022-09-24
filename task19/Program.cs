/*
Напишите программу, которая принимает на вход пятизначное
число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

int getNumberCheck(int userNumber)
{
    int result = 0;
    int number1 = userNumber / 10000;
    int number2 = (userNumber / 1000) % 10;
    int number4 = (userNumber / 10) % 10;
    int number5 = userNumber % 10;
    if (userNumber >= 10000 && userNumber < 99999)
    {
        if (number1 == number5 && number2 == number4)
        {   
            Console.WriteLine($"Число {userNumber} является палиндромом");
        }
        else 
        {
            Console.WriteLine($"Число {userNumber} НЕ является палиндромом");
        }
    }
    else 
    {
        Console.WriteLine("Введите пятизначное число!!!");
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

int number = 0;
number = getNumberFromUser("Введите пятизначное число: ");
int someResult = getNumberCheck(number);