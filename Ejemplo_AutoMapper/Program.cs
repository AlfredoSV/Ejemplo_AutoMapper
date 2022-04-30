using AutoMapper;
using System;

namespace Ejemplo_AutoMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new MapperConfiguration(cfn => cfn.CreateMap<Persona,DtoPersona>());

            var mapper = config.CreateMapper();

            var persona = new Persona() { Id = Guid.NewGuid(), Nombre ="Alfredo" };

            var dtoPersona = mapper.Map<DtoPersona>(persona);


            Console.WriteLine($"Nombre:"+dtoPersona.Nombre);
            Console.WriteLine($"Id:" + dtoPersona.Id);

        }
    }

    public class DtoPersona
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
    }
    public class Persona
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
    }

}
