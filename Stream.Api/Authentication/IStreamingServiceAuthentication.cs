using System;
using System.Collections.Generic;
using System.Text;

namespace Stream.Api.Authentication
{
    public interface IStreamingServiceAuthentication
    {
        bool Authenticate(string configFilePath);
    }
}
