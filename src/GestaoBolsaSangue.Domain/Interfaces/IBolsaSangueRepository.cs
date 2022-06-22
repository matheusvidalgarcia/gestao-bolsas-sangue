using GestaoBolsaSangue.Domain.Models;
using core.Repository;
using System.Threading.Tasks;

namespace GestaoBolsaSangue.Domain.Interfaces
{
    public interface IBolsaSangueRepository : IRepository<BolsaSangue>
    {
        Task<BolsaSangue> GetByEmail(string email);
    }
}
