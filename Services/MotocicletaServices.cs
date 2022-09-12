using SistemaMotocicletas.Models;
using SistemaMotocicletas.Data;
namespace SistemaMotocicletas.Services
{
    public class MotocicletaServices
    {
        private readonly IRepository repository;

        public MotocicletaServices(IRepository repository)
        {
            this.repository = repository;
        }

        public async Task Crear(Motocicleta motocicleta)
        {
            await this.repository.Save(motocicleta);
                   await this.repository.Commit();
        }

          

    }
}
