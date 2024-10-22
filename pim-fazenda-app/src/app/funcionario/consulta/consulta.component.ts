import { Component, OnInit } from '@angular/core';
import { PessoaModel } from '../../models/pessoa.model';
import { PessoaService } from '../../pessoa.service';

@Component({
  selector: 'app-consulta',
  templateUrl: './consulta.component.html',
  styleUrl: './consulta.component.scss'
})
export class ConsultaComponent implements OnInit {
  
  pessoas: Array<PessoaModel> = [];

  constructor(private pessoaService: PessoaService) {}
  
  ngOnInit(): void {
    this.consultar()
  }

  consultar() {
    this.pessoaService.getPessoas().subscribe( data => {
      this.pessoas = data;
    });
  }

  
}
