import { Component } from '@angular/core';
import { Heroclass } from '../heroclass';

@Component({
  selector: 'app-heroform',
  templateUrl: './heroform.component.html',
  styleUrls: ['./heroform.component.css']
})
export class HeroformComponent {
  submitted = false;
  onSubmit() {this.submitted = true;}
  model:any ="";
  get diagnostic()
  {
    return JSON.stringify(this.model);
  }
}
