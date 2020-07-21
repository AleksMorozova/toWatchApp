import { Component } from '@angular/core';
import { Book } from './../shared/model/Book.model';
import { BooksService } from './../shared/service/books.service';
import { Router, ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-read',
  templateUrl: './read.component.html'
})
export class ReadComponent {
  books: Book[];

  constructor(private router: Router,
              private route: ActivatedRoute,
              private booksService: BooksService) {
  }

  ngOnInit() {
    this.booksService.loadBooks().then(res => {
      this.books = res;
    });
  }

  public readBook(book: Book): void {
    this.booksService.updateBook(book);
  }

  public updateBooks(): void {
    this.booksService.batchUpdateBooks(this.books);
  }

  public addBook(): void {
    this.router.navigate(['addBook'], { relativeTo: this.route });
  }

  public addToFavorite(book: Book): void {
    this.booksService.updateBook(book);
  }
}
