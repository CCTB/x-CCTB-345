using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Data.SqlClient;
using Book_Rental_System;
namespace Book_Rental_System
{
    static class Program
    {
        public static string cnstr;
        public static string help;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            cnstr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source='D:\\Book_Rental_System\\Book_Rental_System\\bin\\Debug\\Book.mdb'";
            help = "D:\\Book_Rental_System\\Book_Rental_System\\Book_Rental_System\\frame.html";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MDI());
            Application.Run(new Login());
        }
    }
}
