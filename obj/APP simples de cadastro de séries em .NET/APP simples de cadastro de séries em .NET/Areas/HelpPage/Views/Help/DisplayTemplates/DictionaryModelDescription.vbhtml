@Imports APP_simples_de_cadastro_de_séries_em.NET.Areas.HelpPage.ModelDescriptions
@ModelType DictionaryModelDescription
Dictionary of @Html.DisplayFor(Function(m) Model.KeyModelDescription.ModelType, "ModelDescriptionLink", New With { .modelDescription = Model.KeyModelDescription }) [key]
and @Html.DisplayFor(Function(m) Model.ValueModelDescription.ModelType, "ModelDescriptionLink", New With { .modelDescription = Model.ValueModelDescription }) [value]