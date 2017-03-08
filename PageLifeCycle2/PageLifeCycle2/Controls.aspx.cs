using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PageLifeCycle2
{
    public partial class Controls : System.Web.UI.Page
    {

        protected void Page_InitComplete(object sender, EventArgs e)
        {
            lblName.Text = lblName.Text + "<br/>" + "Init Complete";
        }


        protected override void OnPreLoad(EventArgs e)
        {
            lblName.Text = lblName.Text + "<br/>" + "Load";
        }



        protected void Page_Load(object sender, EventArgs e)
        {

            lblName.Text = lblName.Text + "<br/>" + "Load";


        }

        protected void btnSubmit1_Click(object sender, EventArgs e)
        {
            lblName.Text = lblName.Text + "<br/>" + "btnSubmit_Click";
        }

        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            lblName.Text = lblName.Text + "<br/>" + "LoadComplete";
        }

        protected override void OnPreRender(EventArgs e)
        {
            lblName.Text = lblName.Text + "Pre Render";
        }


        protected override void OnSaveStateComplete(EventArgs e)
        {
            lblName.Text = lblName.Text + "Save State Complete";
        }

        protected void Page_Unload(object sender, EventArgs e)
        {
            lblName.Text = lblName.Text + "Unload";
        }

        protected void Page_PreInit(object sender, EventArgs e)
        {
            lblName.Text = lblName.Text + "PreInit";
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            lblName.Text = lblName.Text + "Init";
        }

    }
}