
✍✍✍✍  ✍✍✍    ✍  ✍✍✍✍✍   ✍        ✍  ✍     ✍  ✍   ✍
✍        ✍   ✍  ✍     ✍       ✍        ✍  ✍✍   ✍  ✍ ✍
✍✍✍    ✍   ✍  ✍     ✍       ✍        ✍  ✍  ✍ ✍  ✍✍
✍        ✍   ✍  ✍     ✍       ✍        ✍  ✍   ✍✍  ✍  ✍
✍✍✍✍  ✍✍✍    ✍     ✍       ✍✍✍✍  ✍  ✍     ✍  ✍   ✍
                                                                           
-------------------------------------------------------------------

A simple package for Umbraco by Paul Seal from https://codeshare.co.uk

This package is useful on sites with lots of content, where you just
need to edit a page that you can find easily on the front end of the
site, but it is harder to find in the backoffice.

With this package installed, if you are logged into the Umbraco backoffice whilst 
browsing the front end of the site, you will see a link to edit the page.

When you click the link it will open the page in a new tab.

## Dev Instructions ##

In your master view add

@Using Our.Umbraco.EditLink

Then inside the body tag somewhere, just add

@RenderEditLink(Model)

You can pass in different parameters to override these defaults:

position = EditLinkPosition.TopLeft, 
linkColour = "#00aea2", 
editMessage = "Edit",
margin = 10, 
zindex = 10000, 
umbracoEditContentUrl = "/umbraco#/content/content/edit/",
fontSize = 16, 
outerPosition = "fixed", 
linkPosition = "absolute",
outerClassName = "edit-link-outer", 
linkClassName = "edit-link-inner"

Here is the link to the GitHub project https://github.com/prjseal/Our.Umbraco.EditLink

-------------------------------------------------------------------------------------

   ( (
    ) )       If you would like to show your appreciation for this package, 
  ........    you could buy me a coffee, if you want.
  |      |]   
  \      /    https://codeshare.co.uk/coffee
   `----'