import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Person } from '../models/person';

@Injectable({
  providedIn: 'root'
})
export class PersonService {

  constructor(private http:HttpClient) { }

  getAllPersons():Observable<Person[]>{
    return this.http.get<Person[]>("http://localhost:56227/api/person")
  }
}
