Random random = new Random();

int secretnum = random.Next(1, 100);
int userGuess = 0;
int counter = 0;
Console.WriteLine("Guess thne number");

while (userGuess != secretnum)
{
    counter++;
    Console.WriteLine("Enter your number");
    userGuess = int.Parse(Console.ReadLine());

    if (userGuess > secretnum)
    {
        Console.WriteLine("Too high");

    }
    else if (userGuess < secretnum)
    {

        Console.WriteLine("Too low");
    }
    else
    {
        Console.WriteLine("You got the num right it took you counter " + counter);
    }
}
Console.ReadKey();


// Text adventure game