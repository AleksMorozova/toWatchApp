
import { AppRoutingModule } from './app-routing.module';
import { TabMenuModule } from 'primeng/tabmenu';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { TabViewModule } from 'primeng/tabview';
import { ButtonModule } from 'primeng/button';
import { NoopAnimationsModule } from '@angular/platform-browser/animations';
import { HttpClientModule, HttpClient } from '@angular/common/http';
import { CommonModule } from '@angular/common';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { BreadcrumbModule } from 'primeng/breadcrumb';

// Components
import { AppComponent } from './app.component';
import { AboutComponent } from './about-component/about.component';
import { MenuComponent } from './menu/menu.component';
import { NotFoundComponent } from './not-found-page/not-found-page.component';

// Service
import { TedTalkService } from './shared/service/tedTalk.service';
import { BooksService } from './shared/service/books.service';
import { TVSeriesService } from './shared/service/tv-series.service';
import { MovieService } from './shared/service/movie.service';

// MOCK Service
import { MovieMockService } from './shared/service/mock/movie-mock.service';
import { BooksMockService } from './shared/service/mock/books-mock.service';
import { TVSeriesMockService } from './shared/service/mock/tv-series-mock.service';
import { TedTalkMockService } from './shared/service/mock/tedTalk-mock.service';

@NgModule({
  declarations: [
    MenuComponent,
    AppComponent,
    AboutComponent,
    NotFoundComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    TabMenuModule,
    TabViewModule,
    ButtonModule,
    NoopAnimationsModule,
    HttpClientModule,
    CommonModule,
    BrowserAnimationsModule,
    BreadcrumbModule
  ],
  providers: [
    HttpClient,
    { provide: BooksService, useClass: BooksMockService },
    { provide: TVSeriesService, useClass: TVSeriesMockService },
    // { provide: MovieService, useClass: MovieMockService },
    { provide: TedTalkService, useClass: TedTalkMockService }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
