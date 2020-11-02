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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BookListMenuItem_Click(object sender, EventArgs e)
        {
            BookListFRM FRM = new BookListFRM();
            FRM.Show();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }

        private void InsertBookMenuItem_Click(object sender, EventArgs e)
        {
            BookInsertFRM FRM = BookInsertFRM.CreateInstance();
            FRM.Show();
        }

        private void UpdateBookMenuItem_Click(object sender, EventArgs e)
        {
            BookUpdateFRM FRM = new BookUpdateFRM();
            FRM.Show();
        }
    }
}
