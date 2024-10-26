import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HashLocationStrategy, LocationStrategy } from '@angular/common';
import { HomeModule } from './home/home.module';
import { FuncionarioModule } from './funcionario/funcionario.module';
import { RouterModule } from '@angular/router';
import { routes } from './app.routes';
import { provideHttpClient } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { ReactiveFormsModule } from '@angular/forms';
import { LoginComponent } from './login/login.component';

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot(routes),
    AppRoutingModule,
    FormsModule,
    HomeModule,
    FuncionarioModule,
    ReactiveFormsModule

  ],
  providers: [
    { provide: LocationStrategy, useClass: HashLocationStrategy},
    provideHttpClient()
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }


