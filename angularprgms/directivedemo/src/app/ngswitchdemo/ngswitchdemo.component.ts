import { Component } from '@angular/core';
import { item } from '../item';

@Component({
  selector: 'app-ngswitchdemo',
  templateUrl: './ngswitchdemo.component.html',
  styleUrls: ['./ngswitchdemo.component.css']
})
export class NgswitchdemoComponent {

  myVar = 'A';

  items : item[] = [
    {name:'One', val:1},
    {name:'Two', val:2},
    {name:'Three', val:3},
  ];
  selectedValue:string ="'One'";
}
