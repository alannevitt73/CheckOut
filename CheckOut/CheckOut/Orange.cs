using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOut
{
    public class Orange : Item
    {
        private const double _Price = 0.45;
        private const double _OfferPrice = 0.9;
        private const short _OfferQty = 3;
        private const string _ProductCode = "Oranges";

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
