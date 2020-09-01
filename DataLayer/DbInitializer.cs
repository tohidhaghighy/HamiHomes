using DomainLayer;
using DomainLayer.Magzine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer
{
    public static class DbInitializer
    {
        public static void Initialize(AmlakDbContext context)
        {
            context.Database.EnsureCreated();
            // Look for any students.
            if (context.Admins.Any())
            {
                return;
                // DB has been seeded
            }

            var users = new Admin[]
           {
            new Admin{Name="tarh o tasvir",Family="",Username="tarhotasvir",Password="o6d2N9TJbZw/jk4nityejFom+VuWVXAwKCIaMh2qSXEiSlbZqbIDTw==",Active=true,AdminType=DomainLayer.Enums.AdminType.GoldenAdmin}
           };
            foreach (Admin s in users)
            {
                context.Admins.Add(s);
            }

            var setting = new Setting()
            {
                Mobile="",
                Description="",
                Keys="",
                Title="",
                Phone="",
                Icon="",
                Author=""
            };
            context.Settings.Add(setting);


            var groups = new HomeGroup[]
          {
            new HomeGroup{Name="آپارتمان و سوِئیت",Icon=""},
            new HomeGroup{Name="خانه حیاط دار",Icon=""},
            new HomeGroup{Name="زمین",Icon=""},
            new HomeGroup{Name="کلنگی",Icon=""},
            new HomeGroup{Name="اداری",Icon=""},
            new HomeGroup{Name="مغازه",Icon=""},
            new HomeGroup{Name="مستغلات",Icon=""},
            new HomeGroup{Name="انبار و سوله",Icon=""},
            new HomeGroup{Name="باغ و باغچه",Icon=""},
            new HomeGroup{Name="ویلا",Icon=""},
            new HomeGroup{Name="کارخانه",Icon=""},
            new HomeGroup{Name="کارگاه",Icon=""}
          };
            foreach (HomeGroup s in groups)
            {
                context.HomeGroups.Add(s);
            }

      //      var noedivar = new AmlakDivar[]
      //   {
      //      new AmlakDivar{Name="نقاشی"},
      //      new AmlakDivar{Name="گچ"},
      //      new AmlakDivar{Name="سنگ"},
      //      new AmlakDivar{Name="کاغذ دیواری"},
      //      new AmlakDivar{Name="پارچه کوبی"},
      //      new AmlakDivar{Name="چوبکاری"}
      //   };
      //      foreach (AmlakDivar s in noedivar)
      //      {
      //          context.AmlakDivar.Add(s);
      //      }

      //      var emtiazamlak = new AmlakEmtiaz[]
      //  {
      //      new AmlakEmtiaz{Name="آب"},
      //      new AmlakEmtiaz{Name="برق"},
      //      new AmlakEmtiaz{Name="گاز"},
      //      new AmlakEmtiaz{Name="تلفن"}
      //  };
      //      foreach (AmlakEmtiaz s in emtiazamlak)
      //      {
      //          context.AmlakEmtiaz.Add(s);
      //      }


      //      var skeletonamlak = new AmlakEskeleton[]
      //  {
      //      new AmlakEskeleton{Name="فلزی جوشی"},
      //      new AmlakEskeleton{Name="فلزی پیچ و مهره"},
      //      new AmlakEskeleton{Name="اسکلت بتونی"}
      //  };
      //      foreach (AmlakEskeleton s in skeletonamlak)
      //      {
      //          context.AmlakEskeleton.Add(s);
      //      }

      //      var jahatvahed = new AmlakJahatVahed[]
      //  {
      //      new AmlakJahatVahed{Name="شمالی"},
      //      new AmlakJahatVahed{Name="جنوبی"},
      //      new AmlakJahatVahed{Name="شرقی"},
      //      new AmlakJahatVahed{Name="غربی"}
      //  };
      //      foreach (AmlakJahatVahed s in jahatvahed)
      //      {
      //          context.AmlakJahatVahed.Add(s);
      //      }

      //      var kafamlak = new AmlakKaf[]
      //  {
      //      new AmlakKaf{Name="سرامیک"},
      //      new AmlakKaf{Name="پارکت"},
      //      new AmlakKaf{Name="موکت"},
      //      new AmlakKaf{Name="موزاییک"},
      //      new AmlakKaf{Name="سیمان"},
      //      new AmlakKaf{Name="سنگ"}
      //  };
      //      foreach (AmlakKaf s in kafamlak)
      //      {
      //          context.AmlakKaf.Add(s);
      //      }


      //      var AmlakKitchen = new AmlakKitchen[]
      //  {
      //      new AmlakKitchen{Name="MDF"},
      //      new AmlakKitchen{Name="چوب"},
      //      new AmlakKitchen{Name="فلزی"},
      //      new AmlakKitchen{Name="جزیره"},
      //      new AmlakKitchen{Name="مدرن"},
      //      new AmlakKitchen{Name="کلاسیک"},
      //      new AmlakKitchen{Name="صفحه سنگ"},
      //      new AmlakKitchen{Name="صفحه کورین"},
      //      new AmlakKitchen{Name="صفحه چوب"},
      //      new AmlakKitchen{Name="اوپن"},
      //       new AmlakKitchen{Name="لاندری"},
      //      new AmlakKitchen{Name="فول فرنیش"},
      //      new AmlakKitchen{Name="هود"},
      //      new AmlakKitchen{Name="گازرومیزی"},
      //      new AmlakKitchen{Name="مطبخ"},
      //      new AmlakKitchen{Name="هایگلس"}
      //  };
      //      foreach (AmlakKitchen s in AmlakKitchen)
      //      {
      //          context.AmlakKitchen.Add(s);
      //      }


      //      var AmlakMelkStatus = new AmlakMelkStatus[]
      //  {
      //      new AmlakMelkStatus{Name="تخلیه"},
      //      new AmlakMelkStatus{Name="سکونت مستاجر"},
      //      new AmlakMelkStatus{Name="سکونت مالک"},
      //      new AmlakMelkStatus{Name="پایان کار"},
      //      new AmlakMelkStatus{Name="قولنامه ای"},
      //      new AmlakMelkStatus{Name="وام دارد"},
      //      new AmlakMelkStatus{Name="قابل معاوضه"},
      //      new AmlakMelkStatus{Name="جواز دارد"},
      //      new AmlakMelkStatus{Name="دستور نقشه دارد"},
      //      new AmlakMelkStatus{Name="مشارکت در ساخت"},
      //      new AmlakMelkStatus{Name="تراکم بالا"},
      //      new AmlakMelkStatus{Name="تراکم متوسط"},
      //      new AmlakMelkStatus{Name="تراکم پائین"},
      //      new AmlakMelkStatus{Name="سرقفلی"},
      //      new AmlakMelkStatus{Name="ملکیت"},
      //      new AmlakMelkStatus{Name="رهن و اجاره قابل تبدیل"}
      //  };
      //      foreach (AmlakMelkStatus s in AmlakMelkStatus)
      //      {
      //          context.AmlakMelkStatus.Add(s);
      //      }


      //      var AmlakMogheiatMelk = new AmlakMogheiatMelk[]
      //  {
      //      new AmlakMogheiatMelk{Name="شمالی"},
      //      new AmlakMogheiatMelk{Name="جنوبی"},
      //      new AmlakMogheiatMelk{Name="شرقی"},
      //      new AmlakMogheiatMelk{Name="غربی"},
      //      new AmlakMogheiatMelk{Name="داخل پاساژ"},
      //      new AmlakMogheiatMelk{Name="داخل بازار"},
      //      new AmlakMogheiatMelk{Name="داخل کوچه"},
      //      new AmlakMogheiatMelk{Name="براصلی"},
      //      new AmlakMogheiatMelk{Name="ساحلی"},
      //      new AmlakMogheiatMelk{Name="جنگلی"},
      //      new AmlakMogheiatMelk{Name="باغی"},
      //      new AmlakMogheiatMelk{Name="شهرکی"}
      //  };
      //      foreach (AmlakMogheiatMelk s in AmlakMogheiatMelk)
      //      {
      //          context.AmlakMogheiatMelk.Add(s);
      //      }


      //      var AmlakMoshaat = new AmlakMoshaat[]
      //  {
      //      new AmlakMoshaat{Name="آسانسور"},
      //      new AmlakMoshaat{Name="لابی"},
      //      new AmlakMoshaat{Name="رووف گاردن"},
      //      new AmlakMoshaat{Name="کارواش"},
      //      new AmlakMoshaat{Name="سالن اجتماعات"},
      //      new AmlakMoshaat{Name="سالن ورزشی"},
      //      new AmlakMoshaat{Name="استخر"},
      //      new AmlakMoshaat{Name="سونا"},
      //      new AmlakMoshaat{Name="جکوزی"}
      //  };
      //      foreach (AmlakMoshaat s in AmlakMoshaat)
      //      {
      //          context.AmlakMoshaat.Add(s);
      //      }


      //      var AmlakMoshakhase = new AmlakMoshakhase[]
      //  {
      //      new AmlakMoshakhase{Name="دوبلکس"},
      //      new AmlakMoshakhase{Name="پنت هاوس"},
      //      new AmlakMoshakhase{Name="لاکچری"},
      //      new AmlakMoshakhase{Name="فول امکانات"},
      //      new AmlakMoshakhase{Name="نشیمن مجزا"},
      //      new AmlakMoshakhase{Name="برج باغ"},
      //      new AmlakMoshakhase{Name="اختلاف سطح"},
      //      new AmlakMoshakhase{Name="بازسازی شده"},
      //      new AmlakMoshakhase{Name="تریبلکس"},
      //      new AmlakMoshakhase{Name="تجمع"},
      //      new AmlakMoshakhase{Name="تودلی"},
      //      new AmlakMoshakhase{Name="بن بست"},
      //      new AmlakMoshakhase{Name="دو نبش"},
      //      new AmlakMoshakhase{Name="دو دهنه"}
      //  };
      //      foreach (AmlakMoshakhase s in AmlakMoshakhase)
      //      {
      //          context.AmlakMoshakhase.Add(s);
      //      }



      //      var AmlakNema = new AmlakNema[]
      //  {
      //      new AmlakNema{Name="کامپوزیت"},
      //      new AmlakNema{Name="شیشه"},
      //      new AmlakNema{Name="ترکیبی"}
      //  };
      //      foreach (AmlakNema s in AmlakNema)
      //      {
      //          context.AmlakNema.Add(s);
      //      }

      //      var AmlakNoeZamin = new AmlakNoeZamin[]
      // {
      //      new AmlakNoeZamin{Name="مسکونی"},
      //      new AmlakNoeZamin{Name="تجاری"},
      //      new AmlakNoeZamin{Name="باغ"},
      //      new AmlakNoeZamin{Name="خدماتی"},
      //      new AmlakNoeZamin{Name="فرهنگی"},
      //      new AmlakNoeZamin{Name="مزروعی"},
      //      new AmlakNoeZamin{Name="صنعتی"},
      //      new AmlakNoeZamin{Name="شهری"},
      //      new AmlakNoeZamin{Name="شهرکی"},
      // };
      //      foreach (AmlakNoeZamin s in AmlakNoeZamin)
      //      {
      //          context.AmlakNoeZamin.Add(s);
      //      }

      //      var AmlakParking = new AmlakParking[]
      // {
      //      new AmlakParking{Name="مشاع"},
      //      new AmlakParking{Name="اختصاصی"},
      //      new AmlakParking{Name="مزاحم"}
      // };
      //      foreach (AmlakParking s in AmlakParking)
      //      {
      //          context.AmlakParking.Add(s);
      //      }

      //      var AmlakPishraftStatus = new AmlakPishraftStatus[]
      // {
      //      new AmlakPishraftStatus{Name="تخریب"},
      //      new AmlakPishraftStatus{Name="گود برداری"},
      //      new AmlakPishraftStatus{Name="فونداسیون"},
      //      new AmlakPishraftStatus{Name="اسکلت"},
      //      new AmlakPishraftStatus{Name="گچ و خاک"},
      //      new AmlakPishraftStatus{Name="تیغه چینی"},
      //      new AmlakPishraftStatus{Name="نازک کاری"},
      //      new AmlakPishraftStatus{Name="تاسیسات"}
      // };
      //      foreach (AmlakPishraftStatus s in AmlakPishraftStatus)
      //      {
      //          context.AmlakPishraftStatus.Add(s);
      //      }


      //      var AmlakSaghf = new AmlakSaghf[]
      // {
      //      new AmlakSaghf{Name="دال بتونی"},
      //      new AmlakSaghf{Name="کامپوزیت"},
      //      new AmlakSaghf{Name="عرشه فولادی"},
      //      new AmlakSaghf{Name="تیرچه و بلوک"},
      //      new AmlakSaghf{Name="تیرچه یونولیت"},
      //      new AmlakSaghf{Name="آجر ضربی"},
      //      new AmlakSaghf{Name="کششی"},
      //      new AmlakSaghf{Name="اسپانیش"}
      // };
      //      foreach (AmlakSaghf s in AmlakSaghf)
      //      {
      //          context.AmlakSaghf.Add(s);
      //      }


      //      var AmlakSanadStatus = new AmlakSanadStatus[]
      // {
      //      new AmlakSanadStatus{Name="سند دارد"},
      //      new AmlakSanadStatus{Name="وکالتی"},
      //      new AmlakSanadStatus{Name="شخصی"},
      //      new AmlakSanadStatus{Name="اوقافی"},
      //      new AmlakSanadStatus{Name="بنیادی"},
      //      new AmlakSanadStatus{Name="آستانه"}
      // };
      //      foreach (AmlakSanadStatus s in AmlakSanadStatus)
      //      {
      //          context.AmlakSanadStatus.Add(s);
      //      }

      //      var AmlakTasisatGarmaieshi = new AmlakTasisatGarmaieshi[]
      // {
      //      new AmlakTasisatGarmaieshi{Name="اسپیلت"},
      //      new AmlakTasisatGarmaieshi{Name="داکت اسپیلت"},
      //      new AmlakTasisatGarmaieshi{Name="کولر آبی"},
      //      new AmlakTasisatGarmaieshi{Name="پکیج و رادیاتور"},
      //      new AmlakTasisatGarmaieshi{Name="گرمایش از کف"},
      //      new AmlakTasisatGarmaieshi{Name="بخاری"},
      //      new AmlakTasisatGarmaieshi{Name="هواساز"},
      //      new AmlakTasisatGarmaieshi{Name="موتور خانه مرکزی"},
      //      new AmlakTasisatGarmaieshi{Name="چیلر"},
      // };
      //      foreach (AmlakTasisatGarmaieshi s in AmlakTasisatGarmaieshi)
      //      {
      //          context.AmlakTasisatGarmaieshi.Add(s);
      //      }


      //      var AmlakWC = new AmlakWC[]
      //{
      //      new AmlakWC{Name="ایرانی"},
      //      new AmlakWC{Name="فرنگی"},
      //      new AmlakWC{Name="وان"},
      //      new AmlakWC{Name="جکوزی"}
      //};
      //      foreach (AmlakWC s in AmlakWC)
      //      {
      //          context.AmlakWC.Add(s);
      //      }

      //      var Grouplist = new MagazinGroup[]
      //{
      //      new MagazinGroup{Name="دکوراسیون",ParentId=0},
      //      new MagazinGroup{Name="معماری" ,ParentId=0},
      //      new MagazinGroup{Name="قوانین" ,ParentId=0},
      //      new MagazinGroup{Name="تور محله گردی" ,ParentId=0}
      //};
      //      foreach (MagazinGroup s in Grouplist)
      //      {
      //          context.MagazinGroupes.Add(s);
      //      }

            context.SaveChanges();


        }
    }
}
