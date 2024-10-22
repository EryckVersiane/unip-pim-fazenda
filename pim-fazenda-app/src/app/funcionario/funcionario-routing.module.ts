import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CadastroComponent } from './cadastro/cadastro.component';
import { ConsultaComponent } from './consulta/consulta.component';
import { DetalhaComponent } from './detalha/detalha.component';
import { DeletaComponent } from './deleta/deleta.component';

const routes: Routes = [
  {path: 'cadastro', component: CadastroComponent},
  {path: 'consulta', component: ConsultaComponent},
  {path: 'detalha', component: DetalhaComponent},
  {path: 'deleta', component: DeletaComponent},
  {path: '', redirectTo: 'cadastro', pathMatch: 'full' }

];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class FuncionarioRoutingModule { }
