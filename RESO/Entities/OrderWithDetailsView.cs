using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RESO.Entities;

[Keyless]
public partial class OrderWithDetailsView
{
    public int OrderId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime OrderDate { get; set; }

    [StringLength(100)]
    public string CustomerEmail { get; set; } = null!;

    public int ProductId { get; set; }

    [StringLength(50)]
    public string ProductName { get; set; } = null!;

    [Column(TypeName = "decimal(18, 2)")]
    public decimal UnitPrice { get; set; }

    public int Quantity { get; set; }

    public override string ToString()
    {
        return $"OrderId ={OrderId}, CustomerEmail= {CustomerEmail} \n" +
            $" UnitPrice : " +
            $" {UnitPrice:C} , Quantity :   " +
            $"{Quantity}\n Total = " +
            $"{UnitPrice * Quantity:C} ";
    }
}
