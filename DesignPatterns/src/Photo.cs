using System;

namespace DesignPatterns
{
    class Photo : APhoto
    {
        public Photo(int FileSize, string FileName, int PhotoWidth, int PhotoHeight) : base(FileSize, FileName, PhotoWidth, PhotoHeight) { }
    }
}
