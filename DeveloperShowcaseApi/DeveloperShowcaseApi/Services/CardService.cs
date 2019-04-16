using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeveloperShowcaseApi.Model;

namespace DeveloperShowcaseApi.Services
{
    public class CardService : ICardServices
    {
        static Random _random = new Random();
        public async Task<List<CardModel>> ShuffleCards()
        {

            List<CardModel> listCards = new List<CardModel>();
            for(int i=1; i<=13; i++)
            {
                CardModel card;
                for (int x = 1; x <= 4; x++)
                {
                    card = new CardModel()
                    {
                        Value = Value(i),
                        Type = Type(x)
                    };
                    listCards.Add(card);
                }
            }

            int n = listCards.Count;
            for (int i = 0; i < n; i++)
            {
                int r = i + _random.Next(n - i);
                CardModel t = listCards[r];
                listCards[r] = listCards[i];
                listCards[i] = t;
            }
            return listCards;
        }

        public string Value(int value)
        {
            switch(value)
            {
                case 1:
                    return "Ace";
                case 2:
                    return "2";
                case 3:
                    return "3";
                case 4:
                    return "4";
                case 5:
                    return "5";
                case 6:
                    return "6";
                case 7:
                    return "7";
                case 8:
                    return "8";
                case 9:
                    return "9";
                case 10:
                    return "10";
                case 11:
                    return "Jack";
                case 12:
                    return "Queen";
                case 13:
                    return "King";
                default:
                    return "";
            }
        }

        public string Type(int type)
        {
            switch(type)
            {
                case 1:
                    return "Spades";
                case 2:
                    return "Diamonds";
                case 3:
                    return "Hearts";
                case 4:
                    return "Clubs";
                default:
                    return "";
            }
        }
    }
}
