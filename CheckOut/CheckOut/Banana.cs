using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOut
{
    public class Banana : Item
    {
        private const double _Price = 0.7;
        private const double _OfferPrice = 1.0;
        private const short _OfferQty = 2;
        private const string _ProductCode = "Bananas";

        public override double UnitPrice
        {
            get { return _Price; }
        }

        public override string ProductCode
        {
            get { return _ProductCode; }
        }

        public override double OfferPrice
        {
            get { return _OfferPrice; }
        }


        public override short OfferQty
        {
            get { return _OfferQty; }
        }

    }
}
