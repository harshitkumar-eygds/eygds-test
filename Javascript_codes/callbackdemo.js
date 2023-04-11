function welcome(name){
    alert("hello " + name);
};

function UserEntry(callback){
    var name = prompt("Please enter your name : ");
    callback(name);
}


UserEntry(welcome);