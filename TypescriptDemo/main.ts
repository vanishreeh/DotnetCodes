//var let const
let msg="Hello World";
console.log(msg);
//string,number,boolean,any
let userName:string="vani";
let userBlocked:boolean=false;
let userAge:number=21;
let userAddress:any="Hyderabad";
let myName:string=`My name is ${userName}`;
console.log(myName);

//array
let numbers:number[]=[1,2,3,4,5];
numbers.forEach(num=>{
    console.log(num);

    
})
let names:string[]=["vani","sai","sri"];
//function declartion
function add(a:number,b:number):number{
    return a+b;
}
console.log(add(10,20));
//class
class User{
    //property
    userName:string;
    constructor(userName:string){
        this.userName=userName;
    }
    //method
    greet(){
        return `Welcome ${this.userName}`;
    }

}
let user1=new User("vani");
console.log(user1.userName);
console.log(user1.greet());

let user2=new User("sai");
console.log(user2.userName);


