using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BibliotecaClases;

namespace MvcApplication1.Controllers
{

    public class CarroController : ApiController
    {

        public static List<Carro> listadoCarros;

        // GET api/values
        public IEnumerable<Carro> Get()
        {
            if (listadoCarros == null)
            {
                listadoCarros = new List<Carro>();
                llenarListado();
            }

            return listadoCarros;
        }

        // GET api/values/5
        public Carro Get(int id)
        {
            return listadoCarros.FirstOrDefault((p) => p.ID == id);
        }

        // POST api/values
        public void Post([FromBody]int pid, [FromBody]string pmodelo, [FromBody]string panio)
        {

            listadoCarros.Add(new Carro(pid, pmodelo, panio));
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]Carro pcarro)
        {
        }

        // DELETE api/values/5
        public void Delete(int pid)
        {
            listadoCarros.RemoveAt(pid);
        }

        public void llenarListado()
        {
            listadoCarros.Add(new Carro(0, "Toyota", "2000"));
            listadoCarros.Add(new Carro(1, "Mitsubishi", "2015"));
            listadoCarros.Add(new Carro(2, "Masseratti", "2012"));
            listadoCarros.Add(new Carro(3, "Nissan", "2007"));
            listadoCarros.Add(new Carro(4, "Renault", "2008"));
            listadoCarros.Add(new Carro(5, "Hummer", "2012"));
        }
    }
}