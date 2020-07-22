import { Component } from '@angular/core';
import { TVSeries } from '../../shared/model/TVSeries.model';
import { Router, ActivatedRoute } from '@angular/router';
import { TVSeriesService } from './../../shared/service/tv-series.service';
import { OverlayPanel } from 'primeng/overlaypanel';

@Component({
  selector: 'app-tv-series',
  templateUrl: './tv-series.component.html'
})
export class TVSeriesComponent {
  serials: TVSeries[];
  public selectedTVSeries: TVSeries;

  constructor(private router: Router,
    private route: ActivatedRoute,
    private tvSeriesService: TVSeriesService) {
  }

  ngOnInit() {
    this.tvSeriesService.loadSeries().then(res => {
      this.serials = res;
    });
  }

  public addTVSeries(): void {
    this.router.navigate(['addTVSeries'], { relativeTo: this.route });
  }

  public batchUpdateTVSeries(): void {
    this.tvSeriesService.batchUpdateTVSeries(this.serials);
  }

  public watchTVSeries(tvSeries: TVSeries): void {
    this.tvSeriesService.watchTVSeries(tvSeries);
  }

  public reWatchTVSeries(tvSeries: TVSeries): void {
    this.tvSeriesService.reWatchTVSeries(tvSeries);
  }

  public addToFavorite(tvSeries: TVSeries): void {
    this.tvSeriesService.addToFavorite(tvSeries);
  }
}