// extrato-conta-corrente.component.ts
import { Component } from '@angular/core';

@Component({
  selector: 'app-extrato-conta-corrente',
  templateUrl: './extrato-conta-corrente.component.html',
  styleUrls: ['./extrato-conta-corrente.component.css']
})
export class ExtratoContaCorrenteComponent {
  lancamentos = [
    { data: '2023-01-01', descricao: 'Produtos', valor: 100.0, tipo: 'credito' }
  ];

  novoLancamento = {
    data: '',
    descricao: '',
    valor: 0.0,
    tipo: 'credito'
  };

  editarLancamento(lancamento: any) {
    // editar o lançamento
  }

  cancelarLancamento(lancamento: any) {
    // cancelar o lançamento
  }

  salvarLancamento() {
    // salvar um novo lançamento
    this.lancamentos.push({ ...this.novoLancamento });
    this.novoLancamento = {
      data: '',
      descricao: '',
      valor: 0.0,
      tipo: 'credito'
    };
  }
}
