using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3___Number_Wars
{
    public class Program
    {
        static void Main(string[] args)
        {
            var firstPlayer = new Queue<string>(Console.ReadLine().Split());
            var secondPlayer = new Queue<string>(Console.ReadLine().Split());

            int turns = 0;
            bool gameOver = false;  

            while (turns < 1000000 && firstPlayer.Count > 0 && secondPlayer.Count > 0 && !gameOver)
            {
                turns++;
                var fpCard = firstPlayer.Dequeue();
                var spCard = secondPlayer.Dequeue();

                var compareCards = GetInt(fpCard).CompareTo(GetInt(spCard));
                if (compareCards > 0)
                {
                    firstPlayer.Enqueue(fpCard);
                    firstPlayer.Enqueue(spCard);
                }
                else if (compareCards < 0)
                {
                    secondPlayer.Enqueue(spCard);
                    secondPlayer.Enqueue(fpCard);
                }
                else
                {
                    var cards = new List<string>()
                    {
                        fpCard,spCard
                    };

                    while (!gameOver)
                    {
                        if (firstPlayer.Count >= 3 && secondPlayer.Count >= 3)
                        {
                            int fpSum = 0;
                            int spSum = 0;
                            for (int i = 0; i < 3; i++)
                            {
                                var fplCard = firstPlayer.Dequeue();
                                var splCard = secondPlayer.Dequeue();

                                fpSum += fplCard[fplCard.Length - 1];
                                spSum += splCard[splCard.Length - 1];

                                cards.Add(fplCard);
                                cards.Add(splCard);
                            }

                            var compareSum = fpSum.CompareTo(spSum);

                            if (compareSum > 0)
                            {
                                foreach (var card in cards.OrderByDescending(x => GetInt(x))
                                                                .ThenByDescending(x => GetLetter(x)))
                                {
                                    firstPlayer.Enqueue(card);
                                }
                                break;
                            }
                            else if (compareSum < 0)
                            {
                                foreach (var card in cards.OrderByDescending(x => GetInt(x))
                                                            .ThenByDescending(x => GetLetter(x)))
                                {
                                    secondPlayer.Enqueue(card);
                                }
                                break;
                            }
                        }
                        else
                        {
                            gameOver = true;
                        }
                    }

                }

            }

            string result = string.Empty;
            int cardsCountCompare = (firstPlayer.Count).CompareTo(secondPlayer.Count);
            if (cardsCountCompare == 0 || turns > 1000000)
                result = $"Draw after {turns} turns";
            else if(cardsCountCompare > 0)
            {
                result = $"First player wins after {turns} turns";
            }
            else
            {
                result = $"Second player wins after {turns} turns";
            }

            Console.WriteLine(result);
        }
        static int GetInt(string card)
        {
            return int.Parse(card.Substring(0, card.Length - 1));
        }

        static int GetLetter(string card)
        {
            return card[card.Length - 1];
        }
    }
}
