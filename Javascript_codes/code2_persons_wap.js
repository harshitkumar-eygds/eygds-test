

//code 2
// Online Javascript Editor for free
// Write, Edit and Run your Javascript code using JS Online Compiler

function Persons(id, name, city)
{
    this.id = id;
    this.name = name;
    this.city = city;
    console.log('3rd');
}

Persons.prototype.dispinf = function(){
    console.log('Persons ID is : ' + this.id);
    console.log('Persons name is : ' + this.name);
    console.log('Persons city is : ' + this.city);
}
console.log('2nd');
console.log(Persons.prototype);

let per1 = new Persons(12,'Mohan','Delhi');
console.log('1st');
console.log(per1);
per1.dispinf();

