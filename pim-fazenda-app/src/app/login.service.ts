import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { UsuarioModel } from './models/usuario.model'; 

@Injectable({
  providedIn: 'root'
})
export class LoginService {
  private loginUrl = '/pim/v1/login'; 

  constructor(private http: HttpClient) {}

  // Método para autenticar o usuário (existente)
  autenticar(usuario: UsuarioModel): Observable<UsuarioModel> {
    const url = `${this.loginUrl}/autenticar`;
    return this.http.post<UsuarioModel>(url, {
      usuario: usuario.usuario,
      senha: usuario.senha
    });
  }

  // Método para cadastrar um novo usuário
  cadastrar(usuario: UsuarioModel): Observable<UsuarioModel> {
    const url = `${this.loginUrl}/cadastro`;
    return this.http.post<UsuarioModel>(url, {
      usuario: usuario.usuario,
      senha: usuario.senha,
      pessoaId: usuario.pessoa_id
    });
  }
}


