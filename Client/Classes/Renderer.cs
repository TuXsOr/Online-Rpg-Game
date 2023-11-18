using Client.Classes;
using System.Diagnostics;

namespace Game.Classes
{
    internal class Renderer
    {
        GlobalManager globalManager;
        public ImageList art;

        public Renderer(GlobalManager inManager)
        {
            globalManager = inManager;
            art = new ImageList();
            CacheImages();
        }

        public Image? GetImage(string imageName)
        {
            int imageIndex = art.Images.IndexOfKey(imageName);
            if (imageIndex >= 0)
            {
                return art.Images[imageIndex];
            }
            else { return null; }
        }

        public void CacheImages()
        {
            string filepath = $"{Directory.GetCurrentDirectory()}\\Art";
            string[] files = Directory.GetFiles(filepath);

            for (int i = 0; i < files.Length; i++)
            {
                Bitmap image = new Bitmap(files[i]);
                string filename = Path.GetFileNameWithoutExtension(files[i]);

                art.Images.Add(filename, image);

                Debug.WriteLine($"Loaded {filename}");
            }
        }
    }
}
