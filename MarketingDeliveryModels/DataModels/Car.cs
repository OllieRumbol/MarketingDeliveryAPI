using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketingDeliveryModels.DataModels
{
    public class Car
    {
        [Key]
        public Guid CarId { get; set; }

        public String Make { get; set; }

        public String  Model { get; set; }

        public String Colour { get; set; }
    }
}
