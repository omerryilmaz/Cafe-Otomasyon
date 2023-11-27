using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeOtomasyonu.Entities.Models;
using CafeOtomasyonu.WinForms.WinTools;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;

namespace CafeOtomasyonu.WinForms.Roles
{
    public class KullaniciYetki
    {
        public static void YetkileriGetir(CafeContext context, RibbonControl ribbon)
        {
            foreach (var item in ribbon.Items)
            {
                foreach (var roller in context.Rollers.Where(r=>r.KullaniciId==KullaniciAyarlari.kullaniciId).ToList())
                {
                    if (item is BarButtonItem)
                    {
                        var btn = item as BarButtonItem;
                        if (btn.Name == roller.ControlName && roller.Visible)
                        {
                            btn.Enabled=true;
                        }
                        if(btn.Name == roller.ControlName && !roller.Visible)
                        {
                            btn.Enabled = false;
                        }
                    }
                }
            }
        }

        public static void AdminMi(CafeContext context,params dynamic[] obj)
        {
            var adminkontrol = context.Kullanicilar.FirstOrDefault(k => k.Id == KullaniciAyarlari.kullaniciId);
            if (adminkontrol.IsAdmin)
            {
                for (int i = 0; i < obj.Length; i++)
                {
                    obj[i].Enabled = true;
                }


            }
            else if (!adminkontrol.IsAdmin)
            {
                for (int i = 0; i < obj.Length; i++)
                {
                    obj[i].Enabled = false;
                }

            }
        }
    }
}
