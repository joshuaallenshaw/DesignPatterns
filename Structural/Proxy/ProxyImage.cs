namespace Proxy
{
    /// <summary>
    /// The Proxy Subject Class.
    /// </summary>
    public class ProxyImage : IImage
    {
        private readonly string fileName;
        private RealImage realImage;

        public ProxyImage(string fileName)
        {
            this.fileName = fileName;
        }

        public void DisplayImage()
        {
            if (realImage == null)
            {
                realImage = new RealImage(fileName);
            }
            realImage.DisplayImage();
        }
    }
}