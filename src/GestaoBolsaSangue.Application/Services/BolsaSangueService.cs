﻿using AutoMapper;
using core.Patterns.MediatR;
using FluentValidation.Results;
using GestaoBolsaSangue.Application.DTOs.Alterar;
using Listar = GestaoBolsaSangue.Application.DTOs.Listar;
using Obter = GestaoBolsaSangue.Application.DTOs.Obter;
using GestaoBolsaSangue.Application.DTOs.Salvar;
using GestaoBolsaSangue.Application.Interfaces;
using GestaoBolsaSangue.Domain.Commands;
using GestaoBolsaSangue.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestaoBolsaSangue.Application.Services
{
    public class BolsaSangueService : IBolsaSangueService
    {
        private readonly IMapper _mapper;
        private readonly IMediatorHandler _mediator;
        private readonly IBolsaSangueRepository _repository;
        public BolsaSangueService(IBolsaSangueRepository BolsaSangueRepository, IMapper mapper, IMediatorHandler mediator)
        {
            _repository = BolsaSangueRepository;
            _mapper = mapper;
            _mediator = mediator;
        }
        public async Task<ValidationResult> Salvar(SalvarBolsaSangueDTO request)
        {
            var bolsaSangueModel = _mapper.Map<Domain.Models.BolsaSangue>(request);
            var salvarCommand = new SalvarBolsaSangueCommand(bolsaSangueModel);

            return await _mediator.SendCommand(salvarCommand);
        }

        public async Task<IList<Listar.ListarBolsaSangueDTO>> Listar()
        {
            var responseRepository = await _repository.GetAll();
            return _mapper.Map<IList<Listar.ListarBolsaSangueDTO>>(responseRepository);
        }

        public async Task<Obter.ObterBolsaSangueDTO> Obter(Guid id)
        {
            var responseRepository = await _repository.GetById(id);
            return _mapper.Map<Obter.ObterBolsaSangueDTO>(responseRepository);
        }

        public async Task<ValidationResult> Alterar(AlterarBolsaSangueDTO request)
        {
            var BolsaSangueModel = _mapper.Map<Domain.Models.BolsaSangue>(request);
            var alterarCommand = new AlterarBolsaSangueCommand(BolsaSangueModel);

            return await _mediator.SendCommand(alterarCommand);
        }

        public async Task<ValidationResult> Deletar(Guid id)
        {
            var deletarCommand = new DeletarBolsaSangueCommand(id);
            return await _mediator.SendCommand(deletarCommand);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
