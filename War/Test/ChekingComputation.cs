using System.Data;

namespace Test
{
    public class Tests
    {
        [Test]
        public void ChekingComputation()
        {
            var chek = new War();
            var input = "something: 9";
            var example = chek.Computation(input);

            Assert.That(example, Is.EqualTo("25"));

        }
    }
}