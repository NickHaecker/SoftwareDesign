using System;

namespace Lektion_04
{
    class Channel
    {
        public string channelName { get; set => null; }
        public Photo channelPhoto { get; set => null; }

        public Channel(string ChannelName, Photo ChannelPhoto)
        {
            channelName = ChannelName;
            channelPhoto = ChannelPhoto;
        }
    }
}
