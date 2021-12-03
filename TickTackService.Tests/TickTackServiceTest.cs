using Xunit;
using TickTack.Service;
namespace TickTack.ServiceTests
{
    public class TickTackServiceTest
    {
        TickTackService tickTackService;

        public TickTackServiceTest()
        {
            tickTackService = new TickTackService();
        }


        [Fact]
        public void shouldReturnTick()
        {
            Assert.Equal(tickTackService.print(96), "Tick");
            Assert.Equal(tickTackService.print(99), "Tick");
            Assert.Equal(tickTackService.print(102), "Tick");
        }

        [Fact]
        public void shouldReturnTack()
        {
            Assert.Equal(tickTackService.print(95), "Tack");
            Assert.Equal(tickTackService.print(100), "Tack");
        }

        [Fact]
        public void shouldReturnTickTack()
        {
            Assert.Equal(tickTackService.print(90), "TickTack");
            Assert.Equal(tickTackService.print(105), "TickTack");
        }

        [Fact]
        public void shouldReturnNumber()
        {
            Assert.Equal(tickTackService.print(106), "106");
            Assert.Equal(tickTackService.print(107), "107");
        }

    }
}