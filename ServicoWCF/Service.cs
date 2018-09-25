using Dados;
using Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServicoWCF
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "Service" no arquivo de código e configuração ao mesmo tempo.
    public class Service : IService
    {

        public bool Inserir(Laboratorio lab)
        {
            return new LabInformatica().Inserir(lab);
        }

        public List<Laboratorio> Listar()
        {
            return new LabInformatica().Listar();
        }
    }
}
