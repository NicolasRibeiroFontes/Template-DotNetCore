import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";

@Injectable()
export class UserDataService {

  module: string = '/api/users';

  constructor(private http: HttpClient) { }

  get() {
    return this.http.get(this.module);
  }

}
