import { Component } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-menu',
  styleUrls: ['./menu.component.scss'],
  templateUrl: './menu.component.html'
})
export class MenuComponent {

  constructor(private router: Router,
    private route: ActivatedRoute) {
  }

  public toWatch(): void {
    this.router.navigate(['watch'], { relativeTo: this.route });
  }

  public toRead(): void {
    this.router.navigate(['read'], { relativeTo: this.route });
  }

  public about(): void {
    this.router.navigate(['about'], { relativeTo: this.route });
  }

  public english(): void {
    this.router.navigate(['english'], { relativeTo: this.route });
  }

  public favorite(): void {
    this.router.navigate(['favorite'], { relativeTo: this.route });
  }
}
