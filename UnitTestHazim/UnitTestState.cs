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
            StateGuru TestStateGuru = new StateGuru();
            Assert.AreEqual(TestStateGuru.currentState, StateGuru.State.Keluar);
        }

        [TestMethod]
        public void TestKeluarToMasuk()
        {
            StateGuru TestStateGuru = new StateGuru();
            TestStateGuru.ActiveTrigger(StateGuru.Trigger.Login);
            Assert.AreEqual(TestStateGuru.currentState, StateGuru.State.Masuk);
        }

        [TestMethod]
        public void TestMasukToKeluar()
        {
            StateGuru TestStateGuru = new StateGuru();
            TestStateGuru.ActiveTrigger(StateGuru.Trigger.Login);
            TestStateGuru.ActiveTrigger(StateGuru.Trigger.Logout);
            Assert.AreEqual(TestStateGuru.currentState, StateGuru.State.Keluar);
        }
    }
}