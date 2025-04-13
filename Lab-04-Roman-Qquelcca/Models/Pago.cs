using System;
using System.Collections.Generic;

namespace Lab_04_Roman_Qquelcca.Models;

public partial class Pago
{
    public int PagoId { get; set; }

    public int? OrdenId { get; set; }

    public decimal Monto { get; set; }

    public DateTime? FechaPago { get; set; }

    public string? MetodoPago { get; set; }

    public virtual Ordene? Orden { get; set; }
}
