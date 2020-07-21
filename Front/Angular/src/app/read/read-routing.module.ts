import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ReadComponent } from './read.component';
import { BookEditorComponent } from './book-editor/book-editor.component';

const routes: Routes = [
  { path: '', component: ReadComponent},
  { path: 'addBook', component: BookEditorComponent},

];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ReadRoutingModule { }
