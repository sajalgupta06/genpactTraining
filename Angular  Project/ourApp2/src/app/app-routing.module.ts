import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AnimalComponent } from './animal/animal.component';
import { BindingComponent } from './binding/binding.component';
import { HomeComponent } from './home/home.component';
import { PipeexComponent } from './pipeex/pipeex.component';

const routes: Routes = [
  {path:'',component:HomeComponent},
  {path:'pipeex',component:PipeexComponent},
  {path:'binding',component:BindingComponent},
  {path:'animals',component:AnimalComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
