import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { AccountService } from '../account.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss'],
})
export class LoginComponent implements OnInit {
  loginForm: FormGroup;

  constructor(private accountService: AccountService) {
    this.createLoginForm();
  }

  ngOnInit(): void {}

  createLoginForm() {
    this.loginForm = new FormGroup({
      email: new FormControl('', Validators.required),
      password: new FormControl('', Validators.required),
    });
  }

  onSubmit() {
    this.accountService.login(this.loginForm.value).subscribe(
      () => {
        console.log('user logged in');
      },
      (error) => {
        console.log(error);
      }
    );
  }
}
