import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { PipeexComponent } from './pipeex/pipeex.component';
import { BindingComponent } from './binding/binding.component';
import { AnimalComponent } from './animal/animal.component';
import { NavComponent } from './nav/nav.component';
import { CustomPipePipe } from './custom-pipe.pipe';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    PipeexComponent,
    BindingComponent,
    AnimalComponent,
    NavComponent,
    CustomPipePipe
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
