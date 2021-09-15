@Imports APP_simples_de_cadastro_de_séries_em.NET.Areas.HelpPage.ModelDescriptions
@ModelType CollectionModelDescription
@If TypeOf Model.ElementDescription Is ComplexTypeModelDescription Then
    @Html.DisplayFor(Function(m) m.ElementDescription)
End If