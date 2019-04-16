using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using DeveloperShowcaseWeb.Infrastracture;
using DeveloperShowcaseWeb.Infrastracture.Resilience;
using DeveloperShowcaseWeb.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace DeveloperShowcaseWeb.Services
{
    public class CardService : ICardService
    {
        private readonly IOptionsSnapshot<AppSettings> _appSettings;
        private readonly IHttpClient _apiClient;
        private readonly string _remoteServiceBaseUrl;

        public CardService(IOptionsSnapshot<AppSettings> appSetting, IHttpClient httpClient)
        {
            _appSettings = appSetting;
            _apiClient = httpClient;
            _remoteServiceBaseUrl = $"{_appSettings.Value.CardModuleUrl}/api/v1/card/";
        }

        public async Task<IList<CardModel>> ShuffleCard()
        {
            var getCardModuleUri = API.CardModule.ShuffleCard(_remoteServiceBaseUrl);

            var dataString = await _apiClient.GetStringAsync(getCardModuleUri);

            var response = JsonConvert.DeserializeObject<List<CardModel>>(dataString);

            return response;
        }
    }
}
