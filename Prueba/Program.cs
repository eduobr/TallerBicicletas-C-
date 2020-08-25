
using Prueba.ServiceMasterBikes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ServiceMasterBikes.ServicioClient servicio_producto = new ServiceMasterBikes.ServicioClient();
                IEnumerable<Cl_Producto> listaProd = servicio_producto.obtenerProductos();
                foreach (var item in listaProd)
                {
                    Console.WriteLine(item.idProducto+" "+item.nombre+" "+item.modelo+" "+item.descripcion+" "+item.precio+" "+item.foto+" "+item.descuento+" "+item.stock);

                }
                Console.ReadKey();
                //Buscar como cerrar la conexión
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                Console.ReadKey();
            }

        }
    }
}
