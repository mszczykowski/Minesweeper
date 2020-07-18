using System;
using System.Windows.Forms;

namespace Minesweeper
{
    static class Program
    {
        /// <summary>
        /// Minesweeper
        /// Projekt z przedmiotu Programowanie Obiektowe
        /// Michał Szczykowski 2020
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MinesweeperForm());
        }
    }
}
