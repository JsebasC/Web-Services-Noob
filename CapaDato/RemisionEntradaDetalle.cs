//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaDato
{
    using System;
    using System.Collections.Generic;
    
    public partial class RemisionEntradaDetalle
    {
        public int Id { get; set; }
        public int IdRemisionEntrada { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
    
        public virtual Producto Producto { get; set; }
        public virtual RemisionEntrada RemisionEntrada { get; set; }
    }
}