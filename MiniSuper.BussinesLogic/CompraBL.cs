using MiniSuper.DataAccess;
using MiniSuper.Entity;
using System;
using System.Collections.Generic;

namespace MiniSuper.BusinessLogic
{
    public class CompraBL
    {
        private readonly CompraRepository _repository;

        public CompraBL(CompraRepository repository)
        {
            _repository = repository;
        }

        public List<Compra> SelectAll()
        {
            List<Compra> result = null;
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

        public Compra Select(int compraId)
        {
            Compra entity = null;
            try
            {
                entity = _repository.Select(compraId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return entity;
        }

        public int Insert(Compra entity)
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