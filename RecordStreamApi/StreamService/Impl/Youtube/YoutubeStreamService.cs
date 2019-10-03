using System;
using System.IO;
using System.Threading;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;

namespace RecordStreamApi.StreamService.Impl.Youtube
{
    public class YoutubeStreamService
    {
        public async System.Threading.Tasks.Task<string> GetStreamKey()
        {
            try
            {
                UserCredential Credential;
                using (var fileStream = new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
                {
                    Credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                        GoogleClientSecrets.Load(fileStream).Secrets,
                        new[] { YouTubeService.Scope.Youtube },
                        "",
                        CancellationToken.None,
                        new FileDataStore(GetType().ToString())).ConfigureAwait(false);
                }


                if (Credential.Token.IsExpired(Credential.Flow.Clock))
                {
                    if (Credential.RefreshTokenAsync(CancellationToken.None).Result)
                    {
                        Console.WriteLine("Refresh token ok");
                    }
                    else
                    {
                        return null;
                    }
                }


                var service = new YouTubeService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = Credential,
                    ApplicationName = this.GetType().ToString()
                });


                var broadcast = new LiveBroadcast
                {
                    Kind = "youtube#liveBroadcast",
                    Snippet = new LiveBroadcastSnippet
                    {
                        Title = "AAA",
                        ScheduledStartTime = DateTime.Now
                    },
                    Status = new LiveBroadcastStatus { PrivacyStatus = "private" }
                };
                var request = service.LiveBroadcasts.Insert(broadcast, "id,snippet,status");
                var returnBroadcast = request.Execute();

                Console.Write(returnBroadcast);

                var stream = new LiveStream
                {
                    Kind = "youtube#liveStream",
                    Snippet = new LiveStreamSnippet
                    {
                        Title = "AAA"
                    },
                    Cdn = new CdnSettings
                    {
                        Format = "1080p",
                        IngestionType = "rtmp"
                    }
                };

                var liveStreamInsert = service.LiveStreams.Insert(stream, "snippet,cdn");
                var returnStream = liveStreamInsert.Execute();

                var broadcastBind = service.LiveBroadcasts.Bind(returnBroadcast.Id, "id,contentDetails");
                broadcastBind.StreamId = returnStream.Id;
                returnBroadcast = broadcastBind.Execute();

                Console.WriteLine(returnStream);
                Console.WriteLine(returnBroadcast);

                return returnStream.Cdn.IngestionInfo.StreamName;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return null;
        }
    }
}
