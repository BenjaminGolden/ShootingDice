using System;
using System.Collections.Generic;
using System.Linq;

namespace ShootingDice
{
    class Program 
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            player1.Name = "Bob";
            

            Player player2 = new Player();
            player2.Name = "Sue";

            player2.Play(player1);

            Console.WriteLine("-------------------");

            Player player3 = new Player();
            player3.Name = "Wilma";

            player3.Play(player2);

            Console.WriteLine("-------------------");

            LargeDicePlayer large = new LargeDicePlayer();
            large.Name = "Bigun Rollsalot";

            SmackTalkingPlayer Justin = new SmackTalkingPlayer();
            Justin.Name = "Justin";
            Justin.Taunt = "I remember my first time rolling dice!";

            SmackTalkingPlayer Laura = new SmackTalkingPlayer();
            Laura.Name = "Laura";
            Laura.Taunt = "You're going to need more than that!";

            OneHigherPlayer Jose = new OneHigherPlayer();
            Jose.Name = "Jose";

            HumanPlayer John = new HumanPlayer();
            John.Name = "John";

            Jose.Play(large);

            Console.WriteLine("---------------------");

            Laura.Play(Justin);

            Console.WriteLine("-------------------");


            CreativeSmackTalkingPlayer Bob = new CreativeSmackTalkingPlayer();
            Bob.Name = "Bob";
            Bob.TauntList.Add("You suck! Jackass. ");
            Bob.TauntList.Add("Roll it with your purse!");
            Bob.TauntList.Add("Do you always lose?");
            Bob.TauntList.Add("the price is wrong, bitch!");

            SoreLoserPlayer Jess = new SoreLoserPlayer();
            Jess.Name = "Jess";
            
            Jess.Play(player1);

            Console.WriteLine("-------------------");

            UpperHalfPlayer Brittany = new UpperHalfPlayer();
            Brittany.Name = "Brittany";

            List<Player> players = new List<Player>() {
                player1, player2, player3, large, Justin, Laura, Jose, John, Bob, Jess, Brittany
            };

            PlayMany(players);
        }

        static void PlayMany(List<Player> players)
        {
            Console.WriteLine();
            Console.WriteLine("Let's play a bunch of times, shall we?");

            // We "order" the players by a random number
            // This has the effect of shuffling them randomly
            Random randomNumberGenerator = new Random();
            List<Player> shuffledPlayers = players.OrderBy(p => randomNumberGenerator.Next()).ToList();

            // We are going to match players against each other
            // This means we need an even number of players
            int maxIndex = shuffledPlayers.Count;
            if (maxIndex % 2 != 0)
            {
                maxIndex = maxIndex - 1;
            }

            // Loop over the players 2 at a time
            for (int i = 0; i < maxIndex; i += 2)
            {
                Console.WriteLine("-------------------");

                // Make adjacent players play one another
                Player player1 = shuffledPlayers[i];
                Player player2 = shuffledPlayers[i + 1];
                player1.Play(player2);
            }
        }
    }
}