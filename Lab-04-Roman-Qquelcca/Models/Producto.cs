using System;
using System.Collections.Generic;

namespace Lab_04_Roman_Qquelcca.Models;

public partial class Producto
{
    public int ProductoId { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public decimal Precio { get; set; }

    public int Stock { get; set; }

    public int? CategoriaId { get; set; }

    public virtual Categoria? Categoria { get; set; }

    public virtual ICollection<Detallesorden> Detallesordens { get; set; } = new List<Detallesorden>();
}
