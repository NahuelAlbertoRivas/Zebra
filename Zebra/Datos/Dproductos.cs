using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Zebra.Modelo;
using Zebra.Conexiones;

namespace Zebra.Datos
{
    public class Dproductos
    {
        public async Task <List<Mproductos>>Mostrarproductos()
        {
            return (await Cconexion.firebase
                .Child("Productos")
                .OnceAsync<Mproductos>()).Select(item => new Mproductos
                {
                    Descripcion = item.Object.Descripcion,
                    Icono = item.Object.Icono,
                    Tipo = item.Object.Tipo,
                    Idproducto = item.Key
                }).ToList();
        }
    }
}
