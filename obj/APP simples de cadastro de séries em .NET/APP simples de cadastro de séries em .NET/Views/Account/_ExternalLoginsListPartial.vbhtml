@ModelType ExternalLoginListViewModel
@Imports Microsoft.Owin.Security
@Code
    Dim loginProviders = Context.GetOwinContext().Authentication.GetExternalAuthenticationTypes()
End Code
<h4>Use outro serviço para fazer o logon.</h4>
<hr />
@If loginProviders.Count() = 0 Then
    @<div>
          <p>
              Não há nenhum serviço de autenticação externo configurado. Confira <a href="https://go.microsoft.com/fwlink/?LinkId=403804">este artigo</a>
              para obter detalhes de como configurar este aplicativo ASP.NET para permitir o registro em log usando serviços externos.
          </p>
    </div>
Else
    @Using Html.BeginForm("ExternalLogin", "Account", New With {.ReturnUrl = Model.ReturnUrl}, FormMethod.Post, New With {.class = "form-horizontal", .role = "form"})
        @Html.AntiForgeryToken()
        @<div id="socialLoginList">
           <p>
               @For Each p As AuthenticationDescription In loginProviders
                   @<button type="submit" class="btn btn-default" id="@p.AuthenticationType" name="provider" value="@p.AuthenticationType" title="Faça login usando sua conta @p.Caption">@p.AuthenticationType</button>
               Next
           </p>
        </div>
    End Using
End If
