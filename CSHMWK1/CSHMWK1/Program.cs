using System;

namespace CSHMWK1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Heroes and Heroines!");
            Console.WriteLine("Select your hero: 'Shadow Mist', 'Stratos', 'Vyon', 'SolidSoldier'");
            Console.WriteLine("'Darklaw', 'Special Summoned Only'");
            string hero = Console.ReadLine();
                      
            if(hero == "Shadow Mist")
            {
                Console.WriteLine("If this monster is special summoned, you can add a 'Change' quickplay from your deck to your hand.  If this monster is sent to the graveyard, you can add one 'HERO' monster from your deck to your hand.");
            }else if (hero == "Stratos")
            {
                Console.WriteLine("When this monster is normal or special summoned, you can add -a 'Hero' monster from your deck to your hand. -destroy two of your opponent's resources");
            }
            else if(hero == "Vyon")
             {
                Console.WriteLine("When this monster is normal summoned, you can send one monster from the deck to the graveyard.");
            }
            else if (hero == "SolidSoldier")
            {
                Console.WriteLine("When this monster is normal or special summoned, you can special summon one 'Hero' monster from your hand");
            }
            else if (hero == "Darklaw")
            {
                Console.WriteLine("Must be special summoned with 'Mask Change'. Once per turn when your opponent adds a card outside of their 'Draw Phase' you can select one card at random and banish it.  All of your opponents cards are removed from play instead of the graveyard");
            }

            Console.WriteLine("You've made an excellent choice!  Are you ready for this adventure?");
            string answer = Console.ReadLine();
            if(answer == "yes")
            {
                Console.WriteLine("Buckle Down!");
            }
            else if(answer == "no")
                Console.WriteLine("Too Bad");
            
            Console.WriteLine("Your first opponent was inexperienced.  You were able to get by without unfolding your special combo.  Here is a recap.  You summoned SolidSoldier to special summon Stratos.  You activated on of Stratos effect to destroy two of your opponents monsters.  You attacked your opponent directly dealing maximum damage!");
            Console.WriteLine("Nice Job");
            Console.WriteLine("You second opponent was intermeidate.  They played a trolling deck and was unmatched for Vyon's effect to dump Shadow Mist into the graveyard allowing you to add another Hero monster to the hand.  Which allowed to add SolidSoldier.  On your next turn, you summoned SolidSoldier, activated SolidSoldiers effect to specail summon Stratos and obliterated your opponent");
            Console.WriteLine("Congratulations. You've made it to the finals of the tournament.  You've owned many opponents with a variety of monsters.  Lightsworns are in the finals, and their monsters are decked out, literally.  We've noticed that your opponent is relying heavily on their graveyard.  We need a way to prohibit the opponent from sending cards to their graveyard.");
            Console.WriteLine("Play the right combinations of cards to send your opponent to the Shadow Realm!");
            string combo = Console.ReadLine();
            if (combo == "Stratos, Shadow Mist, Vyon, SolidSoldier")
            {
                Console.WriteLine("Trigger Shadow Mist's effect to get 'Mask Change' TRY AGAIN");
            }
            else if (combo == "Stratos, Shadow Mist, SolidSoldier, Vyon")
            {
                Console.WriteLine("Normal Summon SoliderSolider to Special Summon Shadow Mist TRY AGAIN");
            }
            else if (combo == "SolidSoldier, Shadow Mist, Darklaw, Stratos")
            {
                Console.WriteLine("Good Game!");
            }

        }
        
    }


    
}

