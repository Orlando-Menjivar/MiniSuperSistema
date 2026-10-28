using MiniSuper.Entity;
using System;
using MiniSuper.DataAccess;
using System.Collections.Generic;


namespace MiniSuper.BussinesLogic
{
    public class EstadoUsuarioBL
    {
        private readonly EstadoUsuarioRepository _Repository;
        public EstadoUsuarioBL(EstadoUsuarioRepository Repository)
        {
            _Repository = Repository;
        }

        public List<EstadoUsuario> SelectAll()
        {
            List<EstadoUsuario> result = null;
            try
            {
                result = _Repository.SelectAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public EstadoUsuario Select(int estadoUsuarioId)
        {
            EstadoUsuario entity = null;
            try
            {
                entity = _Repository.Select(estadoUsuarioId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return entity;
        }

        public int Insert(EstadoUsuario entity)
        {
            int result;
            try
            {
                result = _Repository.Insert(entity);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }


        public int Update(EstadoUsuario entity)
        {
            int result;
            try
            {
                result = _Repository.Update(entity);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public int Delete(int estadoUsuarioId)
        {
            int result;
            try
            {
                result = _Repository.Delete(estadoUsuarioId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }


    }
}
