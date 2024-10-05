import { Component } from '@angular/core';
import { Movie } from '../../shared/model/Movie.model';
import { Router, ActivatedRoute } from '@angular/router';
import { Observable } from 'rxjs';
import { MovieService } from 'src/app/shared/service/movie.service';

@Component({
  selector: 'app-movies',
  templateUrl: './movies.component.html'
})
export class MoviesComponent {
  movies: Movie[];
  myData$: Observable<any>;

  constructor(private router: Router,
              private route: ActivatedRoute,
              private movieService: MovieService) {
  }

  ngOnInit() {
    this.myData$ = this.movieService.loadMovies();
  }

  public watchMovie(movie: Movie): void {
    //this.movieService.watchMovie(movie);
  }

  public reWatchMovie(movie: Movie): void {
    // this.movieService.reWatchMovie(movie);
  }

  public addToFavorite(movie: Movie): void {
    //this.movieService.watchMovie(movie);
  }

  public addMovie(): void {
    this.router.navigate(['addMovie'], { relativeTo: this.route });
  }

  
  public save(): void {
    //this.movieService.batchUpdateMovies(this.movies);
  }
}