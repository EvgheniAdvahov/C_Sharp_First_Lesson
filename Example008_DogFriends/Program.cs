﻿
double count = 0;
double distance = 10000;
double firstFriendSpeed = 1;
double secondFriendSpeed = 2;
double dogSpeed = 5;
double friend = 2;
double time;

while(distance > 10)
{
    if(friend == 1)
    {
        time = distance/(firstFriendSpeed * dogSpeed);
        friend = 2;
    }
    else
    {
        time = distance/(secondFriendSpeed * dogSpeed);
        friend = 1;
    }
    distance = distance - ((firstFriendSpeed + secondFriendSpeed) * time);
    count +=1;

} 
Console.Write("Собака пробежит: ");
Console.WriteLine(count);
 
