using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    internal class CreditCard
    {
        public string Name { get; }
        public string CardNumber { get; }
        public int Month { get; }
        public int Year { get; }
        public int Cv2 { get; }

        internal CreditCard(string name, string cardNumber, int month, int year, int cv2)
        {
            Name = name;
            CardNumber = cardNumber;
            Month = month;
            Year = year;
            Cv2 = cv2;
        }
    }
}
