using MiniSuper.DataAccess;
using MiniSuper.Entity;
using System;
using System.Collections.Generic;

namespace MiniSuper.BusinessLogic
{
    public class ProveedorBL
    {
        private readonly ProveedorRepository _repository;

        public ProveedorBL(ProveedorRepository repository)
        {
            _repository = repository;
        }

        public List<Proveedor> SelectAll()
        {
            List<Proveedor> result = null;
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

        public Proveedor Select(int proveedorId)
        {
            Proveedor entity = null;
            try
            {
                entity = _repository.Select(proveedorId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return entity;
        }


        public int Insert(Proveedor entity)
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

        public int Update(Proveedor entity)
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

        public int Delete(int proveedorId)
        {
            int result;
            try
            {
                result = _repository.Delete(proveedorId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}