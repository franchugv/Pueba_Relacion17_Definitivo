using ClaseProducto;

namespace Pueba_Relacion17
{
    public class Tests
    {


        public void ValidarConstructorDefecto()
        {

            // Validar datos
            Producto producto = new Producto();

            // Validar que los datos no sean vac�os, debe ser "desconocidos"
            Assert.IsNotNull(producto);
            // S� no es desconocido, el Asser dar� error, el precio IVA est� inicializado a -1
            if (producto.Nombre != "Desconocido" | producto.Precio != 0 | producto.PrecioIVA != -1) Assert.Fail();
        }
       
        [Test]
        public void ValidarConstructorNombre()
        {
            Producto productoNombre = new Producto("Fran");
            // Validar que el precio no sea nulo
            if (productoNombre.Precio != 0 | productoNombre.PrecioIVA != -1) Assert.Fail();
        }

        [Test]
        public void ValidarConstructorCompleto()
        {
            Producto producto = new Producto("Fran", 20);
            // Validar que se calcule el precio IVA
            Assert.AreNotEqual(producto.Precio, producto.PrecioIVA);
            // Validar Precio IVA
            Assert.AreEqual(producto.PrecioIVA, 24.2f);

        }

        [Test]
        public void ValidarPrecio()
        {
            // La precio del producto debe estar entre 50 y 350 � (50 y 350 incluidos)
            Producto producto = new Producto("Fran", 50);
            // Vamos a validar que el precio no sea mayor que 350
            Assert.LessOrEqual(producto.Precio, 350);
            // Vamos a validar que el precio no sea menor a 50
            Assert.GreaterOrEqual(producto.Precio, 50);

        }
    }
}