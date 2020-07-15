using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StatePatternTest3
{
    public partial class Form1 : Form
    {
        private MotionSyatem.MotionSystem motionSystem = new MotionSyatem.MotionSystem();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            motionSystem.ResetMachine();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            motionSystem.StartMachine();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            motionSystem.StopMachine();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            motionSystem.EMGStopMachine();
        }
    }
}
