import { NgModule } from '@angular/core';

import { WatchRoutingModule } from './watch.-routing.module';
import { TVSeriesComponent } from './tv-series/tv-series.component';
import { WatchComponent } from './watch.component';
import { MoviesComponent } from './movies/movies.component';
import { MovieDetailsComponent } from './movies/movie-details/movie-detail.component';
import { TabViewModule } from 'primeng/tabview';
import { TableModule } from 'primeng/table';
import { CommonModule } from '@angular/common';
import { ButtonModule } from 'primeng/button';
import { MovieEditorComponent } from './movies/movie-editor/movie-editor.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { TVSeriesEditorComponent } from './tv-series/tv-series-editor/tv-series-editor.component';
import { OverlayPanelModule } from 'primeng/overlaypanel';
import { InputTextareaModule } from 'primeng/inputtextarea';
import { TooltipModule } from 'primeng/tooltip';

@NgModule({
  declarations: [
    TVSeriesComponent,
    WatchComponent,
    MoviesComponent,
    MovieDetailsComponent,
    MovieEditorComponent,
    TVSeriesEditorComponent,
  ],
  imports: [
    WatchRoutingModule,
    TabViewModule,
    TableModule,
    CommonModule,
    ButtonModule,
    ReactiveFormsModule,
    FormsModule,
    OverlayPanelModule,
    InputTextareaModule,
    TooltipModule
  ],
  providers: [
  ],
  exports: [
    TVSeriesComponent,
    WatchComponent,
    MoviesComponent,
    MovieDetailsComponent,
    MovieEditorComponent,
    TVSeriesEditorComponent
  ]
})
export class WatchModule { }
