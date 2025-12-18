using System.ComponentModel.Design;

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


int currenthealth = 10;

bool starting = false;

Console.WriteLine("Enter the bridge");

while (!starting)
{
    Console.WriteLine("What is the height of mine");
    string guess = Console.ReadLine();

    if(guess != "5ft")
    {
        currenthealth--;

    }
    else
    {
        Console.WriteLine("Move forward");
    }

    Console.WriteLine("What is your favorite food");
    string food  = Console.ReadLine();
    if(food != "momo")
    {
        currenthealth -= 5;
    }
    else
    {
        Console.WriteLine("Move forward");
    }

    Console.WriteLine("What is your name");

    string name = Console.ReadLine();

    if(name != "Kyser")
    {
        currenthealth -= 5;
        Console.WriteLine("You are dead");
    }
    else
    {
        Console.WriteLine("You are crssed the bridge");
        starting = false;
    }

    Console.ReadKey();
}




// Text adventure game


Console.WriteLine("Welcome to adventure game");

Console.Write("Enter your characters name");

string p1 = Console.ReadLine();

Console.WriteLine("Choose your character Warrior, Wizard or archer");
string characterType = Console.ReadLine();

Console.WriteLine("You are "+  p1 + characterType );

Console.WriteLine("You wanna enter or not ");
string choice1 = Console.ReadLine();



if(choice1.ToLower() == "enter")
{
    Console.WriteLine("You entered teh forest");
}
else
{
    Console.WriteLine("Camping");
}



bool gameContinues = true;

while (gameContinues)
{
    Console.WriteLine("You came to fort or go left or right");
    string direction = Console.ReadLine();
    if(direction.ToLower() == "left")
    {
        Console.WriteLine("You found a chest");
        gameContinues = false;
    }

    else
    {
        Console.WriteLine("You encountered a wild beast");

        Console.WriteLine("Fight or flee");
        string choices = Console.ReadLine();

        if(choices.ToLower() == "fight")
        {
            Console.WriteLine("You damaged the beast");
            gameContinues = false;


        }
        else
        {
            Console.WriteLine("Flee you are running back to camp");
        }
    }
}


    Console.ReadKey();