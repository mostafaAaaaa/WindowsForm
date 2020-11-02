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
    public partial class BookUpdateFRM : Form
    {
        private readonly IBookRepository _repository;
        public BookUpdateFRM()
        {
            InitializeComponent();
            _repository = new BookRepositoy();
        }

        private void BookUpdateFRM_Load(object sender, EventArgs e)
        {
            Book book = _repository.GetById(1);
        }
    }
}
