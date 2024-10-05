import { Component } from '@angular/core';
import { Book } from './../shared/model/Book.model';
import { BookService } from '../shared/service/book.service';
import { Router, ActivatedRoute } from '@angular/router';
import { Observable, of } from 'rxjs';

@Component({
  selector: 'app-read',
  templateUrl: './read.component.html'
})
export class ReadComponent {
  books$: Observable<any>;

  constructor(private router: Router,
              private route: ActivatedRoute,
              private bookService: BookService) {
  }

  ngOnInit() {
    console.log('TADA ');

    this.books$ = this.bookService.loadBooks();

    window.top.addEventListener('placeChangedIn', this.evenListener.bind(this), false);
  }

  public evenListener() {
    console.log('TADA even is fire from other component');
  }
  
  public readBook(book: Book): void {
    //this.bookService.updateBook(book);
  }

  public save(): void {
    //this.bookService.batchUpdateBooks(this.books);
  }

  public addBook(): void {
    this.router.navigate(['addBook'], { relativeTo: this.route });
  }

  public addToFavorite(book: Book): void {
    //this.bookService.updateBook(book);
  }
}
