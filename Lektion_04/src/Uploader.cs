using System;
using System.Collections;
namespace Lektion_04
{
    class Uploader : RegisteredUser
    {
        public Channel uploaderChannel { get; set => null; }
        public ArrayList<Videos> uploadedVideos { get; set => null; }

        public Uploader(Channel UploaderChannel, ArrayList<Videos> UplaodedVideos)
        {
            uploaderChannel = UploaderChannel;
            uploadedVideos = UplaodedVideos;
        }

        public void uploadVideo()
        {

        }

        public void createChannel()
        {

        }

        public void addVideoToChannel(Video video, Channel channel)
        {

        }

        public void uploadPhotoToChannel(Photo channelPhoto)
        {

        }
    }
}
