using System.Data;

namespace Test
{
    public class Tests
    {
        [Test]
        public void ChekingEncryption()
        {
            var chek = new Alphabet();
            var input = "something: MR Robot";
            var example = chek.Encryption(input);

            Assert.That(example, Is.EqualTo("13,18,18,15,2,15,20"));
        }
    }
}