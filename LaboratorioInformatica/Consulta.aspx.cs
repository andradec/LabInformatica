using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LaboratorioInformatica
{
    public partial class cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            atualizarGrid();
        }

        protected void btnNovo_Click(object sender, EventArgs e)
        {
            //atualizarGrid();


        }

        private void atualizarGrid()
        {
            var business = new CadastroBusiness();

            GdvlabInformatica.DataSource = business.Listar();
            GdvlabInformatica.DataBind();
        }
    }
}