import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";

@Injectable()
export class UserDataService {

  module: string = '/api/users';

  constructor(private http: HttpClient) { }

  get() {
    return this.http.get(this.module);
  }

  post(data) {
    return this.http.post(this.module, data);
  }

  put(data) {
    return this.http.put(this.module, data);
  }

  delete() {
    return this.http.delete(this.module);
  }

  authenticate(data) {
    return this.http.post(this.module + '/authenticate', data);
  }

}
