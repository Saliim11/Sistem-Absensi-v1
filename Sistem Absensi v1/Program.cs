using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistem_Absensi_v1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


            
            StateLogin posisiuser = new StateLogin();
            Console.WriteLine(posisiuser.currentState);

            posisiuser.activeTrigger(StateLogin.Trigger.Logout);
            Console.Write("Posisi User : ");
            Console.Write(posisiuser.currentState + "\n ");

            Console.Write(posisiuser.currentState);
            posisiuser.activeTrigger(StateLogin.Trigger.Login);
            Console.Write("Posisi User : ");
            Console.Write(posisiuser.currentState);
        }
    }
}
