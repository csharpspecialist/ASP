using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PageLifeCycle
{
    public partial class PageLifeCycle : System.Web.UI.Page
    {
        //  Event 1 - PreInit
        protected void Page_PreInit(object sender, EventArgs e)
        {
            Response.Write("<br/>" + "PreInit");
        }

        //  Event 2 - Init
        protected void Page_Init(object sender, EventArgs e)
        {
            Response.Write("<br/>" + "Init");
        }

        //  Event 3 - InitComplete
        protected void Page_InitComplete(object sender, EventArgs e)
        {
            Response.Write("<br/>" + "InitComplete");
        }

        //  Event 4 - OnPreLoad
        protected override void OnPreLoad(EventArgs e)
        {
            Response.Write("<br/>" + "PreLoad");
        }

        //  Event 5 - Load
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("<br/>" + "Load");
        }

        //  Event 7 - LoadComplete
        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            Response.Write("<br/>" + "LoadComplete");
        }

        //  Event 8 - OnPreRender
        protected override void OnPreRender(EventArgs e)
        {
            Response.Write("<br/>" + "PreRender");
        }

        //  Event 9 - OnSaveStateComplete
        protected override void OnSaveStateComplete(EventArgs e)
        {
            Response.Write("<br/>" + "SaveStateComplete");
        }

        //  Event 11 - UnLoad
        protected void Page_UnLoad(object sender, EventArgs e)
        {
            //Runtime Error : Response is not available in this context.
            //Response.Write("<br/>" + "UnLoad"); //Error
            //Response.Write("<br/>");
        }
    }
}