import { Component } from '@angular/core';
import {MenuItem} from 'primeng/api';
import { Subject } from 'rxjs';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  items = [
    {label: 'Computer'},
    {label: 'Notebook'},
    {label: 'Accessories'},
    {label: 'Backpacks'},
    {label: 'Item'}
];
  title = 'My todo app';
  home = {icon: 'pi pi-home', routerLink: '/'};

  constructor() {
    const subject = new Subject<number>();

    subject.subscribe({
      next: (v) => console.log(`observerA: ${v}`)
    });
    subject.subscribe({
      next: (v) => console.log(`observerB: ${v}`)
    });
    
    // subject.next(1);
    subject.next(2);
  }
}
