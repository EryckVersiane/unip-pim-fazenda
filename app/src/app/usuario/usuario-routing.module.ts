import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ConsultaComponent } from './consulta/consulta.component';
import { CadastroComponent } from './cadastro/cadastro.component';
import { DetalhaComponent } from './detalha/detalha.component';

const routes: Routes = [
  {path: 'consulta', component: ConsultaComponent},
  {path: 'cadastro', component: CadastroComponent},
  {path: 'detalhe', component: DetalhaComponent},
  {path: 'detalhe', component: DetalhaComponent},
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class UsuarioRoutingModule { }
