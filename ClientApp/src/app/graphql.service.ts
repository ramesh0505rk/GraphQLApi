import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class GraphqlService {
  private apiUrl = 'https://localhost:44327/graphql';

  constructor(private http: HttpClient) { }
  fetchBooks(): Observable<any> {
    const query = `query{
        books{cls
          id
          title
          author
        }
      }`
    return this.http.post<any>(this.apiUrl, query);
  }
}
