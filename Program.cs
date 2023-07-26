// See https://aka.ms/new-console-template for more information
Console.WriteLine("You're a fan of Tory Lanez? Let's see how well you know his music");

int points = 0;
Console.WriteLine("From Which Song Did Tory Say 'So, can we? Play with the stars tonight? Can we make them all align?'");
Console.WriteLine("1: Lady of Neptune");
Console.WriteLine("2: Talk to Me");
Console.WriteLine("3: Lady of Namek");
Console.WriteLine("4: And This is Just the Intro");

//enter more available options

int answer = int.Parse(Console.ReadLine()); // get the answer from the "user"
if (answer == 3) 
{
    points++; //add one to point count
}
Console.WriteLine("From Which Song Did Tory Say 'I'm on a 12-hour flight with just my feelings it can get like this in an istant'");
Console.WriteLine("1: Feels ");
Console.WriteLine("2: Distance");
Console.WriteLine("3: Say it");
Console.WriteLine("4: Anyway");

if (answer == 2)


    Console.WriteLine("total points"+ points); 