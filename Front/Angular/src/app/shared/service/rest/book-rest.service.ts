import { Injectable } from '@angular/core';
import { Book } from '../../model/Book.model';
import { HttpClient, HttpErrorResponse, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class BookRESTService {
    private static httpOptions = {
        headers: new HttpHeaders({ 'Content-Type': 'application/json' })
    };

    constructor(protected http: HttpClient) {
    }
    
    loadActive() : Observable<any> {
        return this.http.get(`http://localhost:5000/msg`);
    }

    public add (_book: Book): any {
    }

    public update(book: Book): any {
        return this.http.post<any>('https://localhost:44308/Books/update', JSON.stringify(book), BookRESTService.httpOptions).toPromise();
    }

    public batchUpdate(books: Book[]): any {
        return this.http.post<any>('https://localhost:44308/Books/bulkUpdate', JSON.stringify(books), BookRESTService.httpOptions).toPromise();
    }
}