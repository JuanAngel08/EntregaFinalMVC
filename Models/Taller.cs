namespace SistemaMotocicletas.Models
{
    public class Taller :Entity
    {


        public string NombreTaller { get; private set; }
        public string DireccionTaller { get; private  set; }
        public string ZonaTaller { get; private set; }

        //Lista
        public  List <Motocicleta> Motocicletas { get; private set; }

        //Constructor1
        private Taller():base() 
        {


        }

        //Constructor 2
        private Taller(Guid id,string nombreTaller, string direccionTaller, string zonaTaller): base(id)
        {
            NombreTaller = nombreTaller;
            DireccionTaller = direccionTaller;
            ZonaTaller = zonaTaller;
        }

      
        //patron builder

        public static Taller Build(Guid id, string nombreTaller, string direccionTaller, string zonaTaller)
        {
            return new Taller(id, nombreTaller, direccionTaller, zonaTaller);
        }


    }
}
