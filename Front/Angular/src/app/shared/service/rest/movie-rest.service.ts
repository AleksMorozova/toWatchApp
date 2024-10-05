import { Injectable } from '@angular/core';
import { Movie } from './../../model/Movie.model';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class MovieRESTService {
    private static httpOptions = {
        headers: new HttpHeaders({ 'Content-Type': 'application/json' })
    };

    constructor(protected http: HttpClient) {
    }

    loadActive() : Observable<any> {
        return this.http.get(`https://localhost:44308/Movies/all`);
    }

    public add (movie: Movie): any {
        return this.http.post<any>('https://localhost:44308/Movies/add', JSON.stringify(movie), MovieRESTService.httpOptions).toPromise();
    }

    public watch(movie: Movie): any {
        return this.http.post<any>('https://localhost:44308/Movies/watch', JSON.stringify(movie), MovieRESTService.httpOptions).toPromise();
    }

    public reWatch(movie: Movie): any {
        return this.http.post<any>('https://localhost:44308/Movies/reWatch', JSON.stringify(movie), MovieRESTService.httpOptions).toPromise();
    }

    public batchUpdate(movies: Movie[]): any {
        return this.http.post<any>('https://localhost:44308/Movies/bulkUpdate', JSON.stringify(movies), MovieRESTService.httpOptions).toPromise();
    }
}