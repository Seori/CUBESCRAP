using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CUBESCRAP
{
    public partial class ScrapForm : Form
    {
        private string _version = "0.0.1";

        public ScrapForm()
        {
            InitializeComponent();
        }

        private void ScrapForm_Load(object sender, EventArgs e)
        {
            this.Text = "yscube Scraping - " + _version;
        }
    }
}
