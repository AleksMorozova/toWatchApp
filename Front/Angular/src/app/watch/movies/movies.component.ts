import { Component } from '@angular/core';
import { Movie } from '../../shared/model/Movie.model';
import { MovieService } from './../../shared/service/movie.service';
import { Router, ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-movies',
  templateUrl: './movies.component.html'
})
export class MoviesComponent {
  movies: Movie[];

  constructor(private router: Router,
                private route: ActivatedRoute,
    private movieService: MovieService) {
  }

  ngOnInit() {
    this.movieService.loadMovies().then(res => {
      this.movies = res;
    });
  }

  public watchMovie(movie: Movie): void {
    this.movieService.watchMovie(movie);
  }

  public reWatchMovie(movie: Movie): void {
    this.movieService.reWatchMovie(movie);
  }

  public addToFavorite(movie: Movie): void {
    this.movieService.watchMovie(movie);
  }

  public addMovie(): void {
    this.router.navigate(['addMovie'], { relativeTo: this.route });
  }

  
  public save(): void {
    this.movieService.batchUpdateMovies(this.movies);
  }
}