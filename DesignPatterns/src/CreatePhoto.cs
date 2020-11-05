using System;

namespace DesignPatterns
{
    class CreatePhoto
    {
        public static APhoto getPhoto(int Filesize, string Filename, int Photowidth, int Photoheight){
            if(Filesize <= 0 || Filename == null ||  Photowidth <= 0 || Photoheight <= 0 ){
                return new DefaultPhoto();
            }else{
                return new Photo(Filesize, Filename, Photowidth, Photoheight);
            }
        }
    }
}
