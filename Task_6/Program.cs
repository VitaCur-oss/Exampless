using static System.Console;
Clear();

int First_Friend_Speed = 1;
int Second_Friend_Speed = 2;
int Dog_Speed = 5;
int Distance = 10000;
int Distance_to_meet = 10;
int turn = 2;
int count = 0;
int time = 0;


while (Distance_to_meet < Distance)
{
    turn = 2;
    time = Distance / (Dog_Speed + Second_Friend_Speed);
    Distance = Distance - (First_Friend_Speed + Second_Friend_Speed) * time;
    WriteLine($"Расстояние между друзьями = {Distance}.");
    count ++;
    turn = 1; 
}
WriteLine($"Собака пробежала: {count} раз между друзьями!");
WriteLine("В общем неплохо бегает пес!")
