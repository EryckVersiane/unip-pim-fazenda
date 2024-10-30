import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { UsuarioRoutingModule } from './usuario-routing.module';
import { CadastroComponent } from './cadastro/cadastro.component';
import { ConsultaComponent } from './consulta/consulta.component';
import { DeletaComponent } from './deleta/deleta.component';
import { DetalhaComponent } from './detalha/detalha.component';
import { AtualizaComponent } from './atualiza/atualiza.component';
import { ReactiveFormsModule } from '@angular/forms';


@NgModule({
  declarations: [
    CadastroComponent,
    ConsultaComponent,
    DeletaComponent,
    DetalhaComponent,
    AtualizaComponent
  ],
  imports: [
    CommonModule,
    UsuarioRoutingModule,
    ReactiveFormsModule
  ]
})
export class UsuarioModule { }
