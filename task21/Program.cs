/*
Напишите программу, которая принимает на вход координаты 
двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

double getDistanсeFromCoordinate(int coordinateAx, int coordinateAy, int coordinateAz,
                                 int coordinateBx, int coordinateBy, int coordinateBz)
{
    double distanse = Math.Round(Math.Sqrt(Math.Pow(coordinateBx-coordinateAx, 2) + Math.Pow(coordinateBy-coordinateAy, 2) + Math.Pow(coordinateBz-coordinateAz, 2)), 2);
    return distanse;
}
int getCoordinateFromUser(string userInformation)
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

int userCoordinateAx = 0;
int userCoordinateAy = 0;
int userCoordinateAz = 0;
int userCoordinateBx = 0;
int userCoordinateBy = 0;
int userCoordinateBz = 0;
Console.WriteLine("Введите координаты");
userCoordinateAx = getCoordinateFromUser("Ax: ");
userCoordinateAy = getCoordinateFromUser("Ay: ");
userCoordinateAz = getCoordinateFromUser("Az: ");
userCoordinateBx = getCoordinateFromUser("Bx: ");
userCoordinateBy = getCoordinateFromUser("By: ");
userCoordinateBz = getCoordinateFromUser("Bz: ");
double distanceCoordinate = getDistanсeFromCoordinate(userCoordinateAx, userCoordinateAy, userCoordinateAz, userCoordinateBx, userCoordinateBy, userCoordinateBz);
Console.WriteLine($"Расстояние между точкой A({userCoordinateAx},{userCoordinateAy}, {userCoordinateAz}) и B({userCoordinateBx}, {userCoordinateBy}, {userCoordinateBz}) равно: {distanceCoordinate}.");
