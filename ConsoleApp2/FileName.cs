//using System.ComponentModel.Design;

//Random random = new Random();

//int secretnum = random.Next(1, 100);
//int userGuess = 0;
//int counter = 0;
//Console.WriteLine("Guess thne number");

//while (userGuess != secretnum)
//{
//    counter++;
//    Console.WriteLine("Enter your number");
//    userGuess = int.Parse(Console.ReadLine());

//    if (userGuess > secretnum)
//    {
//        Console.WriteLine("Too high");

//    }
//    else if (userGuess < secretnum)
//    {

//        Console.WriteLine("Too low");
//    }
//    else
//    {

//        Console.WriteLine("You got the num right it took you counter " + counter);
//    }
//}
//Console.ReadKey();


//// Text adventure game


//int currenthealth = 10;

//bool starting = false;

//Console.WriteLine("Enter the bridge");

//while (!starting)
//{
//    Console.WriteLine("What is the height of mine");
//    string guess = Console.ReadLine();

//    if(guess != "5ft")
//    {
//        currenthealth--;

//    }
//    else
//    {
//        Console.WriteLine("Move forward");
//    }

//    Console.WriteLine("What is your favorite food");
//    string food  = Console.ReadLine();
//    if(food != "momo")
//    {
//        currenthealth -= 5;
//    }
//    else
//    {
//        Console.WriteLine("Move forward");
//    }

//    Console.WriteLine("What is your name");

//    string name = Console.ReadLine();

//    if(name != "Kyser")
//    {
//        currenthealth -= 5;
//        Console.WriteLine("You are dead");
//    }
//    else
//    {
//        Console.WriteLine("You are crssed the bridge");
//        starting = false;
//    }

//    Console.ReadKey();
//}




// Text adventure game

using System.Runtime.InteropServices;
Console.WriteLine("Enter your class name");
string classname = Console.ReadLine();

Console.WriteLine("Do you want to enter the forest");

string choice = Console.ReadLine();


if (choice.ToLower() == "enter")
{
    Console.WriteLine("you have entered the forest");
}
else
{
    Console.WriteLine("You are camping outside");

}


bool running = true;


while (running)
{
    Console.WriteLine("Which direction you want to take");

    string choices = Console.ReadLine();

    if(choices.ToLower() == "left")
    {
        Console.WriteLine("You have found the treasure");
        running = false;
    }
    else
    {
        Console.WriteLine("You have encountered the beast");
        Console.WriteLine("You have two option fight or flee");
        string option = Console.ReadLine();

        if(option.ToLower() == "fight")
        {
            Random randoms = new Random();
            int luck = randoms.Next(1, 11);

            if (luck > 5)
            {
                Console.WriteLine("You have damaged the beast");

                if (luck > 8)
                {
                    Console.WriteLine("You have dropped the treasure");

                }
            }
            else
            {

                Console.WriteLine("You are dead");
                

            }
            running = false;
        }
        Console.WriteLine("Thank you for playing the game");
        
    }
    Console.ReadKey();
}
