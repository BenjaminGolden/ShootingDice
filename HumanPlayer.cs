using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
         public override int Roll()
        {
        Console.WriteLine("What would you like to roll? > ");
        return int.Parse(Console.ReadLine());
        }

    }
}
