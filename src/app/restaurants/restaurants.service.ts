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

}
