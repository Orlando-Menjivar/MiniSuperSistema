using MiniSuper.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSuper.DataAccess
{
    public class DetalleCompraRepository
    {
        private readonly ConnectionFactory _connectionFactory;

        public DetalleCompraRepository(ConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public List<DetalleCompra> SelectAll()
        {
            List<DetalleCompra> result = null;

            using (SqlConnection conn = _connectionFactory.CreateConnection())
            {
                using (SqlCommand cmd = new SqlCommand("SpDetalleCompraSelectAll", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    using (SqlDataReader rd = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        result = new List<DetalleCompra>();

                        while (rd.Read())
                        {
                            DetalleCompra entity = new DetalleCompra
                            {
                                DetCompraId = rd.GetInt32(0),
                                CompraId = rd.GetInt32(1),
                                Cantidad = rd.GetInt32(2),
                                ProductoId = rd.GetInt32(3),
                                PrecioCompra = rd.GetDecimal(4),
                                SubTotal = rd.GetDecimal(5)
                            };
                            result.Add(entity);
                        }
                    }
                }
            }
            return result;
        }

        public DetalleCompra Select(int detalleCompraId)
        {
            DetalleCompra entity = null;

            using (SqlConnection conn = _connectionFactory.CreateConnection())
            {
                using (SqlCommand cmd = new SqlCommand("SpDetalleCompraSelect", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DetalleCompraId", detalleCompraId);

                    conn.Open();
                    using (SqlDataReader rd = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (rd.Read())
                        {
                            entity = new DetalleCompra
                            {
                                DetCompraId = rd.GetInt32(0),
                                CompraId = rd.GetInt32(1),
                                Cantidad = rd.GetInt32(2),
                                ProductoId = rd.GetInt32(3),
                                PrecioCompra = rd.GetDecimal(4),
                                SubTotal = rd.GetDecimal(5)
                            };
                        }
                    }
                }
            }
            return entity;
        }

        public int Insert(DetalleCompra entity)
        {
            int result = 0;

            using (SqlConnection conn = _connectionFactory.CreateConnection())
            {
                using (SqlCommand cmd = new SqlCommand("SpDetalleCompraInsert", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CompraId", entity.CompraId);
                    cmd.Parameters.AddWithValue("@Cantidad", entity.Cantidad);
                    cmd.Parameters.AddWithValue("@ProductoId", entity.ProductoId);
                    cmd.Parameters.AddWithValue("@PrecioCompra", entity.PrecioCompra);
                    cmd.Parameters.AddWithValue("@SubTotal", entity.SubTotal);

                    conn.Open();
                    result = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            return result;
        }
    }
}