# Get started

- Clone to your system `git clone https://github.com/JamieSellars/KenticoXperience13WidgetTemplate.git c:\temp\KenticoXperience13WidgetTemplate`
- `dotnet new --install c:\temp\KenticoXperience13WidgetTemplate\src\Content\Template`

The template is now installed and ready to use.

Currently CLI item templates do not show within the Visual Studio context menu.

# Using

`doetnet new x13widget -h`

Options:

| Parameter |  Parameter name  |  Description | Example  |
|---|---|---|---|
| -P  |  ProjectName  |  Creates a namespace based on the project name | PartyPalace |   
| -W |  WidgetName | Provides a name to the widget, used on file, folders and class names | PartyPopper |   


`dotnet new x13widget -P PartyPalace -W PartyPopper`

```
.
+-- PartyPopperWidget
|   +-- PartyPopperWidgetProperties.cs
|   +-- PartyPopperWidgetViewModel.cs
|   +-- PartyPopperWidgetViewComponent.cs
|   +-- _Admin.cshtml
|   +-- _Public.cshtml
```
