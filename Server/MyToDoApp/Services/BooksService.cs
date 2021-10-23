using AutoMapper;
using MyToDoApp.DAL.Contracts;
using MyToDoApp.Model;
using MyToDoApp.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyToDoApp.Service
{
    public class BooksService: IBooksService
    {
        private readonly IBooksRepository _booksRepository;
        private readonly IMapper _mapper;

        public BooksService(IBooksRepository booksRepository, IMapper mapper)
        {
            _booksRepository = booksRepository;
            _mapper = mapper;
        }

        public async Task<Book> GetById(Guid id)
        {
            var book = await _booksRepository.GetById(id);
            return _mapper.Map<Book>(book);
        }

        public List<Book> GetAll()
        {
            var books = new List<Book>();
            foreach (DAL.Model.Book book in _booksRepository.GetAll())
            {
                books.Add(_mapper.Map<Book>(book));
            }
            return books;
        }
        public async Task<Book> Add(Book book)
        {
            var newBook = await _booksRepository.AddAsync(_mapper.Map<DAL.Model.Book>(book));
            return _mapper.Map<Book>(newBook);
        }
        public async Task<Book> ReadBook(Guid id)
        {
            var book = await _booksRepository.GetById(id);
            if (!book.IsReaded)
            {
                book.IsReaded = true;
            }
            return _mapper.Map<Book>(_booksRepository.Update(book));
        }
    }
}
