import { Component } from '@angular/core';
import { FormGroup, FormBuilder } from '@angular/forms';
import { Router } from '@angular/router';
import { Book } from '../../shared/model/Book.model';
import { BookService } from '../../shared/service/book.service';

@Component({
    selector: 'app-book-editot',
    templateUrl: './book-editor.component.html'
})
export class BookEditorComponent {

    public book: Book = new Book();
    public bookForm: FormGroup;

    constructor(private formBuilder: FormBuilder,
                private router: Router,
                private bookService: BookService) {
    }

    ngOnInit() {
        this.initForm();
        window.top.addEventListener('placeChangedIn', this.evenListener.bind(this), false);
        window.top.dispatchEvent(new CustomEvent('placeChangedIn'));

    }

    initForm() {
        this.bookForm = this.formBuilder.group({
            title: [this.book.title],
            description: [this.book.description],
            author: [this.book.authors],
        });
    }

    public evenListener() {
        console.log('TADA even is fire');
    }
    public apply(): void {
        this.bookService.addBook(this.book);
        this.router.navigate(['book']);
    }
}

