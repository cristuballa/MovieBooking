using System.Drawing;
using System.IO;

namespace MovieBookingDesktop
{
    class ImageByteConverter
    {

        public  byte[] ImageToByte(Image img)
        {
       
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }

        public Image ByteToImage(byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                Image returnImage = (Bitmap)Image.FromStream(ms);
                return returnImage; 
            }
           
        }



    }
}
