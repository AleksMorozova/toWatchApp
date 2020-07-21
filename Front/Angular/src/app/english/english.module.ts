import { NgModule } from '@angular/core';
import { TabViewModule } from 'primeng/tabview';
import { TableModule } from 'primeng/table';
import { CommonModule } from '@angular/common';
import { ButtonModule } from 'primeng/button';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { EnglishComponent } from './english.component';
import { EnglishRoutingModule } from './english-routing.module';

@NgModule({
  declarations: [
    EnglishComponent
  ],
  imports: [
    EnglishRoutingModule,
    TabViewModule,
    TableModule,
    CommonModule,
    ButtonModule,
    ReactiveFormsModule,
    FormsModule
  ],
  providers: [
  ],
  exports: [
    EnglishComponent
  ]
})
export class EnglishModule { }
