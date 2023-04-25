import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

export class AppComponent {
  title = 'exerciseapp';

  public dataForCompOne:string = "HI I am Comp One child and I have the data of 'app'";

  public dataFromCompTwo:string ="";
  receiveDataFromChild(event:any){
    this.dataFromCompTwo = event;
  }
}
