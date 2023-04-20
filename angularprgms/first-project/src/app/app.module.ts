import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { StudentdetailsComponent } from './studentdetails/studentdetails.component';
import { NavBarsComponent } from './nav-bars/nav-bars.component';
import { RecommendproductsComponent } from './recommendproducts/recommendproducts.component';

@NgModule({
  declarations: [
    AppComponent,
    StudentdetailsComponent,
    NavBarsComponent,
    RecommendproductsComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
