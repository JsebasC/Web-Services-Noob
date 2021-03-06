﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;
using System.Linq;

public partial class indigoDBEntities : DbContext
{
    public indigoDBEntities()
        : base("name=indigoDBEntities")
    {
    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }

    public virtual DbSet<Almacen> Almacen { get; set; }
    public virtual DbSet<InventarioFisico> InventarioFisico { get; set; }
    public virtual DbSet<Producto> Producto { get; set; }
    public virtual DbSet<Proveedor> Proveedor { get; set; }
    public virtual DbSet<RemisionEntrada> RemisionEntrada { get; set; }
    public virtual DbSet<RemisionEntradaDetalle> RemisionEntradaDetalle { get; set; }

    public virtual ObjectResult<SearchAllRemisionEntrada_Result> SearchAllRemisionEntrada()
    {
        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SearchAllRemisionEntrada_Result>("SearchAllRemisionEntrada");
    }

    public virtual ObjectResult<SearchProductoYRemisionEntrada_Result> SearchProductoYRemisionEntrada(Nullable<int> idEntradaDetalle, Nullable<int> idProducto)
    {
        var idEntradaDetalleParameter = idEntradaDetalle.HasValue ?
            new ObjectParameter("idEntradaDetalle", idEntradaDetalle) :
            new ObjectParameter("idEntradaDetalle", typeof(int));

        var idProductoParameter = idProducto.HasValue ?
            new ObjectParameter("idProducto", idProducto) :
            new ObjectParameter("idProducto", typeof(int));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SearchProductoYRemisionEntrada_Result>("SearchProductoYRemisionEntrada", idEntradaDetalleParameter, idProductoParameter);
    }
}
