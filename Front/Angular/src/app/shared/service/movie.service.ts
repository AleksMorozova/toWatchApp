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
        movie.isWatched = true;
        return this.moviesRESTService.update(movie);
    }

    public addMovie(movie: Movie): void {
        movie.isWatched = false;
        this.moviesRESTService.insert(movie);
    }

    public batchUpdateMovies(movies: Movie[]): any {
        return this.moviesRESTService.batchUpdate(movies);
    }
}