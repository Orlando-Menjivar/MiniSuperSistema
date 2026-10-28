using MiniSuper.DataAccess;
using MiniSuper.Entity;
using System;
using System.Collections.Generic;

namespace Super.BusinessLogic
{
    public class PagoBL
    {
        private readonly PagoRepository _repository;

        public PagoBL(PagoRepository repository)
        {
            _repository = repository;
        }

        public List<Pago> SelectAll()
        {
            List<Pago> result = null;
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

        public Pago Select(int pagoId)
        {
            Pago entity = null;
            try
            {
                entity = _repository.Select(pagoId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return entity;
        }

        public int Insert(Pago entity)
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

        public int Update(Pago entity)
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

        public int Delete(int pagoId)
        {
            int result;
            try
            {
                result = _repository.Delete(pagoId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}
