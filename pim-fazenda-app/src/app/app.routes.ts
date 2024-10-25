import { Routes } from "@angular/router";


export const routes: Routes = [
    { path: 'funcionario', loadChildren: () => import('./funcionario/funcionario.module').then(m => m.FuncionarioModule) },
    { path: 'home', loadChildren: () => import('./home/home.module').then(m => m.HomeModule) },
    { path: '', redirectTo: '/home', pathMatch: 'full' },
    { path: 'login', loadChildren: () => import('./login/login.module').then(m => m.LoginModule) },
    { path: '', redirectTo: '/login', pathMatch: 'full' },
    { path: 'cadastro', loadChildren: () => import('../app/funcionario/cadastro/cadastro.module').then(m => m.CadastroModule)},
];