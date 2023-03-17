// See https://aka.ms/new-console-template for more information
string secretWord = "devxpeace";
string guess = "";
int guessCount  = 0;
int guessLimit = 3;
bool outOfGuesses = false;

while (guess != secretWord && !outOfGuesses)
{
    if (guessCount < guessLimit)
    {
        Console.Write("Enter Guess: ");
        guess = Console.ReadLine();
        guessCount++;
    }
    else
    {
        outOfGuesses = true;
    }
    {
        if (outOfGuesses)
        {
            Console.WriteLine("You Lose!");
        }
        if (guess == secretWord)
        {
           Console.WriteLine("You Win!");
        }
    }
}












