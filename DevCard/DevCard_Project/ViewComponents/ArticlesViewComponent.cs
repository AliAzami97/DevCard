using DevCard_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_Project.ViewComponents
{
    public class ArticlesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var articles = new List<Article>()
            {
                new Article(1, "موبایل بانک" ,new List<string>{ "مدیریت حساب های مشتری", "مدیریت کارت های مشتری", "مدیریت تسهیلات و تعهدات", "انتقال وجه هوشمند", "کارت به کارت" } , "mobilebank.jpg","https://www.daneshrefah.ir/UI/Products#MobileBank"),
                new Article(2, "اینترنت بانک" ,new List<string>{ "مدیریت حساب های مشتری", "مدیریت کارت های مشتری", "مدیریت تسهیلات و تعهدات", "کارتابل خدمات اشتراکی", "مدیریت حساب های شرکتی" }, "internetbank.jpg","https://www.daneshrefah.ir/UI/Products#InternetBank"),
                new Article(3, "مدیریت کانال" ,new List<string>{ "مدیریت کانال های ارتباطی", "مدیریت کاربران کانال ها", "امکان تعریف سقف به ازاء کانال", "امکان مدیریت فرآیندهای کسب و کار", "امکان کارتابل فرآیندی" }, "wwrofhyyt0nw.jpeg","https://www.daneshrefah.ir/UI/Products#ChannelManagement"),
                new Article(4, "Core Bank" ,new List<string>{ "حساب‌ها و سپرده‌ها", "پرداخت و نقل‌وانتقال مالی", "کارت‌های بانکی", "مدیریت مشتریان (CIF)", "گزارش‌گیری و تحلیل داده" }, "logo.png","https://www.daneshrefah.ir/UI/Products#CoreBank"),
                new Article(5, "پیام رسان" ,new List<string>{ "ثبت‌نام و احراز هویت: ایمیل، شماره موبایل، یا شبکه‌های اجتماعی", "چت فردی و گروهی: ارسال پیام متنی، صوتی و تصویری",
                   "تماس صوتی و تصویری: کیفیت بالا و رمزنگاری‌شده", "اشتراک‌گذاری فایل: پشتیبانی از انواع فایل‌ها (تصویر، ویدئو، اسناد)", "مزنگاری پیام‌ها: امنیت سرتاسری (E2EE)" }, "ac93fc65a2d2272c0f8991b77af721d6.jpg","https://www.daneshrefah.ir/UI/Products#Messenger"),
                new Article(6, "Super App" ,new List<string>{ "سرویس‌های کارت مانند کارت به کارت (از مبدا کلیه بانک‌ها )، موجودی، سه گردش", "سرویس‌های استعلام قبوض",
                   "پرداخت حق بیمه تامین اجتماعی", "سرویس‌های خرید شارژ و بسته اینترنتی", "سرویس‌های چک صیادی مانند ثبت و استعلام" }, "202406141718347363621233.png","https://www.daneshrefah.ir/UI/Products#SuperApp"),
                new Article(7, "کیف پول (Wallet)" ,new List<string>{ "نرم‌افزار کیف پول الکترونیکی (E-Wallet) امکانات زیر را برای پاسخگویی به نیازهای کاربران در انجام تراکنش‌های مالی دیجیتال فراهم می کند"}, "What-Do-You-Mean-By-A-Digital-Wallet.jpg","https://www.daneshrefah.ir/UI/Products#Wallet"),
                new Article(8, "سوئیچ PSP" ,new List<string>{ "ماژول مدیریت تراکنش (Transaction Management)", "ماژول مسیریابی (Routing)",
                   "ماژول امنیت (Security)", "ماژول نظارت و گزارش‌گیری (Monitoring and Reporting)", "ماژول مدیریت کارت (Card Management)" }, "nn1xys0m_thumb3.jpg", "https://www.daneshrefah.ir/UI/Products#PspSwitch"),
                new Article(9, "پلتفرم معتمد مالیاتی (TSP)" ,new List<string>{ "سوئیچ TSP", "ثبت و مدیریت صورتحساب‌ها (Invoice Management)",
                   "اعتبارسنجی و تایید اطلاعات (Validation and Verification)", "ارسال به سامانه مودیان (Invoice Submission)", "گزارش‌گیری و تحلیل داده‌ها (Reporting and Analytics)" }, "لوگو_های-عصر-تراکنش-83-1.jpg", "https://www.daneshrefah.ir/UI/Products#TspSwitch"),
                new Article(10, "چکسام (Cheqsum)" ,new List<string>{ "سامانه چکسام با بهره‌گیری از تکنولوژی‌های مدرن و نوآوری‌هایی که در آن استفاده می‌شود، " +
                "به مشتریان حقوقی امکان می‌دهد فرآیند ثبت و مدیریت چک را بصورت غیرحضوری و گروهی بهبود بخشند و زمان و هزینه مورد نیاز را به شدت کاهش دهند." +
                " این سامانه با ایجاد یک رابط کاربری آسان و قابل دسترس بصورت آنلاین، به مشتریان امکان می‌دهد اطلاعات مربوط به چک‌های خود را به راحتی و با کیفیت بالا ثبت و پیگیری کنند."}, "Checksum.svg.png","https://www.daneshrefah.ir/UI/Products#Cheqsum"),
                new Article(11, "DB2 on REST (Z Service)" ,new List<string>{ "اجرای فرمان‌های دیتابیس مانند Query و Stored Procedure از طریق ساختاری یکپارچه به صورت Rest، و فارغ از زبان برنامه نویسی، آرزوی دیرینه‌ی تمام برنامه‌نویسان است." +
                " این پروژه، به صورت پویا، تمامی پراسیجرهایی که قابلیت اجرا داشته باشند را از جداول مورد نیاز دیتابیس Db2(z/os,LUW) با استفاده از ابزارهای طراحی شده توسط این شرکت، بارگذاری کرده " +
                "و در حافظه Cache به جهت دسترسی با سرعت بالا و عدم بارگذاری مجدد ساختار پراسیجرها نگهداری می‌کند." +
                " از مزیت‌های مهم این پروژه می‌توان به امکان دسترسی‌های موردی به سرویس‌های دیتابیس از طریق SSO، قابلیت لاگ به ازای هر درخواست ورودی و پاسخ خروجی از دیتابیس بصورت غیرهمزمان (Async) " +
                "به چندین مرکز لاگ (ELK، MongoDb و ...) و قابلیت مهم HA(Horizontal AutoScaling) و مدیریت درخواست‌های بالا (LoadBalance) اشاره کرد"}, "1_24061261_129965491,640x360,b,1_3.jpg", "https://www.daneshrefah.ir/UI/Products#ZService"),
                new Article(12, "خدمات مشاوره" ,new List<string>{ "ارزیابی و تحلیل فرآیندهای سازمان", "طراحی معماری سازمانی", "طراحی و پیاده سازی زیر ساخت DevOps", "طراحی اپلیکیشن های موبایلی در حوزه پرداخت", "راه حل های مدرن در حوزه معماری Core Bank" }, "thumb879293770.jpg", "https://www.daneshrefah.ir/UI/Products#Consultation"),

            };
            return View("_articles", articles);
        }
    }
}






