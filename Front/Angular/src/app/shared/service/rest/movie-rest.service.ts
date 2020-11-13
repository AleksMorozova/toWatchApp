import { Injectable } from '@angular/core';
import { Movie } from './../../model/Movie.model';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Injectable({
  providedIn: 'root',
})
export class MoviesRESTService {
    private static httpOptions = {
        headers: new HttpHeaders({ 'Content-Type': 'application/json' })
    };

    constructor(protected http: HttpClient) {
    }

    public loadActive(): Promise<Movie[]> {
        return new Promise<Movie[]>((resolve, reject) => {
            this.http.get('https://localhost:44308/Movies/toWatch').subscribe((res: Movie[]) => resolve(res));
        });
    }

    public insert (movie: Movie): any {
        return this.http.post<any>('https://localhost:44308/Movies/add', JSON.stringify(movie), MoviesRESTService.httpOptions).toPromise();
    }

    public watch(movie: Movie): any {
        return this.http.post<any>('https://localhost:44308/Movies/watch', JSON.stringify(movie), MoviesRESTService.httpOptions).toPromise();
    }

    public reWatch(movie: Movie): any {
        return this.http.post<any>('https://localhost:44308/Movies/reWatch', JSON.stringify(movie), MoviesRESTService.httpOptions).toPromise();
    }

    public batchUpdate(movies: Movie[]): any {
        return this.http.post<any>('https://localhost:44308/Movies/bulkUpdate', JSON.stringify(movies), MoviesRESTService.httpOptions).toPromise();
    }
}