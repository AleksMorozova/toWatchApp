import { TVSeries } from '../../model/TVSeries.model';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable()
export class TVSeriesMockService {
    constructor(protected http: HttpClient) {
    }

    public addSeries(movie: TVSeries): void {
    }

    public loadSeries(): Promise<TVSeries[]> {
        return new Promise<TVSeries[]>((resolve, reject) => {
            const serials: TVSeries[] = [
                {
                    title: 'once upon a time', season: '1', series: '1', status: '1', link: '',
                    description: 'Description for once upon a time'
                },
                {
                    title: '2 broke girls', season: '1', series: '1', status: '1', link: '',
                    description: 'Description for 2 broke girls'
                }];
            resolve(serials);
        });
    }

    public updateTVSeries(tvSeries: TVSeries): any {
        console.log('updateTVSeries in mock service are not implemented. Serial: ' + tvSeries.title);
        return null;
    }

    public batchUpdateTVSeries(_serials: TVSeries[]): any {
        console.log('batchUpdateTVSeries in mock service are not implemented');
        return null;
    }
}