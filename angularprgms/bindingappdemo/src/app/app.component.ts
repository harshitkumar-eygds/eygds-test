import { Component } from '@angular/core';
import { OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})


export class AppComponent {
  title = 'bindingappdemo';

  count=0;
  count1=0;
  clickMe()
  {
    this.count++;
  }

  onShow(){
    alert("You have been alerted");
  }


  text2:string = "";

  text:string="EY training";

  keyup(text:string)
  {
    this.text2 = text;
  }

  userName1:string="JBond";
  


  private _userName: string = "bill gates";

  get userName(): string {
    return this._userName;
  }

  set userName(val: string) {
    //do some extra work here
    this._userName = val;
  }
  ngOnInit(): void {
  }
}
