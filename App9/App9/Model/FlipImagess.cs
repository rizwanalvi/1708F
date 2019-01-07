using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App9.Model
{
  public  class FlipImagess
    {
        private List<FlipImagess> _img = null;
        public String ImagePath { get; set; }
        public String ImgTtile { get; set; }
        
        public List<FlipImagess> getImages() {
            _img = new List<FlipImagess>();
            _img.Add(new FlipImagess { ImgTtile= "Lili", ImagePath= "assets/lili.jpg" });
            _img.Add(new FlipImagess { ImgTtile = "Rose", ImagePath = "assets/rose.jpg" });
            _img.Add(new FlipImagess { ImgTtile = "SunFlower", ImagePath = "assets/sunflower.jpg" });
            return _img;
        }
    }
}
