using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinProject.Models;

namespace WinProject.IRepositories
{
    public interface IBookRepository
    {
        DataTable GetAll();
        DataTable GetAllByProcedure();
        Book GetById(int id);
        int Insert(Book book);
    }
}
