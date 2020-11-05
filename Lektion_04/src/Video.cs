using System;

namespace Lektion_04
{
    class Video
    {
        public string videoTitle { get; set => null; }
        public int videoLengthinSecs { get; set => null; }
        public int videoSize { get; set => null; }
        public string videoAspectRatio { get; set => null; }
        public Video(string VideoTitle, int VideoLengthinSecs, int VideoSize, string VideoAspectRatio)
        {
            videoTitle = VideoTitle;
            videoLengthinSecs = VideoLengthinSecs;
            videoSize = VideoSize;
            videoAspectRatio = VideoAspectRatio;
        }

        public static void playVideo(this Video)
        {

        }
    }
}
