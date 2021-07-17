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
| -P  |  ProductName  |  Creates a namespace based on the project name | ProductName.Components.Widget.WidgetName  |   
| -W |  WidgetName | Provides a name to the widget, used on file, folders and class names | PartyPopper |   

After executing the document you will be presented with the following folder structure

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
