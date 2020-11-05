using System;

namespace DesignPatterns
{
    class VideoPlayer
    {
        private static VideoPlayer videoplayer = new VideoPlayer();

        private VideoPlayer() { }

        public static VideoPlayer getVideoPlayer()
        {
            return videoplayer;
        }

        public void playVideo(Video video)
        {
            Console.WriteLine("play video" + video);
        }
    }
}
