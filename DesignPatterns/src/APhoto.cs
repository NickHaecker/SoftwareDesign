public abstract class APhoto{
     private int filesize;
       private string filename;
        private int photoWidth;
        private int photoHeight;

        protected APhoto(int Filesize, string Filename, int PhotoWidth, int PhotoHeight){
            filesize = Filesize;
            filename = Filename;
            photoWidth = PhotoWidth;
            photoHeight = PhotoHeight;
        }
}