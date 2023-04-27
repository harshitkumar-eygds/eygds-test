import { Component } from '@angular/core';
import { UserdataService } from './userdata.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'servicesdemo1';
  name1 ="";
  age1 = 0;
  id1 = 0;
  constructor(private user:UserdataService)
  {
    var data = user.getData();
    //console.log(data);
    console.log(data.name);
    console.warn(this.user.getData());
    this.name1 = data.name;
    this.age1 = data.age;
    this.id1 = data.id;
  }
}
