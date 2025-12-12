using ImageMagick;

namespace ABHeicConverter
{
    public class ImageProcessing
    {

        public ImageProcessing() { }


        public string ProcessImage(string dirname, string imageName) 
        {

            using var image = new MagickImage(imageName);
            string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(imageName);
            string newFileName = Path.Combine(dirname, fileNameWithoutExtension + ".jpg");
            image.Format = MagickFormat.Jpg;
            image.Quality = 90;
            image.Write(newFileName);
            return newFileName;
        }
    }
}
