import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { PessoaModel } from './models/pessoa.model';

@Injectable({
  providedIn: 'root'
})
export class PessoaService {

  private pimUrl = '/pim/v1/pessoa';
  constructor(private http: HttpClient) {} 


  getPessoas(): Observable<Array<PessoaModel>> {
    return this.http.get<Array<PessoaModel>>(`${this.pimUrl}`);
  }

  postPessoa(pessoa: PessoaModel): Observable<PessoaModel> {
    return this.http.post<PessoaModel>(`${this.pimUrl}`, {
      nome: pessoa.nome
    });
  }

}

