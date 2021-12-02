namespace TickTack.Service
{
    public class TickTackService
    {
        public string TickTack(int i)
        {
            if (i % 15 == 0)
                return "TickTack";
            else if (i % 3 == 0)
                return "Tick";
            else if (i % 5 == 0)
                return "Tack";
            else
                return i.ToString();
        }

    }
}
