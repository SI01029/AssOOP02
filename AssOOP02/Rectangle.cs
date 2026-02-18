using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace AssOOP02
{
    internal struct Rectangle
    {
        #region Attributes
        private Double height;
        private Double width; 
        #endregion

        #region Constructor
        public Rectangle()
        {
            width = 0;
            height = 0;
        }

        #endregion

        #region Width
        public Double Width
        {
            get { return width; }
            set
            {
                if (value >= 0)
                    width = value;

                else
                    width = value;
                Console.WriteLine("Width cannot be negative :(");
            }
        } 
        #endregion

        #region Height
        public Double Height
        {
            get { return height; }
            set
            {
                if (value >= 0)
                    height = value;

                else
                    height = value;
                Console.WriteLine("Height cannot be negative :(");
            }
        } 
        #endregion


        #region Area
        bool isvalid;
        private Double Area
        {
            get
            {
                if (width >= 0 && height >= 0)
                    return width * height;
                else
                    isvalid = false;
                    return 0;
                    
            }

        }

        #endregion


        #region DisplayInfo
        public void DisblayInfo()
        {
            Console.WriteLine($"Height : {height}");
            Console.WriteLine($"Width : {width}");
             if (isvalid==false)
                    Console.WriteLine("invalid Area :(");
            else
                Console.WriteLine($"Area : {Area}");
        } 
        #endregion









    }
}
