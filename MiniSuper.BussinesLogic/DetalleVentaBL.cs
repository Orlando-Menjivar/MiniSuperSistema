using MiniSuper.DataAccess;
using MiniSuper.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSuper.BussinesLogic
{
    public class DetalleVentaBL
    {
        private readonly DetalleVentaRepository _repository;

        public DetalleVentaBL(DetalleVentaRepository repository)
        {
            _repository = repository;
        }

        public List<DetalleVenta> SelectAll()
        {
            List<DetalleVenta> result = null;
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

        public DetalleVenta Select(int detalleVentaId)
        {
            DetalleVenta entity = null;
            try
            {
                entity = _repository.Select(detalleVentaId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return entity;
        }

        public int Insert(DetalleVenta entity)
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
