using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using Loja.BO;

namespace Loja.web
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            BD bd = new BD(@"C:\FOURTH TERM\ASP.Net\Assign2\Loja\Loja.web\App_Data");
            Application["BD"] = bd;
        }

        protected void Application_End(object sender, EventArgs e)
        {
            BD bd = (BD)Application["BD"];
            bd.Gravar();
        }
    }
}