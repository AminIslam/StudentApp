using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentLayerApp.UI
{
    public partial class ShowDefaultParam : Form
    {
        public ShowDefaultParam()
        {
            InitializeComponent();
        }

        private void btnDefaultParam_Click(object sender, EventArgs e)
        {
            int a = 20;
            int b = 30;

            //txtDefaultParam.Text = Add(a: 7).ToString();
            DateTime myDate = Convert.ToDateTime(dtmpDefault.Text);

            txtDefaultParam.Text = myDate.ToString();
        }

        private int Add(int a=1, int b=2)
        {
            return a + b;
        }
    }
}
