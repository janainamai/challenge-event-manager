using Common;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Helper
{
    public static class StringExtensions
    {
        public static string IsValidName(this string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return "Nome deve ser informado.";
            }
            if (name.Length < 3 || name.Length > 50)
            {
                return "Nome deve ter entre 3 e 50 caracteres.";
            }
            return "";
        }

        public static string IsValidSurname(this string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return "Sobrenome deve ser informado.";
            }
            if (name.Length < 3 || name.Length > 50)
            {
                return "Sobrenome deve ter entre 3 e 50 caracteres.";
            }
            return "";
        }

        public static string IsValidMaxCapacity(this string maxCapacity)
        {
            //pegar todas as pessoas cadastradas
            PersonBLL personBLL = new PersonBLL();
            QueryResponse<Person> r1 = personBLL.GetAllList();
            int totalPeople = r1.Data.Count;

            //o número não pode ser igual a 0
            if (int.Parse(maxCapacity) == 0)
            {
                return "A capacidade máxima deve ser maior que 0.";
            }
            //o número não pode ser maior do que a metade do total de pessoas cadastradas
            if(int.Parse(maxCapacity) > (totalPeople/2))
            {
                return "A capacidade máxima não pode ser maior do que metade do total de pessoas cadastradas.";
            }
            return "";
        }

        public static Response IsPair(this string _value)
        {
            Response response = new Response();
            int x = int.Parse(_value);

            if (x % 2 == 0)
            {
                response.Success = true;
                response.Message = "O número é par.";
                return response;
            }
            else
            {
                response.Success = false;
                response.Message = "O número não é par.";
                return response;
            }
        }

        public static string EncryptPassword(this string passcode)
        {
            var encodedValue = Encoding.UTF8.GetBytes(passcode);
            var encryptedPassword = MD5.Create().ComputeHash(encodedValue);

            var sb = new StringBuilder();
            foreach (var caracter in encryptedPassword)
            {
                sb.Append(caracter.ToString("X2"));
            }
            return sb.ToString();
        }
    }
}
