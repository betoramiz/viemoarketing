import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LoginComponent } from './login/login.component';
import { SecurityRoutingModule } from './security-routing.module';
import { MatCardModule } from '@angular/material/card';
import { MatButtonModule } from '@angular/material/button';
import { MatInputModule } from '@angular/material/input';
import { MatIconModule } from '@angular/material/icon';
import { SignupComponent } from './signup/signup.component';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { CreateComponent } from './create/create.component';



@NgModule({
  declarations: [
    LoginComponent,
    SignupComponent,
    CreateComponent,
  ],
    imports: [
        CommonModule,
        SecurityRoutingModule,
        MatCardModule,
        MatButtonModule,
        MatInputModule,
        MatIconModule,
        FontAwesomeModule
    ]
})
export class SecurityModule { }
