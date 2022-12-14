using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    // newlememek için static veriliyor.
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        public static string MaintenanceTime="Sistem bakımda.";
        public static string ProductsListed="Ürünler listelendi.";
        public static string ProductCountOfCategoryError="Bir kategoride en fazla 10 ürün olabilir.";
        public static string ProductNameAlreadyExists="Aynı isimde ürün zaten var.";

        public static string CategoryIdBiggerThanFifteen = "Kategori Id 15ten büyük olamaz";
        internal static string CategoryLimitExceded="Kategori Limiti aşıldığı için yeni ürün eklenemiyor.";
    }
}
