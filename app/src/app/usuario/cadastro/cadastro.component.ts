import { Component } from '@angular/core';
import { UsuarioRequestDto } from '../../dtos/usuario-request.dto';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { UsuarioDto } from '../../dtos/usuario.dto';
import { UsuarioService } from '../../services/usuario.service';

@Component({
  selector: 'app-usuario-cadastro',
  templateUrl: './cadastro.component.html',
  styleUrl: './cadastro.component.scss'
})
export class CadastroComponent {
  usuarioForm: FormGroup;
  usuarios: Array<UsuarioDto> = [];

  constructor(
    private fb: FormBuilder,
    private usuarioService: UsuarioService
  ) {
    this.usuarioForm = this.fb.group({
      nome: ['', Validators.required],
      telefone: ['', Validators.required],
      cpf: ['', Validators.required],
      email: ['', [Validators.required, Validators.email]],
      senha: ['', Validators.required]
    });
  }

  ngOnInit(): void {
    this.listarUsuarios();
  }

  listarUsuarios() {
    this.usuarioService.listar().subscribe( response => {
        this.usuarios = response;
      }
    );
  }

  onSubmit() {
    let usuarioRequest: UsuarioRequestDto = {
      nome: this.usuarioForm.controls['nome'].value,
      cpf: this.usuarioForm.controls['cpf'].value,
      telefone: this.usuarioForm.controls['telefone'].value,
      email: this.usuarioForm.controls['email'].value,
      senha: this.usuarioForm.controls['senha'].value
    };

    this.usuarioService.criar(usuarioRequest).subscribe( response => {
      this.listarUsuarios();
    });
    
  }
}
