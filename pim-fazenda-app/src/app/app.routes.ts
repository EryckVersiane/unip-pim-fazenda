import { Routes } from "@angular/router";

export const routes: Routes = [
    { path: 'funcionario', loadChildren: () => import('./funcionario/funcionario.module').then(m => m.FuncionarioModule) },
    { path: 'home', loadChildren: () => import('./home/home.module').then(m => m.HomeModule) },
    { path: '', redirectTo: '/home', pathMatch: 'full' }
];