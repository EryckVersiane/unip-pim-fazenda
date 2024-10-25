import { Component } from '@angular/core';
import { Router } from '@angular/router'; 
import { LoginService } from '../login.service'; 
import { UsuarioModel } from '../models/usuario.model';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss'] 
})
export class LoginComponent {
  usuario: string = '';
  senha: string = '';
  erroLogin: boolean = false; 

  constructor(private loginService: LoginService, private router: Router) {}

  login() {
    let usuarioData: UsuarioModel = {
      id: 0,
      usuario: this.usuario,
      senha: this.senha,
      estado: '',
      pessoa_id: 0 
    };

    this.loginService.autenticar(usuarioData).subscribe(
      (data) => {
        if (data && data.id > 0) {
          console.log('Login bem-sucedido');
          this.erroLogin = false;
          this.router.navigate(['/home']); 
        } else {
          console.error('Login falhou');
          this.erroLogin = true; 
        }
      },
      (error) => {
        console.error('Erro de autenticação', error);
        this.erroLogin = true; 
      }
    );
  }
}
