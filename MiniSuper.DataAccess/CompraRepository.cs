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
    public class CompraRepository
    {
        private readonly ConnectionFactory _connectionFactory;

        public CompraRepository(ConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public List<Compra> SelectAll()
        {
            List<Compra> result = null;

            using (SqlConnection conn = _connectionFactory.CreateConnection())
            {
                using (SqlCommand cmd = new SqlCommand("SpCompraSelectAll", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    using (SqlDataReader rd = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        result = new List<Compra>();

                        while (rd.Read())
                        {
                            Compra entity = new Compra
                            {
                                CompraId = rd.GetInt32(0),
                                FechaHora = rd.GetDateTime(1),
                                NumeroFactura = rd.GetString(2),
                                ProveedorId = rd.GetInt32(3),
                                UsuarioId = rd.GetInt32(4),
                                Total = rd.GetDecimal(5)
                            };
                            result.Add(entity);
                        }
                    }
                }
            }
            return result;
        }

        public Compra Select(int compraId)
        {
            Compra entity = null;

            using (SqlConnection conn = _connectionFactory.CreateConnection())
            {
                using (SqlCommand cmd = new SqlCommand("SpCompraSelect", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CompraId", compraId);

                    conn.Open();
                    using (SqlDataReader rd = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (rd.Read())
                        {
                            entity = new Compra
                            {
                                CompraId = rd.GetInt32(0),
                                FechaHora = rd.GetDateTime(1),
                                NumeroFactura = rd.GetString(2),
                                ProveedorId = rd.GetInt32(3),
                                UsuarioId = rd.GetInt32(4),
                                Total = rd.GetDecimal(5)
                            };
                        }
                    }
                }
            }
            return entity;
        }

        public int Insert(Compra entity)
        {
            int result = 0;

            using (SqlConnection conn = _connectionFactory.CreateConnection())
            {
                using (SqlCommand cmd = new SqlCommand("SpCompraInsert", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FechaHora", entity.FechaHora);
                    cmd.Parameters.AddWithValue("@NumeroFactura", entity.NumeroFactura);
                    cmd.Parameters.AddWithValue("@ProveedorId", entity.ProveedorId);
                    cmd.Parameters.AddWithValue("@UsuarioId", entity.UsuarioId);
                    cmd.Parameters.AddWithValue("@Total", entity.Total);

                    conn.Open();
                    result = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            return result;
        }
    }
}