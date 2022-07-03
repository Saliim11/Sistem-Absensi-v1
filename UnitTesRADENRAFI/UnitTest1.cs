using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using sistem_absensi;

namespace UnitTesRADENRAFI
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string passwordGuru = "123456789";
            Assert.IsFalse(sistem_absensi.Controllers.GuruController.cekPassword(passwordGuru));

            string passwordSiswa = "3243253";
            Assert.IsFalse(sistem_absensi.Controllers.SiswaController.cekPassword(passwordSiswa));
        }
    }
}