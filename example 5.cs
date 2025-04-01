Random diceRoll = new Random();
int rollA = diceRoll.Next(1, 7);
int rollB = diceRoll.Next(1, 7);
int rollC = diceRoll.Next(1, 7);

int totalScore = rollA + rollB + rollC;

Console.WriteLine($"Dice roll: {rollA} + {rollB} + {rollC}");

if ((rollA == rollB) && (rollB == rollC))
{
    Console.WriteLine("You rolled triples! +6 bonus to total!");
    totalScore += 6;
}
else if ((rollA == rollB) || (rollB == rollC) || (rollA == rollC))
{
    Console.WriteLine("You rolled doubles! +2 bonus to total!");
    totalScore += 2;
}

if (totalScore >= 12)
{
    Console.WriteLine("You win!");
}
else
{
    Console.WriteLine("Sorry, you lose.");
}
