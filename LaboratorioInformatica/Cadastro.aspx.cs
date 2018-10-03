using Business;
using Dados;
using Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LaboratorioInformatica
{
    public partial class Cadastro2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            MsgErro.Text = "";
            try
            {
                if (string.IsNullOrEmpty(txtQtdComputadores.Text) || int.Parse(txtQtdComputadores.Text) == 0)
                {
                    MsgErro.Text += "<br/>Para cadastrar um laboratório é necessário no mínimo 1 computador";

                }

                if (string.IsNullOrEmpty(txtQtdAlunos.Text) || int.Parse(txtQtdAlunos.Text) <= 4)
                {
                    MsgErro.Text += "<br/> Para cadastrar um laboratório é necessário mais de 4 alunos";

                }
                if (txtnome.Text.Length <= 3)
                {
                    MsgErro.Text += "<br/>O campo nome deve contem pelo menos 3 caracteres";

                }
                if (MsgErro.Text.Length > 1)
                    return;

                var laboratorio = new tb_laboratorio
                {
                    nome = txtnome.Text,
                    qtdAlunos = int.Parse(txtQtdAlunos.Text),
                    qtdComputadores = int.Parse(txtQtdComputadores.Text),
                    software1 = txtsoftware1.Text,
                    software2 = txtsoftware2.Text,
                    software3 = txtsoftware3.Text,
                    sistemaOperacional = txtSO.Text,
                    projetor = chbox.Checked
                };


                var cadastroBusiness = new CadastroBusiness();
                cadastroBusiness.Inserir(laboratorio);


                if (!chbox.Checked)
                    MsgErro.Text += "<br/> Para utilização do projetor é necessário abrir uma solicitação para o help desk";

            }
            catch (Exception ex)
            {
                 MsgErro.Text += $"Erro: { ex.StackTrace.ToString()}";
            }
        }
    }
}