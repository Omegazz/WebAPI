using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BibliotecaClases
{
    public class Carro
    {
        #region Atributos

        private int _ID;
        private string _marca;
        private string _anio;

        #endregion

        #region Constructores

        public Carro (){}

        public Carro(int pID, string pnombre, string papellido)
        {
            ID = pID;
            Nombre = pnombre;
            Apellidos = papellido;
        }

        #endregion

        #region Sets y Gets

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        public string Nombre
        {
            get { return _marca; }
            set { _marca = value; }
        }

        public string Apellidos
        {
            get { return _anio; }
            set { _anio = value; }
        }

        #endregion
        
    }
}
