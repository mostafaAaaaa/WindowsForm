using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using WinProject.IRepositories;
using WinProject.Repositories;

namespace WinProject
{
    public partial class BookListFRM : Form
    {
        private readonly IBookRepository repositoy;
        public BookListFRM()
        {
            InitializeComponent();
            repositoy = new BookRepositoy();
        }


        private void BookListFRM_Load(object sender, EventArgs e)
        {
            //GetAll();

            BooklistGv.DataSource = repositoy.GetAllByProcedure();
        }
    }
}
