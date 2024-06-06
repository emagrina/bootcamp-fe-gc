import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { UserService } from '@modules/auth/services/user.service';

@Component({
  selector: 'app-nav-bar',
  templateUrl: './nav-bar.component.html',
  styleUrls: ['./nav-bar.component.css'],
})
export class NavBarComponent implements OnInit {
  imageUrl: string;

  constructor(private userService: UserService, private router: Router) {
    this.imageUrl = '../../../../assets/img/logo-portal.png';
  }

  ngOnInit(): void {}

  onClick(){
    this.userService.logout()
    .then(() => {
      this.router.navigate(['/login']);
    })
    .catch(error => console.error(error));
  }
}
