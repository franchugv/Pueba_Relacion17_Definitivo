using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseProducto
{
    public class Producto
    {
        // CONSTANTES
        // Nombre
        private const int MIN_NAME = 50;
        private const int MAX_NAME = 350;


        private const float INC_IVA = 0.21f;

        // MIEMBROS PRIVADOS
        private string _nombre;
        private float _precio;
        
        ///////////////////////////////////////////////////////////////////////
        // CONSTRUCTORES
        ///////////////////////////////////////////////////////////////////////
        /// <summary>
        /// Constructor por defecto - Sobreescribe Constructor Predeterminado
        /// </summary>
        public  Producto()
        {
            _nombre = "Desconocido";
            _precio = 0f;
        }

        /// <summary>
        /// Constructor que genera objeto e inicializa el nombre del producto
        /// </summary>
        /// <param name="nombre">Nombre del Producto</param>
        public Producto (string nombre)
        {
            _nombre = nombre;
            _precio = 0f;
        }

        /// <summary>
        /// Constructor que genera objeto inicializando el nombre y precio del producto
        /// </summary>
        /// <param name="nombre">Nombre del Producto</param>
        /// <param name="valor">Precio del Producto</param>
        public Producto (string nombre, float valor)
        {
            _nombre = nombre;
            _precio = valor;

        }
        ///////////////////////////////////////////////////////////////////////
        // PROPIEDADES
        ///////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Nombre del Producto
        /// </summary>
        public string Nombre
        {
            get { return _nombre;} 
            set { _nombre = value;}
        }

        /// <summary>
        /// Precio del Producto
        /// </summary>
        public float Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }

        /// <summary>
        /// Precio con IVA
        /// </summary>
        public float PrecioIVA
        {
            get
            {
                return CalculaPrecioIVA();
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // MÉTODOS PRIVADOS
        ///////////////////////////////////////////////////////////////////////
        /// <summary>
        /// Método que devuelve el precio con el incremento del IVA
        /// </summary>
        /// <returns>Precio del producto + IVA</returns>       
        //public float PrecioIVA()
        private float CalculaPrecioIVA()
        {
            float precioInc;

            precioInc = -1;     // Inicialización del dato

            if (_precio != 0)
            {
                precioInc = _precio + (_precio * INC_IVA); 
            }

            return precioInc;
        }


        // MÉTODOS
    }
}
