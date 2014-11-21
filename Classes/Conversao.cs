using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysFood.Classes
{
    class Conversao
    {
        //Bloco de variáveis.
        string tempDia, tempMes, tempAno, dataUS;
        string cpri, csec, cter, cqua, rcpf;

        //Métodos.
        public string ConverterData(string dataBR)
        {
            if (dataBR != "  /  /") // Se não for informado o valor, o sistema vai passar somente a máscara, ai a função não executa.
            {
                tempDia = dataBR;
                tempMes = dataBR;
                tempAno = dataBR;
                tempDia = tempDia.Substring(0, 2);
                tempMes = tempMes.Substring(3, 2);
                tempAno = tempAno.Substring(6, 4);

                dataUS = tempAno + "-" + tempMes + "-" + tempDia;
            }
            return dataUS;
        }

        public string ConverterCpf(string valCpf)
        {
            if (valCpf != "   .   .   -  ")
            {
                cpri = valCpf;
                csec = valCpf;
                cter = valCpf;
                cqua = valCpf;
                cpri = cpri.Substring(0, 3);
                csec = csec.Substring(4, 3);
                cter = cter.Substring(8, 3);
                cqua = cqua.Substring(12, 2);
                rcpf = cpri+csec+cter+cqua ;  
            }
            return rcpf;
        }              
                       
        public void ConverterCep()
        {
        }

        public void ConverterTelefone()
        {
        }
    }
}
