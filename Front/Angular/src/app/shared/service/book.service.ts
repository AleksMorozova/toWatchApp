import { Book } from "../model/Book.model";
import { Injectable } from "@angular/core";
import { Observable, of } from "rxjs";
import { HttpClient, HttpHeaders } from "@angular/common/http";

@Injectable({
    providedIn: 'root',
})
export class BookService {
    
    private static httpOptions = {
        headers: new HttpHeaders({ 'Content-Type': 'application/json' })
    };

    constructor(protected http: HttpClient) {
    }
    
    public loadBooks(): Observable<any> {
        return this.http.get(`http://localhost:5000/msg`);
    }

    public updateBook(book: Book): any {
        return this.http.post<any>('https://localhost:44308/Books/update', JSON.stringify(book), BookService.httpOptions).toPromise();
    }

    public batchUpdateBooks(books: Book[]): any {
        return this.http.post<any>('https://localhost:44308/Books/bulkUpdate', JSON.stringify(books), BookService.httpOptions).toPromise();
    }
    
    public addBook(book: Book): any {
    }
}