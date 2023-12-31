import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './modules/home/home.component';
import { AccountComponent } from './modules/account/account.component';
import { UserComponent } from './modules/user/user.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { SidebarComponent } from './shared/components/sidebar/sidebar.component';
import { MatSidenavModule, } from '@angular/material/sidenav';
import {MatIconModule} from '@angular/material/icon';
import { MasterViewComponent } from './shared/components/master-view/master-view.component';

import {MatListModule} from '@angular/material/list';
import { OnHoverDirective } from './shared/directives/on-hover/on-hover.directive';
import { HeaderComponent } from './shared/components/header/header.component';
import { FooterComponent } from './shared/components/footer/footer.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    AccountComponent,
    UserComponent,
    SidebarComponent,
    MasterViewComponent,
    OnHoverDirective,
    HeaderComponent,
    FooterComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatSidenavModule,
    MatIconModule,
    MatListModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
