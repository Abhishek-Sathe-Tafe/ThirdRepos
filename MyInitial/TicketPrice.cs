using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ticketing
{
    public class TicketPrice
    {
        private int section;
        private int quantity;
        private bool discount;
        private bool discountC;
        private decimal amountDue;
        private decimal mPrice;

        const decimal mdecBalcony = 35.5m;
        const decimal mdecGeneral = 28.75m;
        const decimal mdecBox = 62.0m;
        const decimal mdecDiscount = 5.0m;
        const decimal mdecDiscountC = 10.0m;
        const decimal mdecBack = 15.0m;
        //
        private int Section
        {
            get { return section; }
            set { section = value; }
        }

         private int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

         private bool Discount
        {
            get { return discount; }
            set { discount = value; }
        }
        private bool DiscountC
        {
            get { return discountC; }
            set { discountC = value; }
        }
        public decimal AmountDue
        {
            get { return amountDue; }
            set { amountDue = value; }
        }

    // Constructor for TcicketPrice
    public TicketPrice(int section, int quantity, bool discount, bool discountC)
    {
        Section = section;
        Quantity = quantity;
        Discount = discount;
        DiscountC = discountC;
        AmountDue = amountDue;
    }

     public void calculatePrice()
     {

         switch (section)
         {
             case 1:
                 mPrice = mdecBalcony;
                 break;
             case 2:
                 mPrice = mdecGeneral;
                 break;
             case 3:
                 mPrice = mdecBox;
                 break;
            case 4:
                mPrice = mdecBack;
                break;
            }
         if (discount)
         { mPrice -= mdecDiscount; }

        if (discountC)
        { mPrice -= mdecDiscountC; }

            AmountDue = mPrice * quantity;

     }
    }
}
