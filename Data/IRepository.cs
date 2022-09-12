using SistemaMotocicletas.Models;


namespace SistemaMotocicletas.Data

{
    public interface IRepository
    {
        //Se agrega <T> para volverlo un metodo generico + la restriccion
        //Metodo guardar

        //Se cambia el void por el task para ser asincrono
        public Task Save<T>(T obj) where T:Entity; //Aqui se crea la sentencia de guardado
        //Metodo Eliminar
        public void Delete<T>(T obj) where T:Entity;
        //Metodo Actualizar
        public void Update<T>(T obj) where T:Entity;
        //Metodo obtener todo
        public Task<List<T>>GetAll<T>()where T:Entity;


        //Metodo para ejecutar el guardado

        public Task Commit();//Aqui se ejecuta la sentencia de guardado
    }
}
