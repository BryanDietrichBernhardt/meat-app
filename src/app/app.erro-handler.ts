import { throwError } from 'rxjs'
import { HttpErrorResponse } from '@angular/common/http'

export class ErrorHandler {
  static handleError(error: HttpErrorResponse ) {
    if (error.status === 0){
      console.error('Esqueceu de rodar a API, cabeção!');
    }else {
      console.error(`API retornou o código ${error.status}, corpo da resposta: `, error.error);
    }
    return throwError(error)
  }
}
