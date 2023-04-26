import { Directive, ElementRef } from '@angular/core';

@Directive({
  selector: '[appCustdirective]'
})
export class CustdirectiveDirective {

  constructor(private el:ElementRef) {
    el.nativeElement.style.color='green';
   }

}
