import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { FormsModule } from '@angular/forms';


@Component({
  selector: 'app-login',
  imports: [FormsModule],
  templateUrl: './login.html',
  styleUrl: './login.css',
})
export class Login {
  user: string = '';
  password: string = '';

  constructor(private router: Router){
  }

  login(): void{
    if(this.user === 'santiago' && this.password === '1234'){
      alert('Crendecinales correctas')
      this.router.navigate(['/home']);
    }
    else{
      alert('Usuario o Contrañesa incorrectos')
    }
  }

}
