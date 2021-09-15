Imports System.ComponentModel.DataAnnotations

Public Class ExternalLoginConfirmationViewModel
    <Required>
    <Display(Name:="Email")>
    Public Property Email As String

    <Display(Name:="Cidade natal")>
    Public Property Hometown As String
End Class

Public Class ExternalLoginListViewModel
    Public Property ReturnUrl As String
End Class

Public Class SendCodeViewModel
    Public Property SelectedProvider As String
    Public Property Providers As ICollection(Of System.Web.Mvc.SelectListItem)
    Public Property ReturnUrl As String
    Public Property RememberMe As Boolean
End Class

Public Class VerifyCodeViewModel
    <Required>
    Public Property Provider As String

    <Required>
    <Display(Name:="Código")>
    Public Property Code As String

    Public Property ReturnUrl As String

    <Display(Name:="Lembrar deste navegador?")>
    Public Property RememberBrowser As Boolean

    Public Property RememberMe As Boolean
End Class

Public Class ForgotViewModel
    <Required>
    <Display(Name:="Email")>
    Public Property Email As String
End Class

Public Class LoginViewModel
    <Required>
    <Display(Name:="Email")>
    <EmailAddress>
    Public Property Email As String

    <Required>
    <DataType(DataType.Password)>
    <Display(Name:="Senha")>
    Public Property Password As String

    <Display(Name:="Lembrar-me?")>
    Public Property RememberMe As Boolean
End Class

Public Class RegisterViewModel
    <Required>
    <EmailAddress>
    <Display(Name:="Email")>
    Public Property Email As String

    <Required>
    <StringLength(100, ErrorMessage:="O {0} deve ter pelo menos {2} caracteres.", MinimumLength:=6)>
    <DataType(DataType.Password)>
    <Display(Name:="Senha")>
    Public Property Password As String

    <DataType(DataType.Password)>
    <Display(Name:="Confirmar senha")>
    <Compare("Password", ErrorMessage:="A senha e a senha de confirmação não coincidem.")>
    Public Property ConfirmPassword As String

    <Display(Name:="Cidade natal")>
    Public Property Hometown As String
End Class

Public Class ResetPasswordViewModel
    <Required>
    <EmailAddress>
    <Display(Name:="Email")>
    Public Property Email() As String

    <Required>
    <StringLength(100, ErrorMessage:="O {0} deve ter pelo menos {2} caracteres.", MinimumLength:=6)>
    <DataType(DataType.Password)>
    <Display(Name:="Senha")>
    Public Property Password() As String

    <DataType(DataType.Password)>
    <Display(Name:="Confirmar senha")>
    <Compare("Password", ErrorMessage:="A senha e a senha de confirmação não coincidem.")>
    Public Property ConfirmPassword() As String

    Public Property Code() As String
End Class

Public Class ForgotPasswordViewModel
    <Required>
    <EmailAddress>
    <Display(Name:="E-mail")>
    Public Property Email() As String
End Class
