Random randomNumber = new Random();
int computerNumber = randomNumber.Next(1, 101);
while (true)
{
    Console.Write("Please, guess my number... it's from 1 to 100. Try: ");
    string playerInput = Console.ReadLine();
    bool isValid = int.TryParse(playerInput, out int playerNumber);
    if (isValid)
    {
        if (playerNumber == computerNumber)
        {
            Console.WriteLine($"Congratulations!!! You guessed the number! It's {computerNumber}");
            break;
        }
        else if (playerNumber > computerNumber)
        {
            Console.WriteLine($"Oh, you guessed wrong! Try a little bit DOWN!");
        }
        else
        {
            Console.WriteLine($"Oh, you guessed wrong! Try a little bit UP!");
        }
    }
    else
    {
        Console.WriteLine("Invalid input!!! Try again!!!");
    }
}

