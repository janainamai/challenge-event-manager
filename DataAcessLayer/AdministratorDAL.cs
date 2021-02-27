using Common;
using DataAcessLayer.References;
using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer
{
    public class AdministratorDAL
    {
        public SingleResponse<Administrator> GetAdm(Administrator _adm)
        {
            SingleResponse<Administrator> response = new SingleResponse<Administrator>();

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionHelper.GetConnectionString();

            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM ADMS WHERE USERADM LIKE @USERADM AND PASSCODE LIKE @PASSCODE";
            command.Parameters.AddWithValue("@USERADM", _adm.User);
            command.Parameters.AddWithValue("@PASSCODE", _adm.Passcode);
            command.Connection = connection;

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                Administrator newAdm = new Administrator();
                if(reader.Read())
                {
                    newAdm.ID = (int)reader["ID"];
                    newAdm.User = (string)reader["USERADM"];
                    newAdm.Passcode = (string)reader["PASSCODE"];

                    response.Success = true;
                    response.Message = "Dados selecionados com sucesso.";
                    response.Data = newAdm;
                    return response;
                }
                else
                {
                    response.Success = false;
                    response.Message = "Dados não encontrados.";
                    return response;
                }
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
        public Response Insert(Administrator _adm)
        {
            Response response = new Response();

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionHelper.GetConnectionString();

            SqlCommand command = new SqlCommand();
            command.CommandText = "INSERT INTO ADMS (USERADM, PASSCODE) VALUES(@USERADM, @PASSCODE)";
            command.Parameters.AddWithValue("@USERADM", _adm.User);
            command.Parameters.AddWithValue("@PASSCODE", _adm.Passcode);
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
    }
}
