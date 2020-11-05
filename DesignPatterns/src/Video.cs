using System;

namespace DesignPatterns
{
    class Video
    {
        public string videoTitle { get; set; }
        public int videoLengthinSecs { get; set; }
        public int videoSize { get; set; }
        public string videoAspectRatio { get; set; }
        public Video(string VideoTitle, int VideoLengthinSecs, int VideoSize, string VideoAspectRatio)
        {
            videoTitle = VideoTitle;
            videoLengthinSecs = VideoLengthinSecs;
            videoSize = VideoSize;
            videoAspectRatio = VideoAspectRatio;
        }

        public static void playVideo(Video thisVideo)
        {
            VideoPlayer videoplayer = VideoPlayer.getVideoPlayer();
            videoplayer.playVideo(thisVideo);
        }
    }
}
