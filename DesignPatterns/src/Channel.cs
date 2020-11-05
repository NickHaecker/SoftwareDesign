using System;

namespace DesignPatterns
{
    class Channel
    {
        public string channelName { get; set; }
        public Photo channelPhoto { get; set; }

        public Channel(string ChannelName, Photo ChannelPhoto)
        {
            channelName = ChannelName;
            channelPhoto = ChannelPhoto;
        }
    }
}
