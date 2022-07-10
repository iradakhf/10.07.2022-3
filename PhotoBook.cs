using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    public class PhotoBook
    {
        protected int numPages;
        public  int GetNumberPages()
        {
            return numPages;
        }
        public PhotoBook()
        {
            numPages = 16;
        }
        public PhotoBook(int numPages)
        {
            this.numPages = numPages;
        }

    }
}
