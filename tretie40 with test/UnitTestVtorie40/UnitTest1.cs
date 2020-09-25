using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestTretie40
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsBool1AnswerCorrect()
        {
            bool ans = true;
            Assert.AreEqual(Tretie40.Program.Bool1(), ans);
        }
        [TestMethod]
        public void IsBool20AnswerCorrect()
        {
            bool ans = false;
            Assert.AreEqual(Tretie40.Program.Bool20(), ans);
        }
        [TestMethod]
        public void IsBool14AnswerCorrect()
        {
            bool ans = false;
            Assert.AreEqual(Tretie40.Program.Bool14(), ans);
        }
    }
}
