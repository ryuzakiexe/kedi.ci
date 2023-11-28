﻿using dataaccesslayer0;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace kedi.ci
{
    public partial class Giris : System.Web.UI.Page
    {
      DataModel db = new DataModel(); 
        protected void Page_Load(object sender, EventArgs e)
        {
            pnl_hata.Visible = false;
        }
        protected void lbtn_giris_Click(object sender, EventArgs e)
        {
            if (tb_isim.Text.Length >= 3)
            {
                Yonetici y = db.YoneticiKontrol(tb_isim.Text, tb_sifre.Text);
                if (y != null)
                {
                    if (y.Aktif)
                    {
                        Session["yon"] = y;//BOXING
                        Response.Redirect("Anasayfa.aspx");
                    }
                    else
                    {
                        pnl_hata.Visible = true;
                        lbl_hata.Text = "Hesabınız yönetici tarafından askıya alınmıştır";
                    }
                }
                else
                {
                    pnl_hata.Visible = true;
                    lbl_hata.Text = "Kullanıcı Bulunamadı. Kullanıcı Adı ve şifreyi kontrol ediniz";
                }
            }
            else
            {
                
                pnl_hata.Visible = true;
                lbl_hata.Text = "Kullanıcı Adı 3 karakterden az olamaz";
              
            }
            
         
           
        }
       
        
    }
    
}