using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using MyToDoApp.Model;
using MyToDoApp.Repositories;

namespace MyToDoApp.Service
{
    public interface IBooksService {
        public List<Book> GetBooksToRead();
        public Task<Book> AddBookAsync(Book book);
        public Book ReadBook(Book book);
        public void BulkUpdate(List<Book> book);
    }

    public class BooksService: IBooksService
    {
        private readonly IBooksRepository _booksRepository;
        private readonly IMapper _mapper;

        public BooksService(IBooksRepository booksRepository, IMapper mapper)
        {
            _booksRepository = booksRepository;
            _mapper = mapper;
        }
        public List<Book> GetBooksToRead()
        {
            List<Book> books = new List<Book>();
            foreach (EF.Model.Book book in _booksRepository.GetAll())
            {
                books.Add(_mapper.Map<Book>(book));
            }
            return books;
        }
        public async Task<Book> AddBookAsync(Book book)
        {
            EF.Model.Book newBook = await _booksRepository.AddAsync(_mapper.Map<EF.Model.Book>(book));
            return _mapper.Map<Book>(newBook);
        }
        public Book ReadBook(Book book)
        {
            book.IsReaded = true;
            EF.Model.Book newBook = _mapper.Map<EF.Model.Book>(book);
            return _mapper.Map<Book>(_booksRepository.Update(newBook));
        }
        public void BulkUpdate(List<Book> book)
        {
            throw new NotImplementedException();
        }
    }
}
