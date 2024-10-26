import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { LoginService } from '../../login.service'; 
import { UsuarioModel } from '../../models/usuario.model';

@Component({
  selector: 'app-cadastro',
  templateUrl: './cadastro.component.html',
  styleUrls: ['./cadastro.component.scss']
})
export class CadastroComponent {
  usuario: string = '';
  senha: string = '';
  pessoaId: number = 0;
  erroCadastro: boolean = false;
  cadastroSucesso: boolean = false;

  constructor(private loginService: LoginService, private router: Router) {}

  cadastrar() {
    let usuarioData: UsuarioModel = {
      id: 0,
      usuario: this.usuario,
      senha: this.senha,
      estado: '', 
      pessoa_id: this.pessoaId
    };

    this.loginService.cadastrar(usuarioData).subscribe(
      (data) => {
        if (data && data.id > 0) {
          this.cadastroSucesso = true;
          this.erroCadastro = false;
          console.log('Cadastro realizado com sucesso');
          this.router.navigate(['/login']); 
        } else {
          this.erroCadastro = true;
        }
      },
      (error) => {
        console.error('Erro no cadastro', error);
        this.erroCadastro = true;
      }
    );
  }
}
