import { Component } from '@angular/core';
import {MenuItem} from 'primeng/api';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  items: MenuItem[] = [
    {label: 'To watch', routerLink:'watch'},
    {label: 'To read', routerLink:'read'},
    {label: 'English', routerLink:'english'},
    {label: 'Favorite', routerLink:'favorite'},
    {label: 'About', routerLink:'about'}
];

  title = 'My todo app';
}
