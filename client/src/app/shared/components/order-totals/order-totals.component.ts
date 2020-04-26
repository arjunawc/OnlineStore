import { Component, OnInit } from '@angular/core';
import { IBasketTotal } from '../../models/basket';
import { Observable } from 'rxjs';
import { BasketService } from 'src/app/basket/basket.service';

@Component({
  selector: 'app-order-totals',
  templateUrl: './order-totals.component.html',
  styleUrls: ['./order-totals.component.scss'],
})
export class OrderTotalsComponent implements OnInit {
  basketTotal$: Observable<IBasketTotal>;

  constructor(private basketService: BasketService) {}

  ngOnInit(): void {
    this.basketTotal$ = this.basketService.basketTotal$;
  }
}
