using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeveloperShowcaseWeb.Infrastracture
{
    public class API
    {
        public static class CardModule
        {
            public static string ShuffleCard(string baseUri)
            {
                return $"{baseUri}shufflecard";
            }
        }
    }
}
