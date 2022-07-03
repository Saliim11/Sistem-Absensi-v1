using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestSaliim
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(LibraryStatus.StateLogin.currentState, LibraryStatus.StateLogin.State.Online);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(LibraryStatus.StateLogin.currentState, LibraryStatus.StateLogin.State.Offline);
        }

        [TestMethod]
        public void TestMethod3()
        {
            LibraryStatus.StateLogin.activeTrigger(LibraryStatus.StateLogin.Trigger.Login);

            Assert.AreEqual(LibraryStatus.StateLogin.currentState, LibraryStatus.StateLogin.State.Online);
        }
    }
}