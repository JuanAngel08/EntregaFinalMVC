namespace SistemaMotocicletas.Models
{
    public class Motocicleta : Entity
    {

        public string MarcaMotocicleta { get; private set; }
        public string CCMotocicleta { get; private set;}
        public string PlacaMotocicleta { get; private set;}

        public DateTime FechaDeIngreso { get; private set; }


        public Taller Taller { get; private set; }

        //Lista

        public Guid MotocicletaId { get; private set; }


        //Constructor   1

        private Motocicleta(): base ()
        {

        }

        private Motocicleta(Guid id,string marcaMotocicleta, string ccMotocicleta, string placaMotocicleta, DateTime fechaDeIngreso, Guid motocicletaId) : base(id)
        {
            MarcaMotocicleta = marcaMotocicleta;
            CCMotocicleta = ccMotocicleta;
            PlacaMotocicleta = placaMotocicleta;
            FechaDeIngreso = fechaDeIngreso;
            MotocicletaId = motocicletaId;
        }


        //build
        public Motocicleta Build(Guid id, string marcaMotocicleta, string ccMotocicleta, string placaMotocicleta, DateTime fechaDeIngreso,Guid motocicletaId)
        {

            return new Motocicleta(id,marcaMotocicleta, ccMotocicleta, placaMotocicleta, fechaDeIngreso, motocicletaId);
        }
    }
}
