using Xunit;
using TickTack.Service;
namespace TickTack.ServiceTests
{
    public class TickTackServiceTest
    {
        [Fact]
        public void ordinalNumbers()
        {
            var service = new TickTackService();
            int i = 1;
            string result = service.TickTack(i);
            Assert.Equal(result, i.ToString());
        }

        
        [Fact]
        public void dividedByThree()
        {
            var service = new TickTackService();
            int i = 102;
            string result = service.TickTack(i);
            Assert.Equal(result,"Tick");
        }

    }
}