//While loop

Console.WriteLine("Enter a number: ");
int num = Int32.Parse(Console.ReadLine());
int i = 1;
while ( i <= 10) 
{
    Console.WriteLine($"{num}x{i} = {num*i}");
    i++;
}


//Do while loop
int positiveCount = 0;
int negativeCount = 0;

Console.WriteLine("Enter a number (Enter \"0\" to exit the loop):");

int num2;
do
{
    num2 = int.Parse(Console.ReadLine());

    if (num2 > 0)
    {
        positiveCount++;
    }
    else if (num2 < 0)
    {
        negativeCount++;
    }
} while (num2 != 0);

Console.WriteLine($"Number of positive numbers: {positiveCount}");
Console.WriteLine($"Number of negative numbers: {negativeCount}");



//For loop
Console.WriteLine("Enter the width: ");
int width = Int32.Parse(Console.ReadLine());
Console.WriteLine("Enter the height: ");
int height =Int32.Parse(Console.ReadLine());
Console.WriteLine("Enter if it is full or not: (Y/N)");
bool filled =Console.ReadLine().ToUpper() == "Y";


if (width == height) Square(width, filled);
else Rectangle(width, height,filled);
static void Square(int width, bool filled)
{
    for (int i = 0; i < width; i++)
    {
        for (int j = 0; j < width; j++)
        {
            if (filled || i == 0 || i == width - 1 || j == 0 || j == width - 1)
            {
                Console.Write("*");
            }
            else
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }
}

static void Rectangle(int width, int height, bool filled)
{
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            if (filled || i == 0 || i == height - 1 || j == 0 || j == width - 1)
            {
                Console.Write("*");
            }
            else
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }
}