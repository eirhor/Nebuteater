using Nebuteater.Models.Enums;

namespace Nebuteater.Web.Extensions
{
    public static class PaymentMethodsExtensions
    {
        public static string GetPaymentMethodString(this PaymentMethods paymentMethod)
        {
            switch (paymentMethod)
            {
                case PaymentMethods.Kontant:
                    return "Kontant";

                case PaymentMethods.KontantOgTerminal:
                    return "Kontant og bankterminal";

                case PaymentMethods.Terminal:
                    return "Bankterminal";

                default:
                    return "Ikke definert";
            }
        }
    }
}