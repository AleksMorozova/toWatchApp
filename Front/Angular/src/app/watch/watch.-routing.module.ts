import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { WatchComponent } from './watch.component';
import { MovieEditorComponent } from './../watch/movies/movie-editor/movie-editor.component';
import { TVSeriesEditorComponent } from './tv-series/tv-series-editor/tv-series-editor.component';

const routes: Routes = [
  { path: '', component: WatchComponent },
  { path: 'addTVSeries', component: TVSeriesEditorComponent },
  { path: 'addMovie', component: MovieEditorComponent },
  /*{
    path: '',
    component: WatchComponent,
    children: [
      {path: 'addTVSeries',
        component: TVSeriesEditorComponent,
      },
      { path: 'addMovie', component: MovieEditorComponent }
    ]
  }*/
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class WatchRoutingModule { }
