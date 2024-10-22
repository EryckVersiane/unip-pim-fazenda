import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { FuncionarioRoutingModule } from './funcionario-routing.module';
import { CadastroComponent } from './cadastro/cadastro.component';
import { ConsultaComponent } from './consulta/consulta.component';
import { DetalhaComponent } from './detalha/detalha.component';
import { DeletaComponent } from './deleta/deleta.component';
import { FormsModule } from '@angular/forms';


@NgModule({
  declarations: [
    CadastroComponent,
    ConsultaComponent,
    DetalhaComponent,
    DeletaComponent
  ],
  imports: [
    CommonModule,
    FormsModule,
    FuncionarioRoutingModule
  ]
})
export class FuncionarioModule { }
