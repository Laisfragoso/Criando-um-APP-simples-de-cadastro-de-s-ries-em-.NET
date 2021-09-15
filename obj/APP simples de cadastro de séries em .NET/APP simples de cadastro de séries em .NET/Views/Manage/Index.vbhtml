@ModelType IndexViewModel
@Code
    ViewBag.Title = "Gerenciar"
End Code

<h2>@ViewBag.Title.</h2>

<p class="text-success">@ViewBag.StatusMessage</p>
<div>
    <h4>Alterar as configurações de conta</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>Senha:</dt>
        <dd>
            [
            @If Model.HasPassword Then
                @Html.ActionLink("Alterar sua senha", "ChangePassword")
            Else
                @Html.ActionLink("Criar", "SetPassword")
            End If
            ]
        </dd>
        <dt>Logins externos:</dt>
        <dd>
            @Model.Logins.Count [
            @Html.ActionLink("Gerenciar", "ManageLogins") ]
        </dd>
        @*
            Os Números de Telefone podem ser usados como um segundo fator de verificação em um sistema de autenticação de dois fatores.
             
             Confira <a href="https://go.microsoft.com/fwlink/?LinkId=403804">este artigo</a>
                para obter detalhes de como configurar este aplicativo ASP.NET para permitir a autenticação de dois fatores usando SMS.
             
             Remova a marca de comentário do bloco a seguir depois de configurar a autenticação de dois fatores
        *@
        @* 
            <dt>Número de Telefone:</dt>
            <dd>
                @(If(Model.PhoneNumber, "None"))
                @If (Model.PhoneNumber <> Nothing) Then
                    @<br />
                    @<text>[&nbsp;&nbsp;@Html.ActionLink("Change", "AddPhoneNumber")&nbsp;&nbsp;]</text>
                    @Using Html.BeginForm("RemovePhoneNumber", "Manage", FormMethod.Post, New With {.class = "form-horizontal", .role = "form"})
                        @Html.AntiForgeryToken
                        @<text>[<input type="submit" value="Remover" class="btn-link" />]</text>
                    End Using
                Else
                    @<text>[&nbsp;&nbsp;@Html.ActionLink("Add", "AddPhoneNumber") &nbsp;&nbsp;]</text>
                End If
            </dd>
        *@
        <dt>Autenticação de dois fatores:</dt>
        <dd>
            <p>
                Não há nenhum provedor de autenticação de dois fatores configurado. Confira <a href="https://go.microsoft.com/fwlink/?LinkId=403804">este artigo</a>
                para obter detalhes de como configurar este aplicativo ASP.NET para permitir a autenticação de dois fatores.
            </p>
            @*
                @If Model.TwoFactor Then
                    @Using Html.BeginForm("DisableTwoFactorAuthentication", "Manage", FormMethod.Post, New With { .class = "form-horizontal", .role = "form" })
                      @Html.AntiForgeryToken()
                      @<text>
                      Habilitado
                      <input type="submit" value="Desabilitar" class="btn btn-link" />
                      </text>
                    End Using
                Else
                    @Using Html.BeginForm("EnableTwoFactorAuthentication", "Manage", FormMethod.Post, New With { .class = "form-horizontal", .role = "form" })
                      @Html.AntiForgeryToken()
                      @<text>
                      Desabilitado
                      <input type="submit" value="Habilitar" class="btn btn-link" />
                      </text>
                    End Using
                End If
	     *@
        </dd>
    </dl>
</div>
