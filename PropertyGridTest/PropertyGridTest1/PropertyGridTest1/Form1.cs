using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PropertyGridTest1
{
    public partial class Form1 : Form
    {
        private Line line = new Line();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            propertyGrid1.SelectedObject = line;
        }
    }
}
