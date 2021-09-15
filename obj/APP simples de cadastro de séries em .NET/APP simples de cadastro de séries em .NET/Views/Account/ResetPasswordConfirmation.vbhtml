@Code
    ViewBag.Title = "Redefinir confirmação de senha"
End Code

<hgroup class="title">
    <h1>@ViewBag.Title.</h1>
</hgroup>
<div>
    <p>
        Sua senha foi redefinida. @Html.ActionLink("clique aqui para fazer logon", "Login", "Account", routeValues:=Nothing, htmlAttributes:=New With {Key .id = "loginLink"})
    </p>
</div>
