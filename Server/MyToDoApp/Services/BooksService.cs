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
        private IRateService _rateService;

        public BooksService(IBooksRepository booksRepository,
            IRateService rateService,
            IMapper mapper)
        {
            _booksRepository = booksRepository;
            _rateService = rateService;
            _mapper = mapper;
        }

        public async Task<Book> GetById(Guid id)
        {
            var book = await _booksRepository.GetById(id);
            var rate = await _rateService.GetRate();
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
        public async Task<Book> Add(CreateBook book)
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

        public Task<Book> Add(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
