import { Component, OnInit } from '@angular/core';
import { UsuarioService } from '../../services/usuario.service';
import { UsuarioDto } from '../../dtos/usuario.dto';

@Component({
  selector: 'app-usuario-consulta',
  templateUrl: './consulta.component.html',
  styleUrl: './consulta.component.scss'
})
export class ConsultaComponent implements OnInit {

  usuarios: Array<UsuarioDto> = [];

  constructor(private service: UsuarioService) {}


  ngOnInit(): void {
    this.listarUsuarios();
  }


  listarUsuarios() {
    this.service.listar().subscribe( response => {
      this.usuarios = response;
    })
  }
  

}
