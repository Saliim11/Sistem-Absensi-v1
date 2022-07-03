using Sistem_Absensi_v1;
using System.Diagnostics;

namespace TestPanji
{
    [TestClass]
    public class UnitTest1
    {
        UserConfig UC = new UserConfig();

        [TestMethod]
        public void TestFileJSON()
        {
            Debug.Equals(UC.fullPath, "C:/Users/Panji/Documents/VS Community things/UNTUK UTS/Sistem-Absensi-v1-Panji/Sistem Absensi v1/users.json");
        }
    }
}