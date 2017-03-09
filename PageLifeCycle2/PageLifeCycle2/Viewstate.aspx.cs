using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PageLifeCycle2
{
    public partial class Viewstate : System.Web.UI.Page
    {
   

        protected void Pre_Init(object sender, EventArgs e)
        {
            ViewState["value"] = Convert.ToString(ViewState["value"]) + "<br /> " + "Pre-Init";
            lblName.Text = Convert.ToString(ViewState["value"]);
        }


        protected void Page_Init(object sender, EventArgs e)
        {
            ViewState["value"] = Convert.ToString(ViewState["value"]) + "<br /> " + "Page-Init";
            lblName.Text = Convert.ToString(ViewState["value"]);
        }


        protected void Page_InitComplete(object sender, EventArgs e)
        {
            ViewState["value"] = Convert.ToString(ViewState["value"]) + "<br /> " + "Init Complete";
            lblName.Text = Convert.ToString(ViewState["value"]);
        }

        protected void PageOnPreLoad(EventArgs e)
        {
            ViewState["value"] = Convert.ToString(ViewState["value"]) + "<br /> " + "Pre Load";
            lblName.Text = Convert.ToString(ViewState["value"]);
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            ViewState["value"] = Convert.ToString(ViewState["value"]) + "<br /> " + "Page Load";
            lblName.Text = Convert.ToString(ViewState["value"]);
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            ViewState["value"] = Convert.ToString(ViewState["value"]) + "<br /> " + "Button Submit";
            lblName.Text = Convert.ToString(ViewState["value"]);
        }

        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            ViewState["value"] = Convert.ToString(ViewState["value"]) + "<br /> " + "Load Complete";
            lblName.Text = Convert.ToString(ViewState["value"]);
        }

        protected override void OnPreRender(EventArgs e)
        {
            ViewState["value"] = Convert.ToString(ViewState["value"]) + "<br /> " + "Pre Render";
            lblName.Text = Convert.ToString(ViewState["value"]);
        }

        protected override void  OnSaveStateComplete (EventArgs e)
        {
            ViewState["value"] = Convert.ToString(ViewState["value"]) + "<br /> " + "Save State Complete";
            lblName.Text = Convert.ToString(ViewState["value"]);
        }

        protected void Page_Unload(object Sender, EventArgs e)
        {
            ViewState["value"] = Convert.ToString(ViewState["value"]) + "<br /> " + "Save State Complete";
            lblName.Text = Convert.ToString(ViewState["value"]);
        }

    }
}