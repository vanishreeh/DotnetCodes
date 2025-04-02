import { Component } from '@angular/core';
import { BehaviorSubject, Observable, Subject } from 'rxjs';

@Component({
  selector: 'app-userdashboard',
  standalone: true,
  imports: [],
  templateUrl: './userdashboard.component.html',
  styleUrl: './userdashboard.component.css'
})
export class UserdashboardComponent {
  //create a new Subject
  //#region subject
  // private mysubject=new Subject<number>();
  // constructor(){
  //   // write subscribers
  //   this.mysubject.subscribe((value:number)=>{
  //     console.log(`subscriber1 received value::${value}`);
   
  //   });
  //   this.mysubject.subscribe((value:number)=>{
  //     console.log(`subscriber2 received value::${value}`);
   
  //   });
  //   //Emit values
  //   this.mysubject.next(10);
  //   this.mysubject.next(20);
    //#endregion
  //#region HotObservables
  //   private mySubject=new Subject<number>();
  // /**
  //  *
  //  */
  // constructor() {
  //   //emit value
  //   this.mySubject.next(10);
  //   this.mySubject.subscribe(value=>{
  //     console.log(`received value is:${value}`);
      
  //   });
  //   //emit another value
  //   this.mySubject.next(100);
    
  // }
  //#endregion
  //#region ColdObservables
  // private coldObservable=new Observable<number>(
  //   observer=>{
  //     console.log('observable executing...');
  //     observer.next(Math.random());
      
  //   }
  // );

  // constructor() {
  //  //subscriber1
  //  this.coldObservable.subscribe(value=>{
  //   console.log(`subscriber1 got value ::${value}(random number)`);
    
  //  });
  //  this.coldObservable.subscribe(value=>{
  //   console.log(`subscriber2 got value ::${value}(random number)`);
    
  //  });
    
  // }
  //#endregion
  private behaviourSubject=new BehaviorSubject<number>(0);
 
  constructor() {
   this.behaviourSubject.subscribe(value=>{
    console.log(`component 1 received value::${value}`);
    
   });
   //change the value
   this.behaviourSubject.next(100);
   this.behaviourSubject.subscribe(value=>{
    console.log(`component 2 received value::${value}`);
    
   });
    
   //change the value again
   this.behaviourSubject.next(200);
  }
  }

