using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace ObservatoryAPI.BLL;

public class OrderExceprion:Exception
{
    public OrderExceprion(string message)
        :base(message)
    {
        
    }
}
