using System;

namespace DesignPatterns
{
    class Channel
    {
        public string channelName { get; set; }
        public APhoto channelPhoto { get; set; }

        public Channel(string ChannelName, APhoto ChannelPhoto)
        {
            channelName = ChannelName;
            channelPhoto = ChannelPhoto;
        }
    }
}
