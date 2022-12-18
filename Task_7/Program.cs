using static System.Console;
Clear();

int a1 = 15;
int b1 = 45;
int c1 = 12;

int a2 = 155;
int b2 = 455;
int c2 = 125125;

int a3 = 1572;
int b3 = 452;
int c3 = 120;

int Max (int ard1, int ard2, int ard3)
{
    int maximum = ard1;
    if (ard2 > maximum) maximum = ard2;
    if (ard3 > maximum) maximum = ard3;
    return maximum;
}
// int max1 = Max(a1, b1, c1); 
// int max2 = Max(a2, b2, c2); 
// int max3 = Max(a3, b3, c3); 
WriteLine("Максимальное число: ");
WriteLine(Max(Max(a1, b1, c1),
            Max(a2, b2, c2),
            Max(a3, b3, c3)
));
WriteLine("End");
WriteLine("End");
WriteLine("End");
