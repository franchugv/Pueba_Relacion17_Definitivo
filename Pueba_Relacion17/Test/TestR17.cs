using ClaseProducto;

namespace Pueba_Relacion17
{
    public class Tests
    {


        [Test]
        public void ValidarConstructorDefecto()
        {

            // Validar datos
            Producto producto = new Producto();

            // Validar que los datos no sean vac�os, debe ser "desconocidos"
            Assert.IsNotNull(producto);

            // S� no es desconocido, el Asser dar� error, el precio IVA est� inicializado a -1
            if (producto.Nombre != "Desconocido" | producto.Precio != 0 | producto.PrecioIVA != -1) Assert.Fail();

                
            // Validaci�n de las propiedades
            // Validar que la propiedad est� asignada

            Assert.IsNotNull(producto.Nombre);

            Assert.IsNotNull(producto.Precio);





        }
       
        [Test]
        public void ValidarConstructorNombre()
        {
            Producto productoNombre = new Producto("Fran");

            // Validar que el precio no sea nulo
            Assert.IsNotNull(productoNombre.Precio);
        }

        [Test]
        public void ValidarConstructorCompleto()
        {
            Producto producto = new Producto("Fran", 40);

            // Validar que se calcule el precio IVA
            Assert.AreNotEqual(producto.Precio, producto.PrecioIVA);

            // Validar Precio IVA y verificar que la propiedad funcione correctamente
            producto.Precio = 20;
            Assert.AreEqual(producto.PrecioIVA, 24.2f);

        }
    }
}