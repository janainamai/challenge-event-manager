using Common;
using DataAcessLayer.References;
using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer
{
    public class PersonDAL
    {
        public TableResponse GetViewModel()
        {
            TableResponse tableResponse = new TableResponse();

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionHelper.GetConnectionString();

            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT P.FULLNAME 'Participante', ST.NAME 'SalaUm', ST2.NAME 'SalaDois', SC.NAME 'Café' FROM PERSONS P INNER JOIN SPACETRAINING ST ON P.STAGE1ID = ST.ID INNER JOIN SPACECOFFEE SC ON P.COFFEEID = SC.ID INNER JOIN SPACETRAINING ST2 ON P.STAGE2ID = ST2.ID";
            
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
        public TableResponse GetByNameViewModel(Person _person)
        {
            TableResponse tableResponse = new TableResponse();

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionHelper.GetConnectionString();

            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT P.FULLNAME 'Participante', ST.NAME 'SalaUm', ST2.NAME 'SalaDois', SC.NAME 'Café' FROM PERSONS P INNER JOIN SPACETRAINING ST ON P.STAGE1ID = ST.ID INNER JOIN SPACECOFFEE SC ON P.COFFEEID = SC.ID INNER JOIN SPACETRAINING ST2 ON P.STAGE2ID = ST2.ID WHERE P.FULLNAME LIKE @FULLNAME";
            command.Parameters.AddWithValue("@FULLNAME", "%" + _person.FullName + "%");
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
        public Response Insert(Person person)
        {
            Response response = new Response();

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionHelper.GetConnectionString();

            SqlCommand command = new SqlCommand();
            command.CommandText = "INSERT INTO PERSONS (NAME, SURNAME, FULLNAME) VALUES(@NAME, @SURNAME, @FULLNAME)";
            command.Parameters.AddWithValue("@NAME", person.Name);
            command.Parameters.AddWithValue("@SURNAME", person.Surname);
            command.Parameters.AddWithValue("@FULLNAME", person.FullName);
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
        public Response DeleteAll()
        {
            Response response = new Response();

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionHelper.GetConnectionString();

            SqlCommand command = new SqlCommand();
            command.CommandText = "TRUNCATE TABLE PERSONS";
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
        public TableResponse GetAllTable() //test
        {
            TableResponse tableResponse = new TableResponse();

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionHelper.GetConnectionString();
          
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT FULLNAME as Nome, STAGE1ID as SalaEtapaUm, STAGE2ID as SalaEtapaDois, COFFEEID as SalaCafé FROM PERSONS";
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
        public TableResponse GetByName(Person _person) //test
        {
            TableResponse tableResponse = new TableResponse();

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionHelper.GetConnectionString();

            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT FULLNAME as Nome, STAGE1ID as SalaEtapaUm, STAGE2ID as SalaEtapaDois, COFFEEID as SalaCafé FROM PERSONS WHERE NAME LIKE @NAME";
            command.Parameters.AddWithValue("@NAME", "%" + _person.Name + "%");
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
        public TableResponse GetAllByStage1IDASC() //test
        {
            TableResponse tableResponse = new TableResponse();

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionHelper.GetConnectionString();

            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT FULLNAME as Nome, STAGE1ID as SalaEtapaUm, STAGE2ID as SalaEtapaDois, COFFEEID as SalaCafé FROM PERSONS ORDER BY STAGE1ID ASC";
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
        public TableResponse GetAllByStage1ID(SpaceTraining _space)
        {
            TableResponse tableResponse = new TableResponse();

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionHelper.GetConnectionString();

            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT FULLNAME as Nome FROM PERSONS WHERE STAGE1ID LIKE @STAGE1ID";
            command.Parameters.AddWithValue("@STAGE1ID", _space.ID);
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
        public TableResponse GetAllByStage2ID(SpaceTraining _space)
        {
            TableResponse tableResponse = new TableResponse();

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionHelper.GetConnectionString();

            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT FULLNAME as Nome FROM PERSONS WHERE STAGE2ID LIKE @STAGE2ID";
            command.Parameters.AddWithValue("@STAGE2ID", _space.ID);
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
        public TableResponse GetAllByCoffeeID(SpaceCoffee _space)
        {
            TableResponse tableResponse = new TableResponse();

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionHelper.GetConnectionString();

            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT FULLNAME as Nome FROM PERSONS WHERE COFFEEID LIKE @COFFEEID";
            command.Parameters.AddWithValue("@COFFEEID", _space.ID);
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
        public QueryResponse<Person> GetAllList() //test
        {
            QueryResponse<Person> response = new QueryResponse<Person>();

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionHelper.GetConnectionString();

            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM PERSONS";
            command.Connection = connection;

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                List<Person> persons = new List<Person>();

                while (reader.Read())
                {
                    Person person1 = new Person();
                    person1.ID = (int)reader["ID"];
                    person1.Name = (string)reader["NAME"];
                    person1.Surname = (string)reader["SURNAME"];
                    person1.FullName = (string)reader["FULLNAME"];

                    persons.Add(person1);
                }
                response.Success = true;
                response.Message = "Dados selecionados com sucesso.";
                response.Data = persons;
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
        public TableResponse GetNamesOnly()
        {
            TableResponse tableResponse = new TableResponse();

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionHelper.GetConnectionString();

            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT FULLNAME as Nome FROM PERSONS";
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
        public Response UpdateStage1ID(SpaceTraining _space, Person _person)
        {
            Response response = new Response();

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionHelper.GetConnectionString();

            SqlCommand command = new SqlCommand();
            command.CommandText = "UPDATE PERSONS SET STAGE1ID = @STAGE1ID WHERE ID LIKE @ID";
            command.Parameters.AddWithValue("@STAGE1ID", _space.ID);
            command.Parameters.AddWithValue("@ID", _person.ID);
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
        public Response UpdateStage2ID(SpaceTraining _space, Person _person) //test
        {
            Response response = new Response();

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionHelper.GetConnectionString();

            SqlCommand command = new SqlCommand();
            command.CommandText = "UPDATE PERSONS SET STAGE2ID = @STAGE2ID WHERE ID LIKE @ID";
            command.Parameters.AddWithValue("@STAGE2ID", _space.ID);
            command.Parameters.AddWithValue("@ID", _person.ID);
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
        public Response UpdateStage2IDInformingInt(int _newID, Person _person)
        {
            Response response = new Response();

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionHelper.GetConnectionString();

            SqlCommand command = new SqlCommand();
            command.CommandText = "UPDATE PERSONS SET STAGE2ID = @STAGE2ID WHERE ID LIKE @ID";
            command.Parameters.AddWithValue("@STAGE2ID", _newID);
            command.Parameters.AddWithValue("@ID", _person.ID);
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
        public Response UpdateCoffeeID(int _newID, Person _person) //test
        {
            Response response = new Response();

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionHelper.GetConnectionString();

            SqlCommand command = new SqlCommand();
            command.CommandText = "UPDATE PERSONS SET COFFEEID = @COFFEEID WHERE ID LIKE @ID";
            command.Parameters.AddWithValue("@COFFEEID", _newID);
            command.Parameters.AddWithValue("@ID", _person.ID);
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
        public QueryResponse<Person> GetPeopleByStage1ID(SpaceTraining _space)
        {
            QueryResponse<Person> response = new QueryResponse<Person>();

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionHelper.GetConnectionString();

            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM PERSONS WHERE STAGE1ID LIKE @VALUE";
            command.Parameters.AddWithValue("@VALUE", _space.ID);
            command.Connection = connection;

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                List<Person> persons = new List<Person>();

                while (reader.Read())
                {
                    Person person = new Person();
                    person.ID = (int)reader["ID"];
                    person.Name = (string)reader["NAME"];
                    person.Surname = (string)reader["SURNAME"];
                    person.FullName = (string)reader["FULLNAME"];
                    person.Event1ID = (int)reader["STAGE1ID"];

                    persons.Add(person);
                }
                response.Success = true;
                response.Message = "Dados selecionados com sucesso.";
                response.Data = persons;
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

    }
}
