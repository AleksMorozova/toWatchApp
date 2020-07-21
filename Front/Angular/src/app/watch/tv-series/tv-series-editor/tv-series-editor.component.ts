import { Component } from '@angular/core';
import { FormGroup, FormBuilder } from '@angular/forms';
import { Router } from '@angular/router';
import { TVSeries } from '../../../shared/model/TVSeries.model';
import { TVSeriesService } from './../../../shared/service/tv-series.service';

@Component({
    selector: 'app-tv-series-editot',
    templateUrl: 'tv-series-editor.component.html'
})
export class TVSeriesEditorComponent {

    public tvSeries: TVSeries = new TVSeries();
    public tvSeriesForm: FormGroup;
    public selectedTVSeries: TVSeries;

    constructor(private formBuilder: FormBuilder,
                private router: Router,
                private tvSeriesService: TVSeriesService) {
    }

    ngOnInit() {
        this.initForm();
    }

    initForm() {
        this.tvSeriesForm = this.formBuilder.group({
            title: [this.tvSeries.title],
            season: [this.tvSeries.season],
        });
    }

    public apply(): void {
        this.tvSeriesService.addSeries(this.tvSeries);
        this.router.navigate(['watch']);
    }
}

