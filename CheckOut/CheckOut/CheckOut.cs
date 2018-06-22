using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOut
{
    public class CheckOut : ICheckout
    {
        private List<Item> _Items = new List<Item>();

        public void Scan(Item item)
        {
            //add item to internal list
            _Items.Add(item);
        }

        public double Total()
        {
            var total = 0.0;
            //group the cart by product
            var groupedCart = _Items.GroupBy(x => x.ProductCode);

            //grouping the cart by item type allows for new product types to be added and totalled.
            foreach (var itemType in groupedCart)
            {
                //get the 1st item in group so we have prices, offers etc
                var itemDetails = itemType.First();

                
                if (itemDetails.OfferQty > 0 && itemDetails.OfferQty > 0)
                {
                    //total for items with offers
                    total += (itemType.Count() / itemDetails.OfferQty) * itemDetails.OfferPrice;

                    //total for #items not in offer price
                    total += (itemType.Count() % itemDetails.OfferQty) * itemDetails.UnitPrice;
                }
                else
                {
                    total += (itemType.Count()  * itemDetails.UnitPrice);
                }
                
            }

            //avoid precision problems, round to 2 dp.
            return Math.Round (total,2);
        }

        
    }
}
