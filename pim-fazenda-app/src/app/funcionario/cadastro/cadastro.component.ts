import { Component } from '@angular/core';
import { PessoaService } from '../../pessoa.service';
import { PessoaModel } from '../../models/pessoa.model';

@Component({
  selector: 'app-cadastro',
  templateUrl: './cadastro.component.html',
  styleUrl: './cadastro.component.scss'
})
export class CadastroComponent {

 nome: string = '';
 pessoa: PessoaModel = {id: 0, nome: ''};

  constructor(private pessoaService: PessoaService) {}

  salvar() {
    let pessoa: PessoaModel = {
      id: 0,
      nome: this.nome
    }
    this.pessoaService.postPessoa(pessoa).subscribe( data => {
      this.pessoa = data;
    });
  }
}
