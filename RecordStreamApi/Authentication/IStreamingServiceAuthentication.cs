namespace RecordStreamApi.Authentication
{
    public interface IStreamingServiceAuthentication
    {
        bool Authenticate(string configFilePath);
    }
}
