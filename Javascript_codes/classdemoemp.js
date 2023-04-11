class Employee
{
    constructor(id,name)
    {
        this.id = id;
        this.name = name;
    }
    detail()
    {
        document.writeln(this.id + " " +this.name + "<br>");
    }
}

var e1 = new Employee(101,"Michale");
var e2 = new Employee(102,"Tommy");
e1.detail();
e2.detail();