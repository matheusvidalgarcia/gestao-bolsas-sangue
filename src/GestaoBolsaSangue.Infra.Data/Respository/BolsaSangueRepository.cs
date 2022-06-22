using GestaoBolsaSangue.Domain.Interfaces;
using core.Repository;
using core.Repository.Mongo;
using System.Threading.Tasks;
using MongoDB.Driver;
using GestaoBolsaSangue.Domain.Models;
using core.Repository.UnitOfWork;

namespace GestaoBolsaSangue.Infra.Data.Respository
{
    public class BolsaSangueRepository : BaseRepository<Domain.Models.BolsaSangue>, IBolsaSangueRepository
    {
        protected readonly IMongoContext Db;
        public BolsaSangueRepository(IMongoContext context) : base(context)
        {
            Db = context;
        }

        public override IUnitOfWork UnitOfWork => Db;

        public virtual async Task<BolsaSangue> GetByEmail(string email)
        {
            var data = await DbSet.FindAsync(Builders<BolsaSangue>.Filter.Eq("Email", email));
            return data.FirstOrDefault();
        }
    }
}