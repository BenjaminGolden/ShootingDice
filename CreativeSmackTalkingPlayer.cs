using System;
using System.Collections.Generic;
using System.Linq;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        public List<string> TauntList { get; set; }

        
        public CreativeSmackTalkingPlayer()
        {
            TauntList = new List<string>();
        }

        public override int Roll()
        {   
            Random randomNumberGenerator = new Random();
            List<string> shuffledTaunts = TauntList.OrderBy(t => randomNumberGenerator.Next()).ToList();

            Console.WriteLine(shuffledTaunts[0]);
            // Return a random number between 1 and DiceSize
            return new Random().Next(DiceSize) + 1;
        }

    }
}