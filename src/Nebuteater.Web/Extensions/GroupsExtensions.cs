using Nebuteater.Models.Enums;

namespace Nebuteater.Web.Extensions
{
    public static class GroupsExtensions
    {
        public static string GetGroupString(this Groups group)
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