namespace SistemaMotocicletas.Models
{
    public abstract class Entity
    {

        public Guid Id { get; protected set; }

        //Constructor 1
        protected Entity()
        {

        }

        //Constructor para los parametros que se tienen
        protected Entity(Guid id)
        {

            Id = id;

        }


    }
}
