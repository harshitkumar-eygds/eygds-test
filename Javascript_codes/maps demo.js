var map1 = new Map();
map1.set("firstname", "Mohit");
map1.set("lastname", "Gupta");
map1.set("City", "Delhi");
map1.set("friend1", "rohan");
map1.set("friend2" ,"sohan");

console.log(map1);

console.log("map1 has friend 3 ?" + map1.has("friend3"));
console.log("delete element with key = friend2 - " + map1.delete("friend2"));

map1.clear();
console.log(map1);
