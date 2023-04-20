import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  template: `<div>
  <span [innerHTML] ='msg'></span>
  <img src={{imgsrc}}>
  <button [disabled]="isUnchanged">Disabled Button</button>
  </div>`
  
 
})
export class AppComponent {
  title = 'first-project';
  msg:string = "Welcome to EY BY Harshit";
  isUnchanged:boolean = true;
  imgsrc:string = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSKuxEstdsRE1Vi6LO-TBjtjtaNo9qt6SpKvn0PRmBu1w&s"

  
}
