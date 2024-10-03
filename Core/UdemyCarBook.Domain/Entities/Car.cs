using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Domain.Entities.Enums;


namespace UdemyCarBook.Domain.Entities
{
    public class Car
    {
        public int BrandID { get; set; }
        public string CarID { get; set; }
        public Brand Brand { get; set; }
        public string Model { get; set; }
        public string CoverImageUrl { get; set; }
        public int Km { get; set; }
        //public string Transmission { get; set; }    //enum olarak ayarla
        public TransmissionType Transmission { get; set; }
        public byte Seat { get; set; }
        public byte Luggage { get; set; }
        public string Fuel { get; set; }
        public string BigImageUrl { get; set; }

        public List<CarFeature> CarFeatures { get; set; }

        public List<CarDescription> CarDescriptions { get; set; }

        public List<CarPricing> CarPricings { get; set; }






    }
}
