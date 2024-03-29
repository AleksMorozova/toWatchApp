import { Injectable } from '@angular/core';
import { TVSeries } from './../../model/TVSeries.model';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Injectable({
  providedIn: 'root',
})
export class TVSeriesRESTService {
    private static httpOptions = {
        headers: new HttpHeaders({ 'Content-Type': 'application/json' })
    };

    constructor(protected http: HttpClient) {
    }

    public loadActive(): Promise<TVSeries[]> {
        return new Promise<TVSeries[]>((resolve, reject) => {
            this.http.get('https://localhost:44308/TVSeries/toWatch').subscribe((res: TVSeries[]) => resolve(res));
        });
    }

    public insert (tvSeries: TVSeries): any {
        return this.http.post<any>('https://localhost:44308/TVSeries/add', JSON.stringify(tvSeries), TVSeriesRESTService.httpOptions).toPromise();
    }

    public reWatch(tvSeries: TVSeries): any {
        return this.http.post<any>('https://localhost:44308/TVSeries/reWatch', JSON.stringify(tvSeries), TVSeriesRESTService.httpOptions).toPromise();
    }

    public watch(tvSeries: TVSeries): any {
        return this.http.post<any>('https://localhost:44308/TVSeries/watch', JSON.stringify(tvSeries), TVSeriesRESTService.httpOptions).toPromise();
    }

    public batchUpdate(tvSerials: TVSeries[]): any {
        return this.http.post<any>('https://localhost:44308/TVSeries/bulkUpdate', JSON.stringify(tvSerials), TVSeriesRESTService.httpOptions).toPromise();
    }
}