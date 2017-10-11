using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyProgrammer
{
    public class Intermediate335 : IRunnable
    {
        public void Run()
        {
            var input = new Card[] {ParseCard("5D"), ParseCard("QS"), ParseCard("JC"), ParseCard("KH"), ParseCard("AC")};
            Console.WriteLine(CalculateFifteens(input) + CalculateRuns(input) + CalculatePairs(input) + CalculateFlushes(input) + CalculateNobs(input));
        }

        private static int CalculateFifteens(Card[] hand)
        {
            return 0;
        }

        private static int CalculateRuns(Card[] hand)
        {
            return 0;
        }

        private static int CalculatePairs(Card[] hand)
        {
            return 0;
        }

        private static int CalculateFlushes(Card[] hand)
        {
            return 0;
        }

        private static int CalculateNobs(Card[] hand)
        {
            return 0;
        }

        private static Card ParseCard(string cardString)
        {
            var card = new Card
            {
                Assignment = cardString.Substring(0, 1)
            };

            if (int.TryParse(cardString.Substring(0, 1), out var value))
            {
                card.Value = value;
            }
            else
            {
                switch (cardString.Substring(0, 1))
                {
                    case "A":
                        card.Value = 1;
                        break;
                    default:
                        card.Value = 10;
                        break;
                }
            }

            switch (cardString.Substring(1, 1))
            {
                case "S":
                    card.Suit = Suit.Spades;
                    break;
                case "H":
                    card.Suit = Suit.Hearts;
                    break;
                case "D":
                    card.Suit = Suit.Diamonds;
                    break;
                default:
                    card.Suit = Suit.Clubs;
                    break;
            }
            return card;
        }
    }

    public class Card
    {
        public Suit Suit { get; set; }
        public int Value { get; set; }
        public string Assignment { get; set; }
    }

    public enum Suit
    {
        Hearts, Spades, Diamonds, Clubs
    }
}
