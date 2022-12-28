using IdentityServer4.Models;

namespace FleetManagment.IdentityServer
{
    public class Config
    {
        public static IEnumerable<IdentityResource> IdentityResources =>
            new[]
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
                new IdentityResource
                {
                    Name= "role",
                    UserClaims = new List<string> {"role"}
                }
            };

        public static IEnumerable<ApiScope> ApiScopes =>
        new[]
        {
            new ApiScope("FleetManagmentAPI.read"),
            new ApiScope("FleetManagmentAPI.write"),
            new ApiScope("FleetManagmentAPI.readwrite"),
        };
        
        public static IEnumerable<ApiResource> ApiResources =>
            new[]
            {
                new ApiResource("FleetManagmentAPI")
                {
                    Scopes = new List<string> { "FleetManagmentAPI.read", "FleetManagmentAPI.write", "FleetManagmentAPI.readwrite" },
                    ApiSecrets= new List<Secret> { new Secret("ScopeSecret".Sha256()) },
                    UserClaims= new List<string> { "role" }
                }
            };

        public static IEnumerable<Client> Clients =>
            new[]
            {
                 new Client
                {
                    ClientId = "client",
                    ClientName = "Client for Postman user",
                    AllowedGrantTypes = GrantTypes.ResourceOwnerPasswordAndClientCredentials,
                    ClientSecrets = { new Secret("secret".Sha256()) },
                    AllowedScopes = { "api1", "user"},
                    AlwaysSendClientClaims = true,
                    AlwaysIncludeUserClaimsInIdToken = true,
                    AllowAccessTokensViaBrowser = true
                },

                new Client
                {
                    ClientId = "swagger",
                    ClientName = "Client for Swagger user",
                    AllowedGrantTypes = GrantTypes.CodeAndClientCredentials,
                    ClientSecrets = {new Secret("secret".Sha256())},
                    AllowedScopes = {"api1", "user", "openid"},
                    AlwaysSendClientClaims = true,
                    AlwaysIncludeUserClaimsInIdToken = true,
                    AllowAccessTokensViaBrowser = true,
                    RedirectUris = { "https://localhost:44312/swagger/oauth2-redirect.html" },
                    AllowedCorsOrigins = { "https://localhost:44312" }
                }
            };
    }
}
