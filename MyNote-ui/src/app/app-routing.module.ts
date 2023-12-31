import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { MasterViewComponent } from './shared/components/master-view/master-view.component';
import homeRoutes from './modules/home/home.routes'
import accountRoutes from './modules/account/account.routes'
import userRoutes from './modules/user/user.routes'
const routes: Routes = [
  {
    path: '',
    component: MasterViewComponent,
    children:[
      ...homeRoutes,
      ...accountRoutes,
      ...userRoutes,
    ]
  },
  {path: '**', redirectTo: 'home'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }