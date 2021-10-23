using MyToDoApp.DAL.Model;
using System;

namespace TestProject.Consts
{
    public static class Defaults
    {
        public static Book[] Books = new Book[]
        {
            new Book {ID = new Guid("8fc22b4c-ffed-4f5e-abe2-6bfe98a54c07"),
                      Title = "Book_1",
                      Author = "Author_1",
                      Description = "Test",
                      IsReaded = false
            }
        };
    }
}
