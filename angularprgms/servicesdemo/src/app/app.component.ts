import { Component, OnInit } from '@angular/core';
import { StudentListService } from 'src/studentlist';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'servicesdemo';
  public students: any = [];
  constructor(private _studentListService: StudentListService) {}  
  
  //This is lifecycle hook method of angular which fires after the constructor  
  ngOnInit() {  
      //here i am calling the services and assingning the returned student list to the students variable  
      this.students = this._studentListService.getAllStudents();  
  }
}
