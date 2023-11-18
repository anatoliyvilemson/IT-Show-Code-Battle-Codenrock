namespace Test
{
    public class Tests
    {
        [Test]
        public void ChekingDetermineCondition()
        {
            var chek = new GameOver();
            var input = "R:Тедди| 4 18:12 - 6 19:32, 17 13:12 - 20 14:42" +
                "R:Долорес| 12 14:12 - 12 18:15" +
                "R:Мейв| 13 9:21 - 13 21:23, 14 7:23 - 15 12:12 , 17 18:00 - 19 23:22, 22 20:25 - 26 15:14" +
                "R:Питер| 8 9:05 - 10 4:55" +
                "R:Клементина| 15 4:00 - 16 14:43" +
                "T:8 14:21" +
                "T:17 19:17";
            var example = chek.DetermineCondition(input);

            Assert.That(example, Is.EqualTo("8 14:21" +
                "Тедди GAME CONTINUES" +
                "Долорес GAME CONTINUES" +
                "Мейв GAME CONTINUES" +
                "Питер GAME OVER" +
                "Клементина GAME CONTINUES" +
                "17 19:17" +
                "Тедди GAME OVER" +
                "Долорес GAME CONTINUES" +
                "Мейв GAME OVER" +
                "Питер GAME CONTINUES" +
                "Клементина GAME CONTINUES"));
        }
    }
}