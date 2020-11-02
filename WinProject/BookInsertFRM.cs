using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinProject.IRepositories;
using WinProject.Models;
using WinProject.Repositories;

namespace WinProject
{
    public partial class BookInsertFRM : Form
    {
        private readonly IBookRepository _repository;

        private static BookInsertFRM FormInstance = null;
        private BookInsertFRM()
        {
            InitializeComponent();
            _repository = new BookRepositoy();
        }
        public static BookInsertFRM CreateInstance()
        {
            if (FormInstance==null)
            {
                FormInstance = new BookInsertFRM();
            }
            return FormInstance;
        }

        private void btnSaveBook_Click(object sender, EventArgs e)
        {
            Book book = new Book()
            {
                Name = txtName.Text,
                PageCount = Convert.ToInt32(txtPageCount.Text),
                Publisher = txtPublisher.Text
            };

            int result = _repository.Insert(book);
            if (result > 0)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Error");
            }

        }

        private void BookInsertFRM_FormClosed(object sender, FormClosedEventArgs e)
        {
            BookListFRM FRM = new BookListFRM();
            FRM.Show();
        }
    }
}
