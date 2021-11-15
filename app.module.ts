import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import routes,{ AppRoutingModule } from './app-routing.module';
import { MyloginService } from './mylogin.service';
import { RouterModule } from '@angular/router';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { LoginComponent } from './login/login.component';


@NgModule({
  declarations: [
    AppComponent,
    LoginComponent

  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule,
    RouterModule.forRoot(routes),
    FormsModule
   
  ],
  providers: [MyloginService],
  bootstrap: [AppComponent]
})
export class AppModule { }
