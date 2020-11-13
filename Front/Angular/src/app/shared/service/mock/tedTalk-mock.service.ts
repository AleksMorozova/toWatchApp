import { TedTalk } from './../../model/TedTalk.model';

export class TedTalkMockService {
    public getAllTedTalks(): Promise<TedTalk[]> {
        return new Promise<TedTalk[]>((resolve, reject) => {
            const talks: TedTalk[] = [
                {
                    title: 'Inside the mind of a master procrastinator. Scary monky monster', isWatched: false,
                    link: 'https://www.youtube.com/watch?v=arj7oStGLkU&list=WL&index=98&t=14s', id: null
                }];
            resolve(talks);
        });
    }

    
}