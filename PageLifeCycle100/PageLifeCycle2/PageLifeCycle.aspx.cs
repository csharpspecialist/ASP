using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PageLifeCycle2
{
    public partial class PageLifeCycle : System.Web.UI.Page
    {

        protected void Pre_Init(object sender, EventArgs e)
        {
            Response.Write("<br /> " + "Pre-Init");
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            Response.Write("<br /> " + "Initialize");
        }

        protected void Page_InitComplete(object sender, EventArgs e)
        {
            Response.Write("<br /> " + "Initialization Complete");
        }

        protected override void OnPreLoad(EventArgs e)
        {
            Response.Write("<br /> " + "OnPreLoad ");
        }        

        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("<br /> " + "Loading Page ");
        }

        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            Response.Write("<br /> " + "Load Complete ");
        }

        protected override void OnPreRender(EventArgs e)
        {
            Response.Write("<br /> " + "OnPreRender ");
        }
        
        protected override void OnSaveStateComplete(EventArgs e)
        {
            Response.Write("<br /> " + "OnSaveStateComplete ");
        }

        protected void Page_Unload(EventArgs e)
        {
            //Runtime error : Response is not avail in this context!!!
            Response.Write("<br /> " + "Unload "); // Error
        }
       
    }
}