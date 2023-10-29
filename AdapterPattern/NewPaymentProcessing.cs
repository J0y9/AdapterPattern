using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class OldPaymentProcessingAdapter : INewPaymentProcessing
    {
        private readonly OldPaymentProcessing _oldPayment;

        public OldPaymentProcessingAdapter(OldPaymentProcessing oldPayment)
        {
            _oldPayment = oldPayment;
        }
        public void ProcessPayment()
        {
            Console.WriteLine("Calling the old process from the new one");
            _oldPayment.PaymentProcessing();
        }
    }
}
