using GestaoBolsaSangue.Application.DTOs.BolsaSangue.Obter;
using System;

namespace GestaoBolsaSangue.Application.DTOs.Obter
{
    [Serializable]
    public class ObterBolsaSangueDTO
    {
        public Guid Id { get; set; }
        public ProprietarioDTO Proprietario { get; set; }
        public LocalizacaoDTO Localizacao { get; set; }
        public AnimalDTO Animal { get; set; }
        public TipoBolsaSangueDTO Tipo { get; set; }
        public int Quantidade { get; set; }
        public bool DisponibilidadeImediata { get; set; }
        public DateTime DataColeta { get; set; }
        public DateTime Validade { get; set; }
        public double Volume { get; set; }
        public string InformacoesAdicionais { get; set; }
    }
}