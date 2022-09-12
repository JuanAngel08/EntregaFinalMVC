using SistemaMotocicletas.Models;
using SistemaMotocicletas.Data;
namespace SistemaMotocicletas.Services
{
    public class TallerServices
    {

        private readonly IRepository repository;

        public TallerServices(IRepository repository)
        {
            this.repository = repository;
        }

        public async Task Crear(Taller taller )
        {

            if (taller is null)
                throw new Exception("Taller es nulo");

            await this.repository.Save(taller);
            await this.repository.Commit();
        }

        public async Task<List<Taller>> GetAllTalleres()
        {
            return await this.repository.GetAll<Taller>();
        }



    }
}
