using MiniSuper.DataAccess;
using MiniSuper.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSuper.BussinesLogic
{
    public class UsuarioBL
    {
        private readonly UsuarioRepository _repository;

        public UsuarioBL(UsuarioRepository repository)
        {
            _repository = repository;
        }

        public List<Usuario> SelectAll()
        {
            List<Usuario> result = null;
            try
            {
                result = _repository.SelectAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }

        public Usuario Select(int usuarioId)
        {
            Usuario entity = null;
            try
            {
                entity = _repository.Select(usuarioId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return entity;
        }


        public int Insert(Usuario entity)
        {
            int result;
            try
            {
                result = _repository.Insert(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public int Update(Usuario entity)
        {
            int result;
            try
            {
                result = _repository.Update(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public int Delete(int usuarioId)
        {
            int result;
            try
            {
                result = _repository.Delete(usuarioId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}
