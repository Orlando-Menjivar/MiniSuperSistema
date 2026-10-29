using MiniSuper.DataAccess;
using MiniSuper.Entity;
using System;
using System.Collections.Generic;

namespace MiniSuper.BusinessLogic
{
    public class InventarioBL
    {
        private readonly InventarioRepository _repository;

        public InventarioBL(InventarioRepository repository)
        {
            _repository = repository;
        }

        public List<Inventario> SelectAll()
        {
            List<Inventario> result = null;
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

        public Inventario Select(int inventarioId)
        {
            Inventario entity = null;
            try
            {
                entity = _repository.Select(inventarioId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return entity;
        }

        public int Insert(Inventario entity)
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
    }
}
