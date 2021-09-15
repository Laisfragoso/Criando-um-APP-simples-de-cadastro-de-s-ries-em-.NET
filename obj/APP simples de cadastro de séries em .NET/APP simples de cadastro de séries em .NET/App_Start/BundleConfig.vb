Imports System.Web
Imports System.Web.Optimization

Public Module BundleConfig
    ' Para obter mais informações sobre o agrupamento, visite https://go.microsoft.com/fwlink/?LinkId=301862
    Public Sub RegisterBundles(bundles As BundleCollection)
        bundles.Add(New ScriptBundle("~/bundles/jquery").Include(
            "~/Scripts/jquery-{version}.js"))

        bundles.Add(New ScriptBundle("~/bundles/jqueryval").Include(
            "~/Scripts/jquery.unobtrusive*",
            "~/Scripts/jquery.validate*"))

        bundles.Add(New ScriptBundle("~/bundles/knockout").Include(
            "~/Scripts/knockout-{version}.js",
            "~/Scripts/knockout.validation.js"))

        bundles.Add(New ScriptBundle("~/bundles/app").Include(
            "~/Scripts/sammy-{version}.js",
            "~/Scripts/app/common.js",
            "~/Scripts/app/app.datamodel.js",
            "~/Scripts/app/app.viewmodel.js",
            "~/Scripts/app/home.viewmodel.js",
            "~/Scripts/app/_run.js"))

        ' Use a versão em desenvolvimento do Modernizr para desenvolver e aprender. Em seguida, quando estiver
        ' pronto para a produção, utilize a ferramenta de build em https://modernizr.com para escolher somente os testes que precisa.
        bundles.Add(New ScriptBundle("~/bundles/modernizr").Include(
            "~/Scripts/modernizr-*"))

        bundles.Add(New ScriptBundle("~/bundles/bootstrap").Include(
            "~/Scripts/bootstrap.js"))

        bundles.Add(New StyleBundle("~/Content/css").Include(
            "~/Content/bootstrap.css",
            "~/Content/Site.css"))
    End Sub
End Module
