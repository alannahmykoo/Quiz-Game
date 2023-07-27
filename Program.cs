// See https://aka.ms/new-console-template for more information
Console.WriteLine("You're a fan of Tory Lanez? Let's see how well you know his music");

bool correct = false;
int answer = 0;
int points;
while (!correct)
{

    points = 0;
    Console.WriteLine("From Which Song Did Tory Say 'So, can we? Play with the stars tonight? Can we make them all align?'");
    Console.WriteLine("1: Lady of Neptune");
    Console.WriteLine("2: Talk to Me");
    Console.WriteLine("3: Lady of Namek");
    Console.WriteLine("4: And This is Just the Intro");

    //enter more available options

    answer = int.Parse(Console.ReadLine()); // get the answer from the "user"
    if (answer == 3)
    {
        points++;
        Console.WriteLine("From Which Song Did Tory Say 'I'm on a 12-hour flight with just my feelings it can get like this in an istant'");
        Console.WriteLine("1: Feels ");
        Console.WriteLine("2: Distance");
        Console.WriteLine("3: Say it");
        Console.WriteLine("4:'87 Stingray");


        answer = int.Parse(Console.ReadLine());
        if (answer == 2)
        {
            points++;
            Console.WriteLine("From Which Song Did Tory Say ' Cause you have the time of your life only when I'm not around'");
            Console.WriteLine("1: Hurts Me ");
            Console.WriteLine("2: Sorry 4 What? ");
            Console.WriteLine("3: Where 2 Start ");
            Console.WriteLine("4: One Day ");

            answer = int.Parse(Console.ReadLine());
            if (answer == 1)
            {
                points++;
                Console.WriteLine("From Which Song Did Tory Say 'I'll break up with you cause if it's gon be toxic' ");
                Console.WriteLine("1:The make up ");
                Console.WriteLine("2: In for it ");
                Console.WriteLine("3: Luv ");
                Console.WriteLine("4:Lady of Neptune");

                answer = int.Parse(Console.ReadLine());
                if (answer == 4)
                {
                    
                    points++;
                    Console.WriteLine("What Was Tory Lanez First Album?");
                    Console.WriteLine("1: Cruel Intentions ");
                    Console.WriteLine("2: I Told You ");
                    Console.WriteLine("3: The New Toronto ");
                    Console.WriteLine("4: Alone at Prom "); 
                    
                    answer = int.Parse(Console.ReadLine());
                    if (answer == 2)
                    {
                        points++;
                        Console.WriteLine("What Was Tory Lanez Most Recent Album?"); 
                        Console.WriteLine("1: Sorry 4 What");
                        Console.WriteLine("2: Playboy ");
                        Console.WriteLine("3: MEMORIES DON'T DIE ");
                        Console.WriteLine("4: Alone at Prom ");
                        answer = int.Parse(Console.ReadLine());
                        if (answer == 1)
                        { 
                            points++;
                            Console.WriteLine("Wow You Completed The Quiz Ayden Is So Proud! Congrats" + " Here Are Your Points" + points);
                            correct = true;
                        }
                        else
                        {
                            correct = false;
                            Console.WriteLine("You got " + points + " questions right. Try again.");
                        }
                    }
                    else
                    {
                        correct = false;
                        Console.WriteLine("You got " + points + " questions right. Try again.");
                    }

                }
              
                else
                {
                    correct = false;
                    Console.WriteLine("You got " + points + " questions right. Try again.");
                }

            }
            else
            {
                correct = false;
                Console.WriteLine("You got " + points + " questions right. Try again.");
            }

        }
        else
        {
            correct = false;
            Console.WriteLine("You got " + points + " questions right. Try again.");
        }




    }
    else
    {
        correct = false;
        Console.WriteLine("You got " +points + " questions right. Try again." );
    }




}


