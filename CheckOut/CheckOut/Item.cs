using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOut
{
    public class Item
    {
        public virtual string ProductCode { get; set; }

        public virtual double UnitPrice { get; set; }

        public virtual double OfferPrice { get; set; }

        public virtual short OfferQty { get; set; }
    }

   
    
}
