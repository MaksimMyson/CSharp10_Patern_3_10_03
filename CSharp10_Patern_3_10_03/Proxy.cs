using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp10_Patern_3_10_03
{
    interface IImage
    {
        void Display();
    }

    
    class RealImage : IImage
    {
        private string filename;

        public RealImage(string filename)
        {
            this.filename = filename;
            LoadImageFromDisk();
        }

        private void LoadImageFromDisk()
        {
            Console.WriteLine($"Завантаження зображення {filename} з диска");
        }

        public void Display()
        {
            Console.WriteLine($"Відображення зображення {filename}");
        }
    }

    
    class ProxyImage : IImage
    {
        private RealImage realImage;
        private string filename;

        public ProxyImage(string filename)
        {
            this.filename = filename;
        }

        public void Display()
        {
            if (realImage == null)
            {
                realImage = new RealImage(filename);
            }
            realImage.Display();
        }
    }
}
