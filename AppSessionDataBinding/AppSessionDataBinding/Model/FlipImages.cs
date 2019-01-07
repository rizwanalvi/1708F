using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSessionDataBinding.Model
{
 public class FlipImages
    {
        private List<FlipImages> _flipimages = null;
        public FlipImages() {

            _flipimages = new List<FlipImages>();
        }
        
        public String ImagePath { get; set; }
        public String ImageTitle { get; set; }

        public List<FlipImages> GetImages() {
         
            _flipimages.Add(new FlipImages { ImagePath = "assets/lamborghini-centenario-lp770-4-1000.jpg" ,ImageTitle= "Lamborghini" });
            _flipimages.Add(new FlipImages { ImagePath = "assets/thumb_bmw-e90-on-z-performance-wheels.jpg", ImageTitle = "BMW E90" });
            _flipimages.Add(new FlipImages { ImagePath = "assets/thumb_fenyr-supersport.jpg", ImageTitle = "fenyr" });

            return _flipimages;
        }
    }
}
