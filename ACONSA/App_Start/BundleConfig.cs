using System.Web.Optimization;

namespace ACONSA.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundle(BundleCollection bundles)
        {
            /****************************************************...CSS ORIGINAL...****************************************************/
            //< !--Fontfaces CSS-- >
            //< link href = "~/Content/css/font-face.css" rel = "stylesheet" media = "all" >
            //< link href = "~/Content/vendor/font-awesome-4.7/css/font-awesome.min.css" rel = "stylesheet" media = "all" >
            //< link href = "~/Content/vendor/font-awesome-5/css/fontawesome-all.min.css" rel = "stylesheet" media = "all" >
            //< link href = "~/Content/vendor/mdi-font/css/material-design-iconic-font.min.css" rel = "stylesheet" media = "all" >
            //< !--Bootstrap CSS-- >
            //< link href = "~/Content/vendor/bootstrap-4.1/bootstrap.min.css" rel = "stylesheet" media = "all" >
            //< !--Vendor CSS-- >
            //< link href = "~/Content/vendor/animsition/animsition.min.css" rel = "stylesheet" media = "all" >
            //< link href = "~/Content/vendor/bootstrap-progressbar/bootstrap-progressbar-3.3.4.min.css" rel = "stylesheet" media = "all" >
            //< link href = "~/Content/vendor/wow/animate.css" rel = "stylesheet" media = "all" >
            //< link href = "~/Content/vendor/css-hamburgers/hamburgers.min.css" rel = "stylesheet" media = "all" >
            //< link href = "~/Content/vendor/slick/slick.css" rel = "stylesheet" media = "all" >
            //< link href = "~/Content/vendor/select2/select2.min.css" rel = "stylesheet" media = "all" >
            //< link href = "~/Content/vendor/perfect-scrollbar/perfect-scrollbar.css" rel = "stylesheet" media = "all" >
            //< !--Main CSS-- >
            //< link href = "~/Content/css/theme.css" rel = "stylesheet" media = "all" >
            /*****************************************************************************************************************************/
            bundles.Add(new StyleBundle("~/bundles/css")
                .Include(
               
                "~/Content/css/font-face.css",
                "~/Content/vendor/font-awesome-4.7/css/font-awesome.min.css",
                "~/Content/vendor/font-awesome-5/css/fontawesome-all.min.css",
                "~/Content/vendor/mdi-font/css/material-design-iconic-font.min.css",
                "~/Content/vendor/bootstrap-4.1/bootstrap.min.css",
                "~/Content/vendor/animsition/animsition.min.css",
                "~/Content/vendor/bootstrap-progressbar/bootstrap-progressbar-3.3.4.min.css",
                "~/Content/vendor/wow/animate.css",
                "~/Content/vendor/css-hamburgers/hamburgers.min.css",
                "~/Content/vendor/slick/slick.css",
                "~/Content/vendor/select2/select2.min.css",
                "~/Content/vendor/perfect-scrollbar/perfect-scrollbar.css",
                "~/Content/css/theme.css"
                
                ));

            /****************************************************...JS ORIGINAL...****************************************************/
            //< !--Jquery JS-- >
            //< script src = "~/Content/vendor/jquery-3.2.1.min.js" ></ script >
            //< !--Bootstrap JS-- >
            //< script src = "~/Content/vendor/bootstrap-4.1/popper.min.js" ></ script >
            //< script src = "~/Content/vendor/bootstrap-4.1/bootstrap.min.js" ></ script >
            //< !--Vendor JS-- >
            //< script src = "~/Content/vendor/slick/slick.min.js" ></ script >
            //< script src = "~/Content/vendor/wow/wow.min.js" ></ script >
            //< script src = "~/Content/vendor/animsition/animsition.min.js" ></ script >
            //< script src = "~/Content/vendor/bootstrap-progressbar/bootstrap-progressbar.min.js" ></ script >
            //< script src = "~/Content/vendor/counter-up/jquery.waypoints.min.js" ></ script >
            //< script src = "~/Content/vendor/counter-up/jquery.counterup.min.js" ></ script >
            //< script src = "~/Content/vendor/circle-progress/circle-progress.min.js" ></ script >
            //< script src = "~/Content/vendor/perfect-scrollbar/perfect-scrollbar.js" ></ script >
            //< script src = "~/Content/vendor/chartjs/Chart.bundle.min.js" ></ script >
            //< script src = "~/Content/vendor/select2/select2.min.js" ></ script >
            //< !--Main JS-- >
            //< script src = "~/Content/js/main.js" ></ script >
            /*****************************************************************************************************************************/
            bundles.Add(new ScriptBundle("~/bundles/js")
                .Include
                (
                "~/Content/vendor/jquery-3.2.1.min.js",
                "~/Content/vendor/bootstrap-4.1/popper.min.js",
                "~/Content/vendor/bootstrap-4.1/bootstrap.min.js",
                "~/Content/vendor/slick/slick.min.js",
                "~/Content/vendor/wow/wow.min.js",
                "~/Content/vendor/animsition/animsition.min.js",
                "~/Content/vendor/bootstrap-progressbar/bootstrap-progressbar.min.js",
                "~/Content/vendor/counter-up/jquery.waypoints.min.js",
                "~/Content/vendor/counter-up/jquery.counterup.min.js",
                "~/Content/vendor/circle-progress/circle-progress.min.js",
                "~/Content/vendor/perfect-scrollbar/perfect-scrollbar.js",
                "~/Content/vendor/chartjs/Chart.bundle.min.js",
                "~/Content/vendor/select2/select2.min.js",
                "~/Content/js/main.js"
                ));

        }
    }
}