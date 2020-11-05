using System;

namespace DesignPatterns
{
    class Photo
    {
        public int filesize { get; set; }
        public string filename { get; set; }
        public int photoWidth { get; set; }
        public int photoHeight { get; set; }

        public Photo(int Filesize, string Filename, int PhotoWidth, int PhotoHeight)
        {
            filesize = Filesize;
            filename = Filename;
            photoWidth = PhotoWidth;
            photoHeight = PhotoHeight;
        }
    }
}
