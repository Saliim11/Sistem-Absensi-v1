using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Absensi_v1
{
    public class StateGuru
    {
        public enum State {Masuk, Keluar}

        public enum Trigger {Login, Logout}

        public static State currentState = State.Keluar;
    }
}
