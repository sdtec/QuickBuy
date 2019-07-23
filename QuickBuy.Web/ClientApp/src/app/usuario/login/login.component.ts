import { Component } from "@angular/core";
import { usuario } from "../../modelo/usuario";

@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.css"]
})
export class LoginComponent {

  public usuario;

  constructor() {
    this.usuario = new usuario();
  }

  entrar() {
    if (this.usuario.email == "leo@teste.com" && this.usuario.senha == "abc123") {
    }
  }
}
