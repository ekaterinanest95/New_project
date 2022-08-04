// See https://aka.ms/new-console-template for more information

int distance = 10000;
int firstFriendSpeed = 1;
int secondFriendSpeed = 2;
int dogSpeed = 5;
int friend = 2;
int count = 0;
int time = 0;

while(count < 10)
{
if(friend == 1)
{
time = distance/(firstFriendSpeed + dogSpeed);
friend = 2;
}
else
{
time = distance/(secondFriendSpeed - dogSpeed);
friend = 1;
}

count++;

}

Console.Write("Собака пробежит: ");
Console.WriteLine(count);
