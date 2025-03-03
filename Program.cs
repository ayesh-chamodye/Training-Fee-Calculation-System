﻿using System;
using System.Windows.Forms;
using TrainingFeeCalculationSystem;
using TrainingFeeSystem;

namespace Training_Fee_Calculation_System
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
            //Application.Run(new login());
            Application.Run(new FeeCalculation());
        }
    }
}
