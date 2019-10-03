using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Util.Store;
using Google.Apis.YouTube.v3;

namespace RecordStreamApi.Authentication.Impl.Youtube
{
    public class YoutubeServiceAuthentication : IStreamingServiceAuthentication
    {

        private UserCredential Credential
        { get; set; }
        
        public bool Authenticate(String ConfigFilePath)
        {
            return DoAuthen(ConfigFilePath).Result;
        }

        private async Task<bool> DoAuthen(string ConfigFilePath)
        {
            using (var stream = new FileStream(ConfigFilePath, FileMode.Open, FileAccess.Read))
            {
                this.Credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    new[] { YouTubeService.Scope.Youtube },
                    "tuan.hust.cs", 
                    CancellationToken.None,
                    new FileDataStore(GetType().ToString())).ConfigureAwait(false);
            }

            if (Credential.Token.IsExpired(Credential.Flow.Clock))
            {
                if (Credential.RefreshTokenAsync(CancellationToken.None).Result)
                {
                    return true;
                } else
                {
                    return false;
                }
            } else
            {
                return true;
            }
        }
    }
}
