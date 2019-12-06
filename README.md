# Our.Umbraco.EditLink

A simple package for Umbraco by Paul Seal from https://codeshare.co.uk

## NuGet

Install via NuGet: ``` Install-Package Our.Umbraco.EditLink ```

[![Nuget Downloads](https://img.shields.io/nuget/dt/Our.Umbraco.EditLink.svg)](https://www.nuget.org/packages/Our.Umbraco.EditLink)

[Or click here to go to the package landing page](https://www.nuget.org/packages/Our.Umbraco.EditLink)

This package is useful on sites with lots of content, where you just
need to edit a page that you can find easily on the front end of the
site, but it is harder to find in the backoffice.

With this package installed, if you are logged into the Umbraco backoffice whilst 
browsing the front end of the site, you will see a link to edit the page.

When you click the link it will open the page in a new tab.

## Dev Instructions ##

In your master view add

```
@using Our.Umbraco.EditLink
```

Then inside the body tag somewhere, just add

```
@Html.RenderEditLink(Model)
```

You can pass in different parameters to override these defaults:

```
    EditLinkPosition position = EditLinkPosition.TopLeft,
    bool applyInlineLinkStyles = true,
    string editMessage = "Edit",
    string linkColour = "#fff",
    string linkBackgroundColour = "#1b264f",
    int fontSize = 16,
    int linkPadding = 10,
    int borderRadius = 6,
    string linkClassName = "edit-link-inner",
    bool applyInlineOuterElementStyles = true,
    int margin = 10,
    int zindex = 10000,
    string umbracoEditContentUrl = "/umbraco#/content/content/edit/",
    string outerClassName = "edit-link-outer",
    string outerPosition = "fixed",
    string linkPosition = "absolute"
```
