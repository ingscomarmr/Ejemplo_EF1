namespace Test_EF.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("Usuario")]
    public partial class Usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuario()
        {
            Rols = new HashSet<Rol>();
        }

        public int UsuarioId { get; set; }

        [Column("NombreUsuario")]
        [Required]
        [StringLength(50)]
        public string NombreUsuario { get; set; }

        [StringLength(250)]
        public string Contrasena { get; set; }

        public byte BajaLogica { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rol> Rols { get; set; }

        
    }
}
