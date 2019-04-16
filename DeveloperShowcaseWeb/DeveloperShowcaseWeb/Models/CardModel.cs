using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeveloperShowcaseWeb.Models
{
    public class CardModel
    {
        public string Value { get; set; }
        public string Type { get; set; }
    }

    public class CardListModel
    {
        public List<CardModel> CardList { get; set; }
    }
}
