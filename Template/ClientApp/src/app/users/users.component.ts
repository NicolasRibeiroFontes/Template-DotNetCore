import { Component, OnInit } from '@angular/core';
import { UserDataService } from '../_data-services/user.data-service';

@Component({
  selector: 'app-users',
  templateUrl: './users.component.html',
  styleUrls: ['./users.component.css']
})
export class UsersComponent implements OnInit {

  users: any[] = [];
  user: any = {};
  userLogin: any = {};
  userLogged: any = {};
  showList: boolean = true;
  isAuthenticated: boolean = false;

  constructor(private userDataService: UserDataService) { }

  ngOnInit() {
    
  }

  get() {
    this.userDataService.get().subscribe((data:any[]) => {
      this.users = data;
      this.showList = true;
    }, error => {
        console.log(error);
        alert('erro interno do sistema');
    })
  }

  save() {
    if (this.user.id) {
      this.put();
    } else {
      this.post();
    }    
  }

  openDetails(user) {
    this.showList = false;
    this.user = user;
  }

  post() {
    this.userDataService.post(this.user).subscribe(data => {
      if (data) {
        alert('Usuário cadastrado com sucesso');
        this.get();
        this.user = {};
      } else {
        alert('Erro ao cadastrar usuário');
      }
    }, error => {
      console.log(error);
      alert('erro interno do sistema');
    })
  }

  put() {
    this.userDataService.put(this.user).subscribe(data => {
      if (data) {
        alert('Usuário atualizado com sucesso');
        this.get();
        this.user = {};
      } else {
        alert('Erro ao atualizar usuário');
      }
    }, error => {
      console.log(error);
      alert('erro interno do sistema');
    })
  }

  delete() {
    this.userDataService.delete().subscribe(data => {
      if (data) {
        alert('Usuário excluído com sucesso');
        this.get();
        this.user = {};
      } else {
        alert('Erro ao excluir usuário');
      }
    }, error => {
      console.log(error);
      alert('erro interno do sistema');
    })
  }

  authenticate() {
    this.userDataService.authenticate(this.userLogin).subscribe((data:any) => {
      if (data.user) {
        localStorage.setItem('user_logged', JSON.stringify(data));
        this.get();
        this.getUserData();
      } else {
        alert('User invalid.');
      }      
    }, error => {
      console.log(error);
        alert('User invalid');
    })
  }

  getUserData() {
    this.userLogged = JSON.parse(localStorage.getItem('user_logged'));
    this.isAuthenticated = this.userLogged != null;
  }

}
