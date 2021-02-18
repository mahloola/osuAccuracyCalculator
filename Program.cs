using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace osuAccuracyCalculator
{

    // Fetch replay object
    // Create separate function to calculate whether circle is a 300, 100, or 50. function returns value
    // Getting all hit-object 300 timepoints from the beatmap object,
    // e.g: 4:21:06 in the map folder is the time you need to hit a 300 on a circle, compare replay to see how far off the user hit the circle in ms.
    // Use the other OD time window to determine whether it would still be a 300


    static class Program
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
        }
    }
}
