using System;
using System.Collections.Generic;

namespace Lab_04_Roman_Qquelcca.Models;

public partial class Ordene
{
    public int OrdenId { get; set; }

    public int? ClienteId { get; set; }

    public DateTime? FechaOrden { get; set; }

    public decimal Total { get; set; }

    public virtual Cliente? Cliente { get; set; }

    public virtual ICollection<Detallesorden> Detallesordens { get; set; } = new List<Detallesorden>();

    public virtual ICollection<Pago> Pagos { get; set; } = new List<Pago>();
}
