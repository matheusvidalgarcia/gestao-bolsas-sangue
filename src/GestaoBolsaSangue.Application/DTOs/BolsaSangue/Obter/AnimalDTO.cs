using System;

namespace GestaoBolsaSangue.Application.DTOs.BolsaSangue.Obter
{
    [Serializable]
    public class AnimalDTO
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
    }
}
