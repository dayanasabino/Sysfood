using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysFood.Classes
{
    class Validacao
    {
        //Variaveis.
        public static bool retornovalidacao;
        public static bool retornovalidacaoigualdade;
        MySqlCommand cmd;

        //Instância de classe.
        Classes.Banco clBanco = new Classes.Banco();
        //Classes.Usuario clUsuario = new Classes.Usuario();

        //Métodos.
        public bool ValidarCpf(string cpf) // validar cpf
        {
            //Bloco de variáveis
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;

            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "").Replace(",", "");

            if (cpf.Length != 11)
            {
                return false;
            }

            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
            {
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            }

            resto = soma % 11;
            if (resto < 2)
            {
                resto = 0;
            }
            else
            {
                resto = 11 - resto;
            }

            digito = resto.ToString();

            tempCpf = tempCpf + digito;

            soma = 0;
            for (int i = 0; i < 10; i++)
            {
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            }
            resto = soma % 11;

            if (resto < 2)
            {
                resto = 0;
            }
            else
            {
                resto = 11 - resto;
            }

            digito = digito + resto.ToString();

            cpf = cpf.Substring(9, 2);

            if (digito == cpf)
            {
                retornovalidacao = true;
            }
            else
            {
                retornovalidacao = false;
            }

            return cpf.EndsWith(digito);
        }

        public bool ValidarIgualdadeSenha()
        {
            if (Classes.Usuario.Senha == Classes.Usuario.Repetirsenha)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ExistenciaCpf(string cpf)
        {
            clBanco.Conectar();
            MySqlCommand sql = new MySqlCommand ("SELECT COUNT(cpf) FROM usuario WHERE cpf = '" + cpf + "';", clBanco.Conn);
            //MySqlDataReader dr = sql.ExecuteReader();

            if (sql.ExecuteScalar() != null) // verifica se o sql retorna resultados
            {
                retornovalidacaoigualdade = true;
            }
            else
            {
                retornovalidacaoigualdade = false;
            }
        }
    }
}
