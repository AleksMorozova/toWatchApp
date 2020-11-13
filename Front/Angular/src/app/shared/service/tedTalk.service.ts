import { TedTalk } from "../model/TedTalk.model";
import { TedTalkRESTService } from './rest/ted-talk-rest.service';
import { Injectable } from '@angular/core';

@Injectable()
export class TedTalkService {
    constructor(protected tedTalkRESTService: TedTalkRESTService) {}
    
    public getAllTedTalks(): Promise<TedTalk[]> {
        return new Promise<TedTalk[]>((resolve, reject) => {
            this.tedTalkRESTService.loadActive().then(res => {
                const talks = <TedTalk[]>res;
                if (talks) {
                    resolve(talks);
                } else {
                    reject();
                }
            });
        });
    }

    public updateTedTalk(talk: TedTalk): any {
        return this.tedTalkRESTService.update(talk);
    }

    public batchUpdateTedTalks(talks: TedTalk[]): any {
        return this.tedTalkRESTService.batchUpdate(talks);
    }
    
    public addTedTalk(talk: TedTalk): any {
        return this.tedTalkRESTService.insert(talk);
    }
}