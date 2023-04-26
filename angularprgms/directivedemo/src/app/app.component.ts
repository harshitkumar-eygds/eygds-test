import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  /*template: `<!---<h1 [ngStyle]="ApplyStyles()" > {{trainingdemo}} </h1>
  <button style='color:blue' [ngStyle]="ApplyStyles()">Click here</button>
--->
  <button class ='colorClass' [ngClass]='applyClasses()'>Classes applied</button>
  `,*/

  template : `

  <div *ngIf="Courses.length >0">
  List of Courses</div>
  <div *ngIf="Courses.length == 0">
  No Course Available</div>
 <app-ngifdemo></app-ngifdemo> 
 <app-ngswitchdemo></app-ngswitchdemo>
  `,
  styles : [`
  .boldClass
  {
    font-weight:bold;
  }
  .colorClass
  {
    color : red;
  }
  .bgColor
  {
    background-color:barkblue;
  }
  `],
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'directivedemo';

  trainingdemo:string = "EY new Training";

  isBold: Boolean = true;
  isItalic:boolean = true;
  fontSize: number = 30;
/*
  ApplyStyles(){
    let styles = {
      'font-weight' : this.isBold ? 'bold' : 'normal',
      'font-style' : this.isItalic ? 'italic' : 'normal',
      'font-size.px' : this.fontSize,

    };
    return styles;
*/
    applyBoldClass: boolean = true;
    applyBGColor :boolean = true;
    applyColor : boolean = true;

    applyClasses(){

      let classes = {
        boldClass: this.applyBoldClass,
        colorClass: this.applyColor,
        bgColor: this.applyBGColor
      }
      return classes;
    }

    Courses = [];

  }

