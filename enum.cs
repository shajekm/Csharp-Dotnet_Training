namespace Enumerations
{
    public enum OrderStatus
    {
        Pending,
        Processing,
        Completed,
        Cancelled
    }

    // an enum called Day with values Monday to Sunday
    enum Day
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
    enum Month3
    {
        Jan = 1,
        Feb = 2,
        March = 3,
        April = 4
    }

    [Flags]
    enum BitwiseOrdSts
    {
        None = 0,
        Pending = 1,
        Processing = 2,
        Completed = 4,
        Cancelled = 8
    }


}

