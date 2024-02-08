using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ДипломнаяРабота
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    static class data
    {
        public static string dolgnost;
        public static string nomerSotrydnika;
        public static int mode;
        public static int kod;
        public static string name;
    }

    static class statys
    {
        public static int kod;
        public static string kodZakaza;
        public static string dataZakaza;
        public static string Sbzakaza;
        public static string Statys;
        public static string KodKlienta;

    }
    static class prixod
    {
        public static int kolichestvo;
    }
    
}
