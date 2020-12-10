using NUnit.Framework;

namespace MumblingKata.Test
{
    public class Tests
    {
        private Mumble mumble;

        [SetUp]
        public void Setup()
        {
            mumble = new Mumble();
        }

        [Test]
        public void TestA()
        {
            Assert.AreEqual("A", mumble.mumble_letters("a"));
        }

        [Test]
        public void TestAbc()
        {
            Assert.AreEqual("A-Bb-Ccc", mumble.mumble_letters("abC"));
        }

        [Test]
        public void TestQWERTY()
        {
            Assert.AreEqual("Q-Ww-Eee-Rrrr-Ttttt-Yyyyyy", mumble.mumble_letters("QWERTY"));
        }

        [Test]
        public void TestEmptyString()
        {
            Assert.AreEqual("", mumble.mumble_letters(""));
        }
    }
}