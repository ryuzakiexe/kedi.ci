﻿using dataaccesslayer0;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace kedi.ci
{
    public partial class Default : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            rp_makaleler.DataSource = dm.MakaleListele();
            rp_makaleler.DataBind();
        }
    }
}