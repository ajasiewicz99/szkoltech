using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Models;

namespace WebApplication1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                InitMiasta();
                InitTypy();
            }
        }

        public void InitMiasta() 
        {
            var miastaList = new List<string>()
            {
                "Rzeszow", "Krakow", "Warszawa", "Szczecin"
            };

            ddlMiasto.DataSource = miastaList;
            ddlMiasto.DataBind();
        }

        public void InitTypy()
        {
            var typyList = new List<string>()
            {
                "koncert", "mecz pilkarski", "turniej bilardowy", "turniej szachowy"
            };
            ddlTyp.DataSource = typyList;
            ddlTyp.DataBind();
        }

        List<Eventy> Eventy
        {
            get { return (List<Eventy>)Session["Events"];  }
            set { Session["Events"] = value; }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            var eventOne = new Eventy
            {
                Typ = ddlTyp.SelectedValue,
                Miasto = ddlMiasto.SelectedValue,
                Organizator = txtOrganizator.Text,
                Wydarzenie = txtWydarzenie.Text
            };

            var list = Eventy;
            if (list == null)
            {
                list = new List<Eventy>();
            }
            list.Add(eventOne);
            Eventy = list;

            gvEvents.DataSource = list;
            gvEvents.DataBind();
        }
    }
}