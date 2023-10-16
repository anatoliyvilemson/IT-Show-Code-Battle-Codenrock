using System.Data;

namespace Test
{
    public class Tests
    {
        [Test]
        public void ChekingBreaking()
        {
            var chek = new BreakingDoor();
            var input = "something: 1,3,6,8";
            var example = chek.Breaking(input);

            Assert.That(example, Is.EqualTo("X0X00X0X\nX0X00X0X\nX0X00X0X\nXXXXXXXX"));

        }
    }
}