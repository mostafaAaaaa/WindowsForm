using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinProject
{
    public partial class dddd : Form
    {
        public dddd()
        {
            InitializeComponent();
            DialogResult dr = MessageBox.Show("آیا شما میخواهید کاربر را حذف کنید؟",
                      "حذف کردن کاربر", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    break;
                case DialogResult.No:
                    break;
            }
        }
    }
}
