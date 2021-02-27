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
    public class SpaceTrainingDAL
    {
        public Response Insert(SpaceTraining space)
        {
            Response response = new Response();

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionHelper.GetConnectionString();

            SqlCommand command = new SqlCommand();
            command.CommandText = "INSERT INTO SPACETRAINING (NAME, MAXCAPACITY) VALUES(@NAME, @MAXCAPACITY)";
            command.Parameters.AddWithValue("@NAME", space.Name);
            command.Parameters.AddWithValue("@MAXCAPACITY", (int)space.MaxCapacity);
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
        } //test
        public TableResponse GetAllTable()
        {
            TableResponse tableResponse = new TableResponse();

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionHelper.GetConnectionString();

            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT NAME as Nome, MAXCAPACITY as LotaçãoMáxima FROM SPACETRAINING";
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
        } //test
        public QueryResponse<SpaceTraining> GetAllList()
        {
            QueryResponse<SpaceTraining> response = new QueryResponse<SpaceTraining>();

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionHelper.GetConnectionString();

            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM SPACETRAINING";
            command.Connection = connection;

                try
                {
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    List<SpaceTraining> spaces = new List<SpaceTraining>();

                    while (reader.Read())
                    {
                        SpaceTraining space = new SpaceTraining();
                        space.ID = (int)reader["ID"];
                        space.Name = (string)reader["NAME"];
                        space.MaxCapacity = (int)reader["MAXCAPACITY"];
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
            
            
        } //test
        public SingleResponse<SpaceTraining> Get(SpaceTraining _space)
        {
            SingleResponse<SpaceTraining> response = new SingleResponse<SpaceTraining>();

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionHelper.GetConnectionString();

            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM SPACETRAINING WHERE NAME LIKE @NAME AND MAXCAPACITY LIKE @MAXCAPACITY";
            command.Parameters.AddWithValue("@NAME", _space.Name);
            command.Parameters.AddWithValue("@MAXCAPACITY", _space.MaxCapacity);
            command.Connection = connection;

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                SpaceTraining space = new SpaceTraining();
                reader.Read();
                space.ID = (int)reader["ID"];
                space.Name = (string)reader["NAME"];
                space.MaxCapacity = (int)reader["MAXCAPACITY"];

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
        } //test
        public TableResponse GetByName(SpaceTraining _space)
        {
            TableResponse tableResponse = new TableResponse();

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionHelper.GetConnectionString();

            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT NAME as Nome, MAXCAPACITY as LotaçãoMáxima FROM SPACETRAINING WHERE NAME LIKE @NAME";
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
        } //test
        public SingleResponse<SpaceTraining> GetSmallerSpace()
        {
            SingleResponse<SpaceTraining> response = new SingleResponse<SpaceTraining>();

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionHelper.GetConnectionString();

            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM SPACETRAINING ORDER BY MaxCapacity ASC";
            command.Connection = connection;

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                SpaceTraining space = new SpaceTraining();
                reader.Read();
                space.ID = (int)reader["ID"];
                space.Name = (string)reader["NAME"];
                space.MaxCapacity = (int)reader["MAXCAPACITY"];

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
        } //test
        public QueryResponse<SpaceTraining> GetSpaceWithEmptySeat(int personsPerRoom)
        {
            QueryResponse<SpaceTraining> response = new QueryResponse<SpaceTraining>();

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionHelper.GetConnectionString();

            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM SPACETRAINING WHERE MAXCAPACITY > @VALUE";
            command.Parameters.AddWithValue("@VALUE", personsPerRoom);
            command.Parameters.AddWithValue("@TYPE", 0);
            command.Connection = connection;

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                List<SpaceTraining> spaces = new List<SpaceTraining>();

                while (reader.Read())
                {
                    SpaceTraining space = new SpaceTraining();
                    space.ID = (int)reader["ID"];
                    space.Name = (string)reader["NAME"];
                    space.MaxCapacity = (int)reader["MAXCAPACITY"];
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
        } //test
        public Response UpdateMaxCapacity(SpaceTraining _space)
        {
            Response response = new Response();

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionHelper.GetConnectionString();

            SqlCommand command = new SqlCommand();
            command.CommandText = "UPDATE SPACETRAINING SET MAXCAPACITY = @MAXCAPACITY WHERE ID LIKE @ID";
            command.Parameters.AddWithValue("@MAXCAPACITY", _space.MaxCapacity);
            command.Parameters.AddWithValue("@ID", _space.ID);

            command.Connection = connection;

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                response.Success = true;
                response.Message = "O registro foi alterado com sucesso.";
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
        } //test
        public Response DeleteAll()
        {
            Response response = new Response();

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionHelper.GetConnectionString();

            SqlCommand command = new SqlCommand();
            command.CommandText = "TRUNCATE TABLE SPACETRAINING";
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
        }  //test

    }
}
