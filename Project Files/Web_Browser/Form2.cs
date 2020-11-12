using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_Browser
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
            Load += new EventHandler(Form2_Load);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.BringToFront();
            this.TopMost = true;
            //this.ShowDialog();
            this.BringToFront();
        }
    }
}
