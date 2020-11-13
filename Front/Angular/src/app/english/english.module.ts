import { NgModule } from '@angular/core';
import { TabViewModule } from 'primeng/tabview';
import { TableModule } from 'primeng/table';
import { CommonModule } from '@angular/common';
import { ButtonModule } from 'primeng/button';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { TedTalkComponent } from './ted-talks/ted-talk.component';
import { EnglishRoutingModule } from './english-routing.module';
import { SharedModule } from 'primeng/api';
import { EnglishComponent } from './english.component';
import { DialogModule } from 'primeng/dialog';

@NgModule({
  declarations: [
    TedTalkComponent,
    EnglishComponent
  ],
  imports: [
    EnglishRoutingModule,
    TabViewModule,
    TabViewModule,
    TableModule,
    CommonModule,
    ButtonModule,
    ReactiveFormsModule,
    FormsModule,
    TabViewModule,
    SharedModule,
    DialogModule,
  ],
  providers: [
  ],
  exports: [
    TedTalkComponent,
    EnglishComponent
  ]
})
export class EnglishModule { }
