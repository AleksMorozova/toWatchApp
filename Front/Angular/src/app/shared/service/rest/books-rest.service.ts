import { Injectable } from '@angular/core';
import { Book } from './../../model/Book.model';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class BooksRESTService {
    private static httpOptions = {
        headers: new HttpHeaders({ 'Content-Type': 'application/json' })
    };

    constructor(protected http: HttpClient) {
    }

    public loadActive(): Promise<Book[]> {
        return new Promise<Book[]>((resolve, reject) => {
            this.http.get('https://localhost:44308/Books/toRead').subscribe((res: Book[]) => resolve(res));
        });
    }

    public insert (_book: Book): any {

    }

    public update(book: Book): any {
        return this.http.post<any>('https://localhost:44308/Books/update', JSON.stringify(book), BooksRESTService.httpOptions).toPromise();
    }

    public batchUpdate(books: Book[]): any {
        return this.http.post<any>('https://localhost:44308/Books/bulkUpdate', JSON.stringify(books), BooksRESTService.httpOptions).toPromise();
    }
}