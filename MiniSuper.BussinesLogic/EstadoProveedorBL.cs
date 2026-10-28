using MiniSuper.DataAccess;
using MiniSuper.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSuper.BussinesLogic
{
    public class EstadoProveedorBL
    {
        private readonly EstadoProveedorRepository _repository;

        public EstadoProveedorBL(EstadoProveedorRepository repository)
        {
            _repository = repository;
        }

        public List<EstadoProveedor> SelectAll()
        {
            List<EstadoProveedor> result = null;
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

        public EstadoProveedor Select(int estadoProveedorId)
        {
            EstadoProveedor entity = null;
            try
            {
                entity = _repository.Select(estadoProveedorId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return entity;
        }

        public int Insert(EstadoProveedor entity)
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

        public int Update(EstadoProveedor entity)
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

        public int Delete(int estadoProveedorId)
        {
            int result;
            try
            {
                result = _repository.Delete(estadoProveedorId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}
