// app.module.ts
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';

import { AppComponent } from './app.component';
import { ExtratoContaCorrenteComponent } from './extrato-conta-corrente/extrato-conta-corrente.component';

@NgModule({
  declarations: [
    AppComponent,
    ExtratoContaCorrenteComponent
  ],
  imports: [
    BrowserModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
