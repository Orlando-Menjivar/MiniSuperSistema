using MiniSuper.DataAccess;
using MiniSuper.Entity;
using System;
using System.Collections.Generic;

namespace MiniSuper.BusinessLogic
{
    public class FormaPagoBL
    {
        private readonly FormaPagoRepository _repository;

        public FormaPagoBL(FormaPagoRepository repository)
        {
            _repository = repository;
        }

        public List<FormaPago> SelectAll()
        {
            List<FormaPago> result = null;
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

        public FormaPago Select(int formaPagoId)
        {
            FormaPago entity = null;
            try
            {
                entity = _repository.Select(formaPagoId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return entity;
        }


        public int Insert(FormaPago entity)
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

        public int Update(FormaPago entity)
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

        public int Delete(int formaPagoId)
        {
            int result;
            try
            {
                result = _repository.Delete(formaPagoId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}

