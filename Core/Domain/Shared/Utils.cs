 
namespace Domain.Shared
{
    public class Utility
    {
        public static int HashCodeSalter(int baseCode)
        {
            return baseCode * Constants.HashCodeMultiplier;
        }
    }
}
