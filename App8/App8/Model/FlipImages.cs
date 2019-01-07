using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App8.Model
{
  public  class FlipImages
    {
        private List<FlipImages> _flipImg = null;
        public String ImagePath { get; set; }
        public String ImageTitle { get; set; }
        public String  CarPrice { get; set; }

        public List<FlipImages> GetImages() {
            _flipImg = new List<FlipImages>();
            _flipImg.Add(new FlipImages {ImagePath= "assets/ford-gt-supercar-984.jpg",ImageTitle= "Ford GT Supercar" , CarPrice= "500" });
            _flipImg.Add(new FlipImages { ImagePath = "assets/lamborghini-centenario-lp770-4-1000.jpg", ImageTitle = "lamborghini", CarPrice = "1000" });
            _flipImg.Add(new FlipImages { ImagePath = "assets/thumb_ford-mustang-shelby-gt500.jpg", ImageTitle = "Mustang" , CarPrice = "3000" });

            return _flipImg;
        }

    }
}
