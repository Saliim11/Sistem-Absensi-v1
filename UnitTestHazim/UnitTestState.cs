using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sistem_Absensi_v1;

namespace UnitTestHazim
{
    [TestClass]
    public class UnitTestState
    {
        [TestMethod]
        public void TestStateAwal()
        {
            Assert.AreEqual(StateGuru.currentState, StateGuru.State.Keluar);
        }

        [TestMethod]
        public void TestKeluarToMasuk()
        {
            StateGuru.ActiveTrigger(StateGuru.Trigger.Check_in);

            Assert.AreEqual(StateGuru.currentState, StateGuru.State.Masuk);
        }

        [TestMethod]
        public void TestMasukToKeluar()
        {
            StateGuru.ActiveTrigger(StateGuru.Trigger.Check_in);
            StateGuru.ActiveTrigger(StateGuru.Trigger.Check_out);

            Assert.AreEqual(StateGuru.currentState, StateGuru.State.Keluar);
        }
    }
}