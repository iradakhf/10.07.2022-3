using System;
namespace ConsoleApp23
{
   public  class Program
    {
        public static void Main(string[] args)
        {
            //PhotoBook photobook = new ();
            //Console.WriteLine(photobook.GetNumberPages());

            //PhotoBook photoB = new(15);
            //Console.WriteLine(photoB.GetNumberPages());

            BigPhotoBook bigPhotoBookPages = new();
            Console.WriteLine(bigPhotoBookPages.GetNumberPages()); 
            
        }
    }
}