import { Movie } from '../model/Movie.model';
import { Injectable } from '@angular/core';
import { MovieRESTService } from './rest/movie-rest.service';
import { Observable } from 'rxjs';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Injectable({
    providedIn: 'root',
  })
export class MovieService {
    private static httpOptions = {
        headers: new HttpHeaders({ 'Content-Type': 'application/json' })
    };

    constructor(protected http: HttpClient) {
    }

    loadMovies() : Observable<any> {
        return this.http.get(`https://localhost:44308/Movies/all`);
    }

    public addMovie(movie: Movie): any {
        return this.http.post<any>('https://localhost:44308/Movies/add', JSON.stringify(movie), MovieService.httpOptions).toPromise();
    }

    public batchUpdateMovies(movies: Movie[]): any {
        return this.http.post<any>('https://localhost:44308/Movies/bulkUpdate', JSON.stringify(movies), MovieService.httpOptions).toPromise();
    }

    public watchMovie(movie: Movie): any {
        return this.http.post<any>('https://localhost:44308/Movies/watch', JSON.stringify(movie), MovieService.httpOptions).toPromise();
    }

    public reWatchMovie(movie: Movie): any {
        return this.http.post<any>('https://localhost:44308/Movies/reWatch', JSON.stringify(movie), MovieService.httpOptions).toPromise();
    }

}