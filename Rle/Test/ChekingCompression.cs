namespace Test
{
    public class Tests
    {
        [Test]
        public void ChekingCompression()
        {
            var chek = new Rle();
            var input = "something: DDDDHHHHkHK";
            var example = chek.Compression(input);

            Assert.That(example, Is.Not.EqualTo("4D,5H,1k,1K"));
            Assert.That(example, Is.Not.EqualTo("4D,4H,2K,1H"));
            Assert.That(example, Is.EqualTo("4D,4H,1k,1H,1K"));

        }
    }
}