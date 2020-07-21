import { NgModule } from '@angular/core';
import { TabViewModule } from 'primeng/tabview';
import { TableModule } from 'primeng/table';
import { CommonModule } from '@angular/common';
import { ButtonModule } from 'primeng/button';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { ReadComponent } from './read.component';
import { ReadRoutingModule } from './read-routing.module';
import { SharedModule } from './../shared/shared.module';
import { BookEditorComponent } from './book-editor/book-editor.component';

@NgModule({
  declarations: [
    ReadComponent,
    BookEditorComponent,
  ],
  imports: [
    ReadRoutingModule,
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
    ReadComponent
  ]
})
export class ReadModule { }
