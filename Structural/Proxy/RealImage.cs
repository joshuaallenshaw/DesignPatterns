using System;

namespace Proxy
{
    /// <summary>
    /// The Real Subject Class.
    /// </summary>
    public class RealImage : IImage
    {
        private readonly string fileName;

        public RealImage(string fileName)
        {
            this.fileName = fileName;
            LoadImageFromFile();
        }

        public void DisplayImage()
        {
            Console.WriteLine("Displaying image {0}", fileName);
        }

        private void LoadImageFromFile()
        {
            Console.WriteLine("Load image from file {0}", fileName);
        }
    }
}