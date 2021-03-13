using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoolPaint
{
    public partial class FormMain : Form
    {
        private Pen _pen;
        public FormMain()
        {
            InitializeComponent();w
        }

        private void PickColor(Object sender, EventArgs e)
        {
            var tsb = sender as ToolStripButton;
            colorDialog.Color = tsb.BackColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                tsb.BackColor = colorDialog.Color;
            }
        }
    }
}