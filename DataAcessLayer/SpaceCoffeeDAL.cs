using Common;
using DataAcessLayer.References;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer
{
    public class SpaceCoffeeDAL
    {
        public Response Insert(SpaceCoffee space)
        {
            Response response = new Response();

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionHelper.GetConnectionString();

            SqlCommand command = new SqlCommand();
            command.CommandText = "INSERT INTO SPACECOFFEE (NAME) VALUES(@NAME)";
            command.Parameters.AddWithValue("@NAME", space.Name);
            command.Connection = connection;

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                response.Success = true;
                response.Message = "Dados inseridos com sucesso.";
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = "Erro no banco de dados, contate o administrador.";
                response.StackTrace = ex.StackTrace;
                response.ExeptionMessage = ex.Message;
            }
            finally
            {
                connection.Close();
            }
            return response;
        }
        public TableResponse GetAllTable()
        {
            TableResponse tableResponse = new TableResponse();

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionHelper.GetConnectionString();

            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT NAME as Nome FROM SPACECOFFEE";
            command.Connection = connection;

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                DataTable data = new DataTable();
                adapter.Fill(data);

                tableResponse.Success = true;
                tableResponse.Message = "Dados selecionados com sucesso.";
                tableResponse.DataTable = data;
                return tableResponse;

            }
            catch (Exception ex)
            {
                tableResponse.Success = false;
                tableResponse.Message = "Erro no banco de dados, contate o administrador.";
                tableResponse.ExeptionMessage = ex.Message;
                tableResponse.StackTrace = ex.StackTrace;
                return tableResponse;
            }
            finally
            {
                connection.Close();
            }
        }
        public TableResponse GetByName(SpaceCoffee _space)
        {
            TableResponse tableResponse = new TableResponse();

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionHelper.GetConnectionString();

            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT NAME as Nome FROM SPACECOFFEE WHERE NAME LIKE @NAME";
            command.Parameters.AddWithValue("@NAME", "%" + _space.Name + "%");
            command.Connection = connection;

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                DataTable data = new DataTable();
                adapter.Fill(data);

                tableResponse.Success = true;
                tableResponse.Message = "Dados selecionados com sucesso.";
                tableResponse.DataTable = data;
                return tableResponse;

            }
            catch (Exception ex)
            {
                tableResponse.Success = false;
                tableResponse.Message = "Erro no banco de dados, contate o administrador.";
                tableResponse.ExeptionMessage = ex.Message;
                tableResponse.StackTrace = ex.StackTrace;
                return tableResponse;
            }
            finally
            {
                connection.Close();
            }
        }
        public QueryResponse<SpaceCoffee> GetAllList()
        {
            QueryResponse<SpaceCoffee> response = new QueryResponse<SpaceCoffee>();

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionHelper.GetConnectionString();

            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM SPACECOFFEE";
            command.Connection = connection;

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                List<SpaceCoffee> spaces = new List<SpaceCoffee>();

                while (reader.Read())
                {
                    SpaceCoffee space = new SpaceCoffee();
                    space.ID = (int)reader["ID"];
                    space.Name = (string)reader["NAME"];
                    spaces.Add(space);
                }
                response.Success = true;
                response.Message = "Dados selecionados com sucesso.";
                response.Data = spaces;
                return response;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = "Erro no banco de dados contate o administrador.";
                response.ExeptionMessage = ex.Message;
                response.StackTrace = ex.StackTrace;
                return response;
            }
            finally
            {
                connection.Close();
            }


        }
        public SingleResponse<SpaceCoffee> Get(SpaceCoffee _space)
        {
            SingleResponse<SpaceCoffee> response = new SingleResponse<SpaceCoffee>();

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionHelper.GetConnectionString();

            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM SPACECOFFEE WHERE NAME LIKE @NAME ";
            command.Parameters.AddWithValue("@NAME", _space.Name);
            command.Connection = connection;

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                SpaceCoffee space = new SpaceCoffee();
                reader.Read();
                space.ID = (int)reader["ID"];
                space.Name = (string)reader["NAME"];

                response.Success = true;
                response.Message = "Dados selecionados com sucesso.";
                response.Data = space;
                return response;

            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = "Erro no banco de dados, contate o administrador.";
                response.ExeptionMessage = ex.Message;
                response.StackTrace = ex.StackTrace;
                return response;
            }
            finally
            {
                connection.Close();
            }
        }
        public Response DeleteAll()
        {
            Response response = new Response();

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionHelper.GetConnectionString();

            SqlCommand command = new SqlCommand();
            command.CommandText = "TRUNCATE TABLE SPACECOFFEE";
            command.Connection = connection;

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                response.Success = true;
                response.Message = "Todos os dados foram deletados com sucesso.";
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = "Erro no banco de dados, contate o administrador.";
                response.StackTrace = ex.StackTrace;
                response.ExeptionMessage = ex.Message;
            }
            finally
            {
                connection.Close();
            }
            return response;
        }
    }
}
