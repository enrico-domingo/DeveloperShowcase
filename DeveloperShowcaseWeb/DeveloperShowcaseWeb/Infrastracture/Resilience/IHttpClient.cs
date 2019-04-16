using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeveloperShowcaseWeb.Infrastracture.Resilience
{
    public interface IHttpClient
    {
        Task<string> GetStringAsync(string uri, string authorizationToken = null);
    }
}
