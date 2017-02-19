using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nebuteater.Services.Interfaces;
using Nebuteater.Models.Enums;

namespace Nebuteater.Services
{
    public class DefaultEnumTranslationService : IDefaultEnumTranslationService
    {
        public string GetPaymentMethodString(PaymentMethods paymentMethod)
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

        public string GetGroupString(Groups group)
        {
            switch (group)
            {
                    case Groups.GruppeA:
                        return "Gruppe A";

                    case Groups.GruppeB:
                        return "Gruppe B";

                default:
                    return "Ikke definert";
            }
        }
    }
}
