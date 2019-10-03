using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Captura;

namespace RecordStreamApi.StreamService
{
    public class StreamSettings : PropertyStore
    {
        public string BroadcastTitle
        {
            get => Get("");
            set => Set(value);
        }

        public string BroadcastStatus
        {
            get => Get("");
            set => Set(value);
        }

        public string LiveStreamType
        {
            get => Get("");
            set => Set(value);
        }

        public string CdnFormat
        {
            get => Get("");
            set => Set(value);
        }
    }
}
