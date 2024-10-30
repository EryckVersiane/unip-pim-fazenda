import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { UsuarioDto } from '../dtos/usuario.dto';
import { UsuarioRequestDto } from '../dtos/usuario-request.dto';

@Injectable({
    providedIn: 'root'
})
export class UsuarioService {
    private apiUrl = '/api/v1/Usuario';

    constructor(private http: HttpClient) { }

    listar(): Observable<Array<UsuarioDto>> {
        return this.http.get<Array<UsuarioDto>>(this.apiUrl);
    }

    consultar(id: number): Observable<UsuarioDto> {
        return this.http.get<UsuarioDto>(`${this.apiUrl}/${id}`);
    }

    criar(usuarioRequest: UsuarioRequestDto): Observable<UsuarioDto> {
        return this.http.post<UsuarioDto>(this.apiUrl, usuarioRequest);
    }

   
}
