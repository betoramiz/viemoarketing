import { Component } from '@angular/core';
import { faTwitter, faGoogle } from '@fortawesome/free-brands-svg-icons';
import { faMedal } from '@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'app-signup',
  templateUrl: './signup.component.html',
  styleUrls: ['./signup.component.css']
})
export class SignupComponent {
  faTwitter = faTwitter;
  faGoogle = faGoogle;
  faMedal = faMedal;
}
