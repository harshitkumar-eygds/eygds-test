import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'poundinr'
})
export class PoundinrPipe implements PipeTransform {

  transform(value: number, ...args: number[]): unknown {
    const[price] = args;
    return value * price;
  }

}
