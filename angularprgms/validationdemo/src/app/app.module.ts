import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { HeroformComponent } from './heroform/heroform.component';
import { HerocomponentComponent } from './herocomponent/herocomponent.component';

@NgModule({
  declarations: [
    AppComponent,
    HeroformComponent,
    HerocomponentComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
