Random random = new Random();

int cpuRandom;

bool loopActive = true; //bool - true/false

while (loopActive)
{
    cpuRandom = random.Next(1, 4);
    //Console.WriteLine($"CPU has generated {cpuRandom}");
    Console.WriteLine("Make a guess! Enter a number 1-4.");

    int userNumber = Int32.Parse(Console.ReadLine());

    if (userNumber == cpuRandom)
    {
        Console.WriteLine("Congratulations, you won!");
        //loopActive = false;
        break;
    }
    else
    {
        Console.WriteLine("Oops. Try again!");
    }
}
