import { TVSeries } from '../model/TVSeries.model';
import { Injectable } from '@angular/core';
import { TVSeriesRESTService } from './rest/tv-series-rest.service';

@Injectable()
export class TVSeriesService {
    constructor(protected tvSeriesRESTService: TVSeriesRESTService) {
    }

    public addSeries(tvSeries: TVSeries): void {
        this.tvSeriesRESTService.insert(tvSeries);
    }

    public loadSeries(): Promise<TVSeries[]> {
        return new Promise<TVSeries[]>((resolve, reject) => {
            this.tvSeriesRESTService.loadActive().then(res => {
                const courses = <TVSeries[]>res;
                if (courses) {
                    resolve(courses);
                } else {
                    reject();
                }
            });
        });
    }
    
    public updateTVSeries(tvSeries: TVSeries): any {
        return this.tvSeriesRESTService.update(tvSeries);
    }

    public batchUpdateTVSeries(serials: TVSeries[]): any {
        return this.tvSeriesRESTService.batchUpdate(serials);
    }
}