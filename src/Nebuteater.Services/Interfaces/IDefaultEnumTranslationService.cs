using Nebuteater.Models.Enums;

namespace Nebuteater.Services.Interfaces
{
    public interface IDefaultEnumTranslationService
    {
        string GetPaymentMethodString(PaymentMethods paymentMethod);
        string GetGroupString(Groups group);
    }
}