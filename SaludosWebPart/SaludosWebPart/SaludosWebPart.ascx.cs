using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Microsoft.SharePoint;

namespace SaludosWebPart.VisualWebPart1
{
    public partial class VisualWebPart1UserControl : UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var user = SPContext.Current.Web.CurrentUser;

            var saludos = String.Format("Bienvenido a nuestra intranet, {0}!", user.Name);

            lblSaludo.Text = saludos;
        }
    }
}
