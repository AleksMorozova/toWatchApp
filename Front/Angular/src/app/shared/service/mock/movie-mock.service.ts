import { Movie } from './../../model/Movie.model';
import { Injectable } from '@angular/core';

@Injectable()
export class MovieMockService {

    public loadMovies(): Promise<Movie[]> {
        return new Promise<Movie[]>((resolve, reject) => {
            const movies: Movie[] = [{
                title: 'My Wifes Secret Life', id: null,
                isWatched: false,
                link: 'http://baskino.me/films/trillery/22537-taynaya-zhizn-moey-zheny.html',
                description: 'Лорел и Джеймс — семейная пара, воспитывающая двоих детей. В последнее время их отношения сильно испортились. Большую часть времени женщина посвящает своей карьере. Она прекрасно справляется с заданиями, поэтому ее все больше нагружают работой. Джеймс считает, что жена неправильно расставляет приоритеты и отодвинула семью на второй план. Все становится еще хуже после годовщины брака. Мужчина подготовил любимой сюрприз, украсив комнату и заказав прекрасную еду. Однако его жена поздно вернулась с работы, после чего у них произошел громкий скандал. Пытаясь отвлечься от личных проблем, Лорел принимает ухаживание Кента, и вскоре проводит с ним страстную ночь. Однако она и подумать не может о том, к чему приведет этот поступок...'
            }];
            resolve(movies);
        });
    }

    public watchMovie(movie: Movie): void {
        console.log(movie.title + ' was watchd');
    }

    public addMovie(movie: Movie): void {
        console.log(movie.title + ' movie to watch');
    }
    public batchUpdateTVSeries(_serials: Movie[]): any {
        console.log('batchUpdateTVSeries in mock service are not implemented');
        return null;
    }
}