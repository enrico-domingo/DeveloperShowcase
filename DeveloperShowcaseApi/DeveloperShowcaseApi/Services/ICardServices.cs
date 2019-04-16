using DeveloperShowcaseApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeveloperShowcaseApi.Services
{
    public interface ICardServices
    {
        Task<List<CardModel>> ShuffleCards();
    }
}
