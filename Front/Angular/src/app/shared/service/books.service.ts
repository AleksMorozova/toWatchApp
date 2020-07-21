import { Book } from "../model/Book.model";
import { Injectable } from "@angular/core";
import { BooksRESTService } from './rest/books-rest.service';

@Injectable({
    providedIn: 'root'
})
export class BooksService {

    constructor(protected booksRESTService: BooksRESTService) {
    }

    public loadBooks(): Promise<Book[]> {
        return new Promise<Book[]>((resolve, reject) => {
            this.booksRESTService.loadActive().then(res => {
                const books = <Book[]>res;
                if (books) {
                    resolve(books);
                } else {
                    reject();
                }
            });
        });
    }

    public updateBook(book: Book): any {
        return this.booksRESTService.update(book);
    }

    public batchUpdateBooks(books: Book[]): any {
        return this.booksRESTService.batchUpdate(books);
    }

    
    public addBook(book: Book): any {
        return this.booksRESTService.insert(book);
    }
}