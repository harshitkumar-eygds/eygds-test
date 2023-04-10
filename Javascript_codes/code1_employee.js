//code 1
// Online Javascript Editor for free
// Write, Edit and Run your Javascript code using JS Online Compiler

function Employee(name, designation, yearOfBirth)
{
    this.name = name;
    this.designation - designation;
    this.yearOfBirth = yearOfBirth;
    console.log('3rd');
}

Employee.prototype.calculateAge = function(){
    console.log('the current age is : ' + (2023 - this.yearOfBirth));
}
console.log('2nd');
console.log(Employee.prototype);

let emp1 = new Employee('alex','junior',1995);
console.log('1st');
console.log(emp1);
emp1.calculateAge();
