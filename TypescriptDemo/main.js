//var let const
var msg = "Hello World";
console.log(msg);
//string,number,boolean,any
var userName = "vani";
var userBlocked = false;
var userAge = 21;
var userAddress = "Hyderabad";
var myName = "My name is ".concat(userName);
console.log(myName);
//array
var numbers = [1, 2, 3, 4, 5];
numbers.forEach(function (num) {
    console.log(num);
});
var names = ["vani", "sai", "sri"];
//function declartion
function add(a, b) {
    return a + b;
}
console.log(add(10, 20));
//class
var User = /** @class */ (function () {
    function User(userName) {
        this.userName = userName;
    }
    //method
    User.prototype.greet = function () {
        return "Welcome ".concat(this.userName);
    };
    return User;
}());
var user1 = new User("vani");
console.log(user1.userName);
console.log(user1.greet());
var user2 = new User("sai");
console.log(user2.userName);
