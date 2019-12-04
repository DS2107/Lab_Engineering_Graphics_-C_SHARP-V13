using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7_Animation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Timer myTimer = new Timer();
            myTimer.Tick += new EventHandler(TimerEventProcessor);

            // Sets the timer interval to 5 seconds.
            myTimer.Interval = 40;
            myTimer.Start();
        }

        private void TimerEventProcessor(object sender, EventArgs e)
        {
            
                myship3.Left += 1;
           
        } // TimerEventProcessor
    }
}
