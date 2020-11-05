using System;
using System.Collections.Generic;

namespace DesignPatterns
{
    class Uploader : IUser
    {
        public Channel uploaderChannel { get; set; }
        public List<Video> uploadedVideos { get; set; }

        public Uploader(Channel UploaderChannel, List<Video> UplaodedVideos)
        {
            uploaderChannel = UploaderChannel;
            uploadedVideos = UplaodedVideos;
        }

        public void uploadVideo()
        {

        }

        public void playVideo()
        {

        }

        public void createChannel()
        {

        }

        public void addVideoToChannel(Video video, Channel channel)
        {

        }

        public void uploadPhotoToChannel(APhoto channelPhoto)
        {

        }
    }
}
