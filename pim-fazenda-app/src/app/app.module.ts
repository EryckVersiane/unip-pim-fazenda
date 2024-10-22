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

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot(routes),
    AppRoutingModule,
    FormsModule,
    HomeModule,
    FuncionarioModule

  ],
  providers: [
    { provide: LocationStrategy, useClass: HashLocationStrategy},
    provideHttpClient()
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
