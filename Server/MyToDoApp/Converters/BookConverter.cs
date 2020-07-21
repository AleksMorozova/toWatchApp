using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyToDoApp.Converters
{
    public static class BookConverter
    {
        public static MyToDoApp.Model.Book convertFromDTO(EF.Model.Book book)
        {
            MyToDoApp.Model.Book b = new MyToDoApp.Model.Book();
            b.Title = book.Title;
            b.Description = book.Description;
            b.Author = book.Author;
            b.ID = book.ID;
            b.IsReaded = book.IsReaded;
            return b;
        }
        public static EF.Model.Book convertToDTO(MyToDoApp.Model.Book book)
        {
            EF.Model.Book b = new EF.Model.Book();
            b.Title = book.Title;
            b.Description = book.Description;
            b.Author = book.Author;
            b.ID = book.ID;
            b.IsReaded = book.IsReaded;
            return b;
        }
    }
}
