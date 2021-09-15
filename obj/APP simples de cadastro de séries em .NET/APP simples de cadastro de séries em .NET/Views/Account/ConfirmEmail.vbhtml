@Code
    ViewBag.Title = "Confirmar e-mail"
End Code

<h2>@ViewBag.Title.</h2>
<div>
    <p>
        Obrigado por confirmar seu email. Por favor @Html.ActionLink("Clique aqui para efetuar login", "Login", "Account", routeValues:=Nothing, htmlAttributes:=New With {Key .id = "loginLink"})
    </p>
</div>
