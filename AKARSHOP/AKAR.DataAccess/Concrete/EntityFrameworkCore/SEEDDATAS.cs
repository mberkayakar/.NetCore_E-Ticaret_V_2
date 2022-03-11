using AKAR.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKAR.DataAccess.Concrete.EntityFrameworkCore
{
    public static class SEEDDATAS
    {
        public static void seed()
        {
            var context = new EFContext();

            if (context.Categories.Count()==0)
            {
                context.Categories.AddRange(Categories);
                context.SaveChanges();

            }

            if (context.Products.Count() == 0)
            {
                context.Products.AddRange(Products);

                context.SaveChanges();
            }
        }

        #region KATEGORİ BİLGİLERİ :


        private static Category[] Categories = {
            new Category(){ CategoryName= "Telefon"},
            new Category(){ CategoryName= "Bilgisayar"},
            new Category(){ CategoryName= "Harici Birimler"}

        };


        #endregion

        #region ÜRÜN BİLGİLERİ 

        private static Product[] Products = {

            new Product(){ Name= "Samsung S5" , Price = 3000 , ImageURL ="https://n11scdn.akamaized.net/a1/1024/elektronik/ikinci-el-telefonlar/samsung-galaxy-s5-mini-siyah-teshir-urun-ucretsiz-kargo__0574368375655902.jpg", Description="Samsung Galaxy Serisinde 2014 yılında çıkardığı en iddalı telefon (4GB RAM /32GB STORAGE)" , IsApproved=true , CategoryId = 1 },

             new Product(){ Name= "Samsung S6" , Price = 4000 , ImageURL ="https://cdn.cimri.io/image/1000x1000/samsung-galaxy-s6-edge-64gb-siyah_26213504.jpg", Description="Samsung Galaxy Serisinde 2016 yılında çıkardığı en iddalı telefon (6GB RAM /64GB STORAGE)" , IsApproved=true , CategoryId = 1 },

             new Product(){ Name= "İphone 6s" , Price = 2000 , ImageURL ="https://productimages.hepsiburada.net/s/18/375/9783268933682.jpg", Description="İphone Serisi 6.Nesil  (2GB RAM /16 - 128 GB STORAGE)" , IsApproved=true , CategoryId = 1 },

             new Product(){ Name= "Samsung Galaxy S20 FE " , Price = 5500 , ImageURL ="https://cdn.cimri.io/image/1000x1000/samsung-galaxy-s20-fe-128gb-6gb-ram-65-inc-12mp-akilli-cep-telefonu-kirmizi_283384082.jpg", Description="Samsung Galaxy Serisinin Göz Bebeği Yeni Nesil S serisi S20 Fan Edition (8GB/256GB)" , IsApproved=true , CategoryId = 1 },

             new Product(){ Name= "ESP 8266" , Price = 85 , ImageURL ="https://ae01.alicdn.com/kf/Hc2eb798a9582478988704b517b091869G/2-adet-grup-ESP-01-ESP-01S-82-66-seri-Port-WIFI-mod-l-end-striyel.jpg", Description="İOT cihazlarının geliştiği dünyada Geliştirme kartlarının babası olarak bilinen ESP8266 nın wifi modülü karşınızda bulunmakta" , IsApproved=true , CategoryId = 1 },


        };


        #endregion


    }
}
