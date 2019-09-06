using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TextPoint
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestWordCountInZeroCount()
        {
            WordCount w = new WordCount();
            Assert.AreEqual(0, w.CountWordsIn(""));
            Assert.AreEqual(0, w.CountWordsIn(null));
        }

        [TestMethod]
        public void TestWordCountInOneCount()
        {
            WordCount w = new WordCount();
            Assert.AreEqual(1, w.CountWordsIn("Hello "));
            Assert.AreEqual(1, w.CountWordsIn("H"));
        }

        [TestMethod]
        public void TestWordCountInMoreThanOneCount()
        {
            WordCount w = new WordCount();
            Assert.AreEqual(2, w.CountWordsIn("Hello, World!"));
            Assert.AreEqual(5, w.CountWordsIn("Hello I dont know anything"));
        }
    }
}
