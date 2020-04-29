import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs/operators';
import { IDeliveryMethod } from '../shared/models/deliveryMethod';

@Injectable({
  providedIn: 'root',
})
export class CheckoutService {
  baseUrl = environment.apiUrl;

  constructor(private http: HttpClient) {}

  getDeliveryMethods() {
    return this.http.get(this.baseUrl + 'orders/deliveryMethods').pipe(
      map((deliveryMethods: IDeliveryMethod[]) => {
        return deliveryMethods.sort((a, b) => b.price - a.price);
      })
    );
  }
}
