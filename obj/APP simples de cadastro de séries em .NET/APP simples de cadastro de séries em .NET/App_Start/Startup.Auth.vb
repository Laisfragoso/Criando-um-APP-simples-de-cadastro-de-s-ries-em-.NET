Imports Microsoft.AspNet.Identity
Imports Microsoft.AspNet.Identity.EntityFramework
Imports Microsoft.AspNet.Identity.Owin
Imports Microsoft.Owin
Imports Microsoft.Owin.Security.Cookies
Imports Microsoft.Owin.Security.DataProtection
Imports Microsoft.Owin.Security.Google
Imports Microsoft.Owin.Security.OAuth
Imports Owin

Partial Public Class Startup
    Private Shared _oAuthOptions As OAuthAuthorizationServerOptions
    Private Shared _publicClientId As String

    ' Habilitar o aplicativo a usar OAuthAuthorization. Então poderá proteger suas APIs da Web
    Shared Sub New()
        PublicClientId = "web"

        OAuthOptions = New OAuthAuthorizationServerOptions() With {
            .TokenEndpointPath = New PathString("/Token"),
            .AuthorizeEndpointPath = New PathString("/Account/Authorize"),
            .Provider = New ApplicationOAuthProvider(PublicClientId),
            .AccessTokenExpireTimeSpan = TimeSpan.FromDays(14),
            .AllowInsecureHttp = True
        }
    End Sub

    Public Shared Property OAuthOptions() As OAuthAuthorizationServerOptions
        Get
            Return _oAuthOptions
        End Get
        Private Set
            _oAuthOptions = Value
        End Set
    End Property

    Public Shared Property PublicClientId() As String
        Get
            Return _publicClientId
        End Get
        Private Set
            _publicClientId = Value
        End Set
    End Property

    ' Para obter mais informações sobre a autenticação de configuração, visite https://go.microsoft.com/fwlink/?LinkId=301864
    Public Sub ConfigureAuth(app As IAppBuilder)
        ' Configure o contexto db, gerenciador de usuários e gerenciador de login para usar uma única instância por solicitação
        app.CreatePerOwinContext(AddressOf ApplicationDbContext.Create)
        app.CreatePerOwinContext(Of ApplicationUserManager)(AddressOf ApplicationUserManager.Create)
        app.CreatePerOwinContext(Of ApplicationSignInManager)(AddressOf ApplicationSignInManager.Create)

        ' Habilitar o aplicativo a usar um cookie para armazenar informações do usuário logado
        ' e para usar um cookie para armazenar temporariamente informações sobre o login de um usuário com um provedor de login de terceiros
        ' Configurar o código de entrada
        ' OnValidateIdentity permite que o aplicativo valide o carimbo de segurança quando o usuário efetua login.
        ' Este é um recurso de segurança que é usado quando você altera uma senha ou adiciona um login externo à sua conta.
        app.UseCookieAuthentication(New CookieAuthenticationOptions() With {
            .AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
            .Provider = New CookieAuthenticationProvider() With {
                .OnValidateIdentity = SecurityStampValidator.OnValidateIdentity(Of ApplicationUserManager, ApplicationUser)(
                    validateInterval:=TimeSpan.FromMinutes(30),
                    regenerateIdentity:=Function(manager, user) user.GenerateUserIdentityAsync(manager))},
            .LoginPath = New PathString("/Account/Login")})

        app.UseExternalSignInCookie(DefaultAuthenticationTypes.ExternalCookie)

        ' Permite que o aplicativo armazene temporariamente as informações do usuário quando ele estiver verificando o segundo fator no processo de autenticação de dois fatores.
        app.UseTwoFactorSignInCookie(DefaultAuthenticationTypes.TwoFactorCookie, TimeSpan.FromMinutes(5))

        ' Permite que o aplicativo lembre segundo fator de verificação de login, como telefone ou email.
        ' Assim que você marcar esta opção, sua segunda etapa de verificação durante o processo de login será lembrada no dispositivo no qual você efetuou login.
        ' Isso é semelhante à opção RememberMe (Lembre-me) quando você efetua login.
        app.UseTwoFactorRememberBrowserCookie(DefaultAuthenticationTypes.TwoFactorRememberBrowserCookie)

        ' Habilitar o aplicativo a usar tokens de transferências para autenticar usuários
        app.UseOAuthBearerTokens(OAuthOptions)

        ' Remover comentário das seguintes linhas para habilitar o logon com provedores de logon de terceiros
        'app.UseMicrosoftAccountAuthentication(
        '    clientId:="",
        '    clientSecret:="")

        'app.UseTwitterAuthentication(
        '   consumerKey:="",
        '   consumerSecret:="")

        'app.UseFacebookAuthentication(
        '   appId:="",
        '   appSecret:="")

        'app.UseGoogleAuthentication(New GoogleOAuth2AuthenticationOptions() With {
        '   .ClientId = "",
        '   .ClientSecret = ""})
    End Sub
End Class
