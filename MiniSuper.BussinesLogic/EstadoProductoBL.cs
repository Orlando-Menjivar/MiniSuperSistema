using MiniSuper.DataAccess;
using MiniSuper.Entity;
using System;
using System.Collections.Generic;

namespace MiniSuper.BusinessLogic
{
    public class EstadoProductoBL
    {
        private readonly EstadoProductoRepository _repository;

        public EstadoProductoBL(EstadoProductoRepository repository)
        {
            _repository = repository;
        }

        public List<EstadoProducto> SelectAll()
        {
            List<EstadoProducto> result = null;
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

        public EstadoProducto Select(int estadoProductoId)
        {
            EstadoProducto entity = null;
            try
            {
                entity = _repository.Select(estadoProductoId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return entity;
        }

        public int Insert(EstadoProducto entity)
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

        public int Update(EstadoProducto entity)
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

        public int Delete(int estadoProductoId)
        {
            int result;
            try
            {
                result = _repository.Delete(estadoProductoId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}