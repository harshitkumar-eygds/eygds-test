import { Injectable } from "@angular/core";

@Injectable()

export class StudentListService{
    getAllStudents(){
        return
        [
            {
                Id:1,
                Name:"Harshit",
                City:"Bhopal",
                Gender:"Male"
            },
            {
                Id:2,
                Name:"Harshit2",
                City:"Bhopal2",
                Gender:"Male2"
            }
        ]
    }
}