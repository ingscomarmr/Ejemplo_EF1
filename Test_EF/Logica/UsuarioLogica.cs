using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_EF.Model;
using Test_EF.Beans;

namespace Test_EF.Logica
{
    class UsuarioLogica
    {
        public List<UsuarioBean> GetUsuarios()
        {
            List<UsuarioBean> uList = new List<UsuarioBean>();
            try
            {
                using (var ctx = new ControlEscolarDBContext())
                {
                    List<Usuario> userioList = ctx.Usuarios.ToList();
                    foreach (Usuario u in userioList) {
                        uList.Add(new UsuarioBean { Id = u.UsuarioId, Password = u.Contrasena, Usuario = u.NombreUsuario });
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return uList;
        }

        public void Eliminar(int id) {
            try
            {
                using (var ctx = new ControlEscolarDBContext()) {
                    ctx.Entry(new Usuario() { UsuarioId = id }).State = System.Data.Entity.EntityState.Deleted;
                    ctx.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;                
            }
        }

        public void Guardar(UsuarioBean u) {
            try
            {
                using (var ctx = new ControlEscolarDBContext()) {
                    if (u.Id <= 0)
                    {
                        ctx.Entry(new Usuario() { UsuarioId = u.Id, Contrasena = u.Password, NombreUsuario = u.Usuario }).State =
                            System.Data.Entity.EntityState.Added;
                    }
                    else {
                        ctx.Entry(new Usuario() { UsuarioId = u.Id, Contrasena = u.Password, NombreUsuario = u.Usuario }).State =
                            System.Data.Entity.EntityState.Modified;
                    }
                    ctx.SaveChanges();
                    
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public UsuarioBean GetUsuario(int id) {
            try
            {
                using (var ctx = new ControlEscolarDBContext()) {
                    var u = ctx.Usuarios.Where(x => x.UsuarioId == id).SingleOrDefault();

                    UsuarioBean ub = new UsuarioBean();
                    ub.Id = u.UsuarioId;
                    ub.Usuario = u.NombreUsuario;
                    ub.Password = u.Contrasena;
                    return ub;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
