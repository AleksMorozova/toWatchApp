import { Movie } from '../model/Movie.model';
import { Injectable } from '@angular/core';
import { MoviesRESTService } from './rest/movie-rest.service';

@Injectable()
export class MovieService {
    constructor(protected moviesRESTService: MoviesRESTService) {
    }

    public loadMovies(): Promise<Movie[]> {
        return new Promise<Movie[]>((resolve, reject) => {
            this.moviesRESTService.loadActive().then(res => {
                const movies = <Movie[]>res;
                if (movies) {
                    resolve(movies);
                } else {
                    reject();
                }
            });
        });
    }

    public watchMovie(movie: Movie): void {
        return this.moviesRESTService.watch(movie);
    }

    public reWatchMovie(movie: Movie): void {
        return this.moviesRESTService.reWatch(movie);
    }

    public addMovie(movie: Movie): void {
        this.moviesRESTService.insert(movie);
    }

    public batchUpdateMovies(movies: Movie[]): any {
        return this.moviesRESTService.batchUpdate(movies);
    }
}