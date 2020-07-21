import { Book } from "../../model/Book.model";
import { Injectable } from "@angular/core";
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Injectable()
export class BooksMockService {

    constructor(protected http: HttpClient) {
    }

    public loadBooks(): Promise<Book[]> {
        return new Promise<Book[]>((resolve, reject) => {
            const serials: Book[] = [
                {
                    title: 'Происхождение mock', author: 'Den Braun',
                    description: '', id: null
                },
                {
                    title: 'Тайная комната mock', author: 'Донна Тартт',
                    description: '', id: null
                }];
            resolve(serials);
        });
    }

    public updateBook(book: Book): any {
        return null;
    }

    public batchUpdateBooks(books: Book[]): any {
        return null;
    }
}