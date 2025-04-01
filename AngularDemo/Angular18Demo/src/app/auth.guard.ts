import { CanActivateFn } from '@angular/router';
import { UserService } from './services/user.service';
import { inject } from '@angular/core';

export const authGuard: CanActivateFn = (route, state) => {
  // if(localStorage.getItem('token')!=null){
  //   return true;
  // }
  // else{
  //   return false;
  // }
  const userService=inject(UserService);
  if(userService.isLoggedIn()){
    return true;
  }
  else{
    return false;
  }

  
};
