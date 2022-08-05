int FirstFriendSpeed = new Random().Next(1, 7);
int SecondFriendSpeed = new Random().Next(1, 7);
int DogSpeed = new Random().Next(10, 17);
double distans = new Random().Next(10000, 17000);
int count = 0;
int Friend = 2;

Console.Write("Скорость первого друга: ");
Console.WriteLine(FirstFriendSpeed);

Console.Write("Скорость второго друга: ");
Console.WriteLine(SecondFriendSpeed);

Console.Write("Скорость собаки: ");
Console.WriteLine(DogSpeed);

Console.Write("Дистанция: ");
Console.WriteLine(distans);

while (distans > 10)
{
    double Time;
    if (Friend == 1)
    {
        Time = distans / (FirstFriendSpeed + DogSpeed);
        Friend = 2;
    }
    else 
    {
        Time = distans / (SecondFriendSpeed + DogSpeed);
        Friend = 1;
    }
    distans = distans - (FirstFriendSpeed + SecondFriendSpeed) * Time;

    count++;
}   
Console.Write("Сколько раз собака успела пребежать от одного друга к другому: ");
Console.WriteLine(count);