import { MenuItem } from './../restaurant-detail/menu-item/menu-item.model';
import { Injectable } from '@angular/core'
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs'
import { catchError } from 'rxjs/operators'
import { ErrorHandler } from '../app.erro-handler'

import { Restaurant } from './restaurant/restaurant.model'

import { MEAT_API } from '../app.api'

@Injectable()
export class RestaurantsService {

  constructor(private http: HttpClient) {}

  restaurants(): Observable<Restaurant[]> {
    return this.http.get<Restaurant[]>(`${MEAT_API}/restaurants`)
      .pipe(
        catchError(e => ErrorHandler.handleError(e))
      )
  }

  restaurantsById(id: string): Observable<Restaurant> {
    return this.http.get<Restaurant>(`${MEAT_API}/restaurants/${id}`)
      .pipe(
        catchError(e => ErrorHandler.handleError(e))
      )
  }

  reviewsOfRestaurant(id: string): Observable<any> {
    return this.http.get(`${MEAT_API}/restaurants/${id}/reviews`)
      .pipe(
        catchError(e => ErrorHandler.handleError(e))
      )
  }

  menuOfRestaurant(id:string): Observable<MenuItem[]> {
    return this.http.get<MenuItem[]>(`${MEAT_API}/restaurants/${id}/menu`)
    .pipe(
      catchError(e => ErrorHandler.handleError(e))
    )
  }

}
