import { Component } from '@angular/core';
import { FormGroup, FormBuilder } from '@angular/forms';
import { Router } from '@angular/router';
import { Movie } from '../../../shared/model/Movie.model';
import { MovieService } from './../../../shared/service/movie.service';

@Component({
    selector: 'app-movie-editot',
    templateUrl: 'movie-editor.component.html'
})
export class MovieEditorComponent {

    public movie: Movie = new Movie();
    public avatarUrl: string;
    public movieForm: FormGroup;
    public showItemEditor = false;

    constructor(private formBuilder: FormBuilder,
                private router: Router,
                private movieService: MovieService) {
    }

    ngOnInit() {
        this.initForm();
    }

    initForm() {
        this.movieForm = this.formBuilder.group({
            title: [this.movie.title],
            link: [this.movie.link],
            description: [this.movie.description]
        });
    }

    public apply(movie: Movie): void {
        this.movieService.addMovie(this.movie);
        this.router.navigate(['watch']);
    }
}

