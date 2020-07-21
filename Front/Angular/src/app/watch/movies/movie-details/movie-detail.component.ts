import { Component, OnInit, Input } from '@angular/core';
import { Movie } from '../../../shared/model/Movie.model';

@Component({
    selector: 'app-movie-brief-info',
    templateUrl: './movie-detail.component.html'
})
export class MovieDetailsComponent implements OnInit {
    @Input() public movie: Movie;
    constructor() {
    }

    ngOnInit() {
    }
}
