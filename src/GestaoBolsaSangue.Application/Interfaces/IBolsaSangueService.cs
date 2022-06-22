using FluentValidation.Results;
using GestaoBolsaSangue.Application.DTOs.Alterar;
using Listar = GestaoBolsaSangue.Application.DTOs.Listar;
using Obter = GestaoBolsaSangue.Application.DTOs.Obter;
using GestaoBolsaSangue.Application.DTOs.Salvar;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestaoBolsaSangue.Application.Interfaces
{
    public interface IBolsaSangueService : IDisposable
    {
        Task<IList<Listar.ListarBolsaSangueDTO>> Listar();
        Task<Obter.ObterBolsaSangueDTO> Obter(Guid id);
        Task<ValidationResult> Salvar(SalvarBolsaSangueDTO request);
        Task<ValidationResult> Alterar(AlterarBolsaSangueDTO request);
        Task<ValidationResult> Deletar(Guid id);
    }
}
