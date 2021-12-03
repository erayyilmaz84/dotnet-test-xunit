namespace TickTack.Service
{
    public class TickTackService
    {
        public string print(int n)
        {
            if (dividedByThree(n) && dividedByFive(n))
                return "TickTack";
            else if (dividedByThree(n))
                return "Tick";
            else if (dividedByFive(n))
                return "Tack";
            else
                return n.ToString();
        }

        private bool dividedByThree(int n){
            return n % 3 == 0;
        }
        
        private bool dividedByFive(int n){
            return n % 5 == 0;
        }
    }
}
