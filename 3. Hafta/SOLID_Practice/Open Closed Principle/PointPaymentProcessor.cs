using OpenClosedPrinciple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    internal class PointPaymentProcessor : IPaymentProcessor
    {
        public Tuple<bool, string> ProcessPayment()
        {
            return Tuple.Create(true, "Ödemeniz başarılı şekilde tamamlanmıştır.");
        }
    }
}
