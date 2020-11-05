using System;
using System.Collections;
namespace DesignPatterns
{
    class User : IUser
    {
        public void playVideo()
        {
            Video video = new Video("video", 200, 250, "4:3");
            VideoPlayer player = VideoPlayer.getVideoPlayer();
            player.playVideo(video);
        }
    }
}
