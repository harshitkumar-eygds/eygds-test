import { Component, OnInit, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-comptwo',
  templateUrl: './comptwo.component.html',
  styleUrls: ['./comptwo.component.css']
})
export class ComptwoComponent {

  @Output() public dataForAppEvent = new EventEmitter();

  public dataForApp:string = "I am a data of comp-two";
  constructor(){}
  ngOnInit(): void{}

  sendData(){
    this.dataForAppEvent.emit(this.dataForApp);
  }
}
