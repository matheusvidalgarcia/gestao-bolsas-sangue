﻿using core.API;
using GestaoBolsaSangue.Application.DTOs.Alterar;
using GestaoBolsaSangue.Application.DTOs.Salvar;
using GestaoBolsaSangue.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace GestaoBolsaSangue.WebApi.Controllers
{
    public class BolsaSangueController : ApiController
    {
        private readonly IBolsaSangueService _service;
        public BolsaSangueController(IBolsaSangueService service)
        {
            _service = service;
        }

        [HttpPost]
        [Route("BolsaSangue")]
        public async Task<IActionResult> Salvar([FromBody] SalvarBolsaSangueDTO request)
        {
            if (!ModelState.IsValid)
                return ResponseRequetErrors();

            var response = await _service.Salvar(request);
            return ResponseHttp(response);
        }

        [HttpPut]
        [Route("BolsaSangue")]
        public async Task<IActionResult> Alterar([FromBody] AlterarBolsaSangueDTO request)
        {
            if (!ModelState.IsValid)
                return ResponseRequetErrors();

            var response = await _service.Alterar(request);
            return ResponseHttp(response);
        }

        [HttpDelete]
        [Route("BolsaSangue/{id:guid}")]
        public async Task<IActionResult> Deletar(Guid id)
        {
            var response = await _service.Deletar(id);
            return ResponseHttp(response);
        }

        [HttpGet]
        [Route("BolsasSangue")]
        public async Task<IActionResult> Listar()
        {
            var response = await _service.Listar();
            return ResponseHttp(response);
        }

        [HttpGet]
        [Route("BolsaSangue/{id:guid}")]
        public async Task<IActionResult> Obter(Guid id)
        {
            var response = await _service.Obter(id);
            return ResponseHttp(response);
        }
    }
}
