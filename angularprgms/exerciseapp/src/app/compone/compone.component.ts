import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-comp-one',
  templateUrl: './compone.component.html',
  styleUrls: ['./compone.component.css']
})
export class ComponeComponent implements OnInit{

  @Input('parentData') dataFromApp : string = "";
  constructor(){
    
  }
  ngOnInit(): void {

  }
}
