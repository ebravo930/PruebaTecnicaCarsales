// src/app/app.module.ts

import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { AppComponent } from './app.component';
import { CharacterListComponent } from './components/character-list/character-list.component';  // Verifica la ruta de importación
import { RickAndMortyService } from './services/rick-and-morty.service';

@NgModule({
  declarations: [
    AppComponent,
    CharacterListComponent,
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
  ],
  providers: [RickAndMortyService],
  bootstrap: [AppComponent],
})
export class AppModule {}
