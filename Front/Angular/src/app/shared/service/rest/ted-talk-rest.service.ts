import { Injectable } from '@angular/core';
import { TedTalk } from '../../model/TedTalk.model';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Injectable({
  providedIn: 'root',
})
export class TedTalkRESTService {
    private static httpOptions = {
        headers: new HttpHeaders({ 'Content-Type': 'application/json' })
    };

    constructor(protected http: HttpClient) {
    }

    public loadActive(): Promise<TedTalk[]> {
        return new Promise<TedTalk[]>((resolve, reject) => {
            this.http.get('https://localhost:44308/TedTalks/toWatch').subscribe((res: TedTalk[]) => resolve(res));
        });
    }

    public insert (talk: TedTalk): any {
        return this.http.post<any>('https://localhost:44308/TedTalks/add', JSON.stringify(talk), TedTalkRESTService.httpOptions).toPromise();
    }

    public update(talk: TedTalk): any {
        return this.http.post<any>('https://localhost:44308/TedTalks/update', JSON.stringify(talk), TedTalkRESTService.httpOptions).toPromise();
    }

    public batchUpdate(talks: TedTalk[]): any {
        return this.http.post<any>('https://localhost:44308/TedTalks/bulkUpdate', JSON.stringify(talks), TedTalkRESTService.httpOptions).toPromise();
    }
}