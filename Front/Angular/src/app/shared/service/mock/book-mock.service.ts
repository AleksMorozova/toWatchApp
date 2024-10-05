import { Book } from "../../model/Book.model";
import { Injectable } from "@angular/core";
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Injectable()
export class BookMockService {

    constructor(protected http: HttpClient) {
    }

    public loadBooks(): Promise<Book[]> {
        return new Promise<Book[]>((resolve, reject) => {
            const serials: Book[] = [
                {
                    title: 'Происхождение mock', authors: 'Den Braun',
                    description: '', id: null
                },
                {
                    title: 'Тайная комната mock', authors: 'Донна Тартт',
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