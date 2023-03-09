using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_Hometasks
{
    internal class CreditCard
    {
        public int cardNumber;
        public double cardBalance;

        public double AddSum(double sum)
        {
            return cardBalance += sum;
        }

        public double RemoveSum(double sum)
        {
            return cardBalance -= sum;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Card number is {cardNumber}, balance on the card is {cardBalance}.");
        }

        public CreditCard(int cardNumber, double cardBalance)
        {
            this.cardNumber = cardNumber;
            this.cardBalance = cardBalance;
        }
    }
}
