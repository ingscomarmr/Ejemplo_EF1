namespace Test_EF.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ControlEscolarDBContext : DbContext
    {
        public ControlEscolarDBContext()
            : base("name=ControlEscolarDBContext")
        {
        }

        public virtual DbSet<Rol> Rols { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Rol>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Rol>()
                .HasMany(e => e.Usuarios)
                .WithMany(e => e.Rols)
                .Map(m => m.ToTable("RolUsuario").MapLeftKey("RolId").MapRightKey("UsuarioId"));

            modelBuilder.Entity<Usuario>()
                .Property(e => e.NombreUsuario)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Contrasena)
                .IsUnicode(false);
        }
    }
}
