import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { UsdinrPipe } from './pipe/usdinr.pipe';
import { PoundinrPipe } from './pipe/poundinr.pipe';

@NgModule({
  declarations: [
    AppComponent,
    UsdinrPipe,
    PoundinrPipe
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
