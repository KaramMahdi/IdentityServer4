using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityServer
{
    public static class ResourceManager
    {
       
        public static IEnumerable<ApiResource> Apis =>
           new List<ApiResource>
           {
                new ApiResource {
                    Name = "app.api.whatever",
                    DisplayName = "Whatever Apis",
                    ApiSecrets = { new Secret("a75a559d-1dab-4c65-9bc0-f8e590cb388d".Sha256()) },

                    Scopes ={ "app.api.whatever.read", "app.api.whatever.write", "app.api.whatever.full" } 
                },
                new ApiResource("app.api.weather","Weather Apis")
           };
    }
    internal static class ClientManager
    {
        public static IEnumerable<Client> Clients =>
            new List<Client>
            {
                    new Client
                    {
                         ClientName = "Client Application1",
                         ClientId = "t8agr5xKt4$3",
                         AllowedGrantTypes = GrantTypes.ClientCredentials,
                         ClientSecrets = { new Secret("eb300de4-add9-42f4-a3ac-abd3c60f1919".Sha256()) },
                         AllowedScopes = new List<string> { "app.api.whatever.read", "app.api.whatever.write" }
                    },
                    new Client
                    {
                         ClientName = "Client Application2",
                         ClientId = "3X=nNv?Sgu$S",
                         AllowedGrantTypes = GrantTypes.ClientCredentials,
                         ClientSecrets = { new Secret("1554db43-3015-47a8-a748-55bd76b6af48".Sha256()) },
                         AllowedScopes = { "app.api.weather" }
                    }
            };
    }
}
