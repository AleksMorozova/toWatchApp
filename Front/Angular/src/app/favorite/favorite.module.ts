import { NgModule } from '@angular/core';
import { TabViewModule } from 'primeng/tabview';
import { TableModule } from 'primeng/table';
import { CommonModule } from '@angular/common';
import { ButtonModule } from 'primeng/button';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { FavoriteComponent } from './favorite.component';
import { FavoriteRoutingModule } from './favorite-routing.module';
import { SharedModule } from './../shared/shared.module';

@NgModule({
  declarations: [
    FavoriteComponent
  ],
  imports: [
    FavoriteRoutingModule,
    TabViewModule,
    TableModule,
    CommonModule,
    ButtonModule,
    ReactiveFormsModule,
    FormsModule,
    SharedModule,
  ],
  providers: [
  ],
  exports: [
    FavoriteComponent
  ]
})
export class FavoriteModule { }
