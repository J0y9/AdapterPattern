

using AdapterPattern;

OldPaymentProcessing oldPayment = new OldPaymentProcessing();

INewPaymentProcessing adapter = new OldPaymentProcessingAdapter(oldPayment);
adapter.ProcessPayment();