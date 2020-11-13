import { Component, ElementRef, Renderer2 } from '@angular/core';
import { ResizeObserverDirective } from './resize-observer.directive';

@Component({
  selector: 'app-about',
  styleUrls: ['./about.component.scss'],
  templateUrl: './about.component.html'
})
export class AboutComponent {
  clikedItem: String;

  constructor(private el: ElementRef, private renderer: Renderer2) { }

  click1(): void {
    console.log('div 1 click');
    this.clikedItem = 'button 1 was cliked';
  }

  click2(): void {
    console.log('div 2 click');
    this.clikedItem = 'button 2 was cliked';

  }

  click3(): void {
    console.log('div 3 click');
    this.clikedItem = 'button 3 was cliked';

  }

  click4(): void {
    console.log('div 4 click');
    this.clikedItem = 'button 4 was cliked';

  }

  click5(): void {
    console.log('div 5 click');
    this.clikedItem = 'button 5 was cliked';

  }

  click6(): void {
    console.log('div 6 click');
    this.clikedItem = 'button 6 was cliked';

  }

  click7(): void {
    console.log('div 7 click');
    this.clikedItem = 'button 7 was cliked';

  }

  click8(): void {
    console.log('div 8 click');
    this.clikedItem = 'button 8 was cliked';

  }

  click9(): void {
    console.log('div 9 click');
    this.clikedItem = 'button 9 was cliked';

  }

  click10(): void {
    console.log('div 10 click');
    this.clikedItem = 'button 10 was cliked';

  }
}
