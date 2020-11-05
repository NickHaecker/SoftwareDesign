using System;

namespace Lektion_04
{
    class Photo
    {
        public int filesize { get; set => null; }
        public string filename { get; set => null; }
        public int photoWidth { get; set => null; }
        public int photoHeight { get; set => null; }

        public Photo(int Filesize, string Filename, int PhotoWidth, int PhotoHeight)
        {
            filesize = Filesize;
            filename = Filename;
            photoWidth = PhotoWidth;
            photoHeight = PhotoHeight;
        }
    }
}
