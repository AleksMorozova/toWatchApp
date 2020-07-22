import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AboutComponent } from './about-component/about.component';
import { NotFoundComponent } from './not-found-page/not-found-page.component';

const routes: Routes = [
  { path: 'about', component: AboutComponent },
  {
    path: 'watch',
    // https://nativescript.org/blog/lazy-loading-in-nativescript-angular-8.0/
    loadChildren: () => import('./watch/watch.module').then(m => m.WatchModule),
    data: { preload: true }
  },
  {
    path: 'english',
    loadChildren: () => import('./english/english.module').then(m => m.EnglishModule),
    data: { preload: true }
  },
  {
    path: 'read',
    loadChildren: () => import('./read/read.module').then(m => m.ReadModule),
    data: { preload: true }
  },
  {
    path: 'favorite',
    loadChildren: () => import('./favorite/favorite.module').then(m => m.FavoriteModule),
    data: { preload: true }
  },
  //   { path: '', component: } //  somw home component could be added
  { path: '**', component: NotFoundComponent} //  wildcard route
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
