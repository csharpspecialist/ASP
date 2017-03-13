using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PageLifeCycle2
{
    public partial class Default : System.Web.UI.Page
    {
        //event 1- PreInit
        //event 5 load

           protected void Page_PreInit(object sender, EventArgs e)
        {

        }

        // Event 2

        protected void Page_Init(object sender, EventArgs e)
        {

        }

        //Event 3
        protected void Page_InitComplete(object sender, EventArgs e)
        {

        }


        //Event 4 - OnPreLoad
        protected override void OnPreLoad(EventArgs e)
        {

        }

        //Event 5 - Load!!!!
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // Event 6 - Control Postback Event
        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        //Event 7 - Load complete
        protected void Page_LoadComplete(object sender, EventArgs e)
        {

        }

        // Event 8 - On Pre Render
        protected override void OnPreRender(EventArgs e)
        {

        }

        // Event 9 - OnSaveStateComplete
        protected override void OnSaveStateComplete(EventArgs e)
        {
            
        }

        // Event 10 - Render
        /*
         1. this is a method of the page object and its controls(and not an event)
             2. The render method generates the client-side HTML, dynamic HTML, and scripts that are necessary to properly display a control in the browser 
             */
       

        // Event 11 - Unload
        protected void PageUnload(object sender, EventArgs e)
        {

        }


    }
}