import { Routes } from "@angular/router";


export const routes: Routes = [
    { path: 'home', loadChildren: () => import('./home/home.module').then(m => m.HomeModule) },
    { path: 'usuario', loadChildren: () => import('./usuario/usuario.module').then(m => m.UsuarioModule) },
    { path: '', redirectTo: '/home', pathMatch: 'full' },
];