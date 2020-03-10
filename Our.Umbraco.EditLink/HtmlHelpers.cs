using System.Text;
using System.Web;
using System.Web.Mvc;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web.Security;

namespace Our.Umbraco.EditLink
{
    public static class HtmlHelpers
    {
        public static IHtmlString RenderEditLink(
            this HtmlHelper helper,
            IPublishedContent thisPage,
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
            string linkPosition = "absolute")
        {
            StringBuilder editLinkCode = new StringBuilder();
            var userTicket = new HttpContextWrapper(HttpContext.Current).GetUmbracoAuthTicket();

            if (userTicket != null)
            {
                //Render the starting outer div
                editLinkCode.Append($"<div");
                editLinkCode.Append($" class=\"{outerClassName}\"");

                //Render the inline styles for the outer div
                if (applyInlineOuterElementStyles)
                {
                    string outerStyles = GetOuterElementStyles(outerPosition, position, margin, zindex, linkPadding);
                    editLinkCode.Append($" style=\"{outerStyles}\"");
                }
                editLinkCode.Append($">");

                //Render the link
                editLinkCode.Append($"<a href=\"{umbracoEditContentUrl}{thisPage.Id}\"");
                editLinkCode.Append($" target=\"_blank\"");
                editLinkCode.Append($" class=\"{linkClassName}\"");

                //Render the inline styles for the link
                if (applyInlineLinkStyles)
                {
                    string linkStyles = GetLinkStyles(linkColour, linkBackgroundColour, linkPadding, fontSize, borderRadius);
                    editLinkCode.Append($"style=\"{linkStyles}\"");
                }

                //Render the link text and closing tag
                editLinkCode.Append($">{editMessage}</a>");

                //Render the closing outer div
                editLinkCode.Append($"</div>");
            }

            return MvcHtmlString.Create(editLinkCode.ToString());
        }

        private static string GetLinkStyles(string linkColour, string linkBackgroundColour,
            int linkPadding, int fontSize, int borderRadius)
        {
            StringBuilder linkStyles = new StringBuilder();
            linkStyles.Append($"color:{linkColour};");
            linkStyles.Append($"background-color:{linkBackgroundColour};");
            linkStyles.Append($"padding:{linkPadding}px;");
            linkStyles.Append($"font-size:{fontSize}px;");
            linkStyles.Append($"border-radius:{borderRadius}px;");
            return linkStyles.ToString();
        }

        private static string GetOuterElementStyles(string outerPosition, EditLinkPosition position,
            int margin, int zindex, int linkPadding)
        {
            linkPadding = linkPadding / 2;

            StringBuilder outerStyles = new StringBuilder();

            outerStyles.Append("display:block;");
            if (outerPosition == "fixed")
            {
                switch (position)
                {
                    case EditLinkPosition.TopLeft:
                        outerStyles.Append($"top:{margin + linkPadding}px;");
                        outerStyles.Append($"left:{margin}px;");
                        break;
                    case EditLinkPosition.TopRight:
                        outerStyles.Append($"top:{margin + linkPadding}px;");
                        outerStyles.Append($"right:{margin}px;");
                        break;
                    case EditLinkPosition.BottomRight:
                        outerStyles.Append($"bottom:{margin + linkPadding}px;");
                        outerStyles.Append($"right:{margin}px;");
                        break;
                    case EditLinkPosition.BottomLeft:
                        outerStyles.Append($"bottom:{margin + linkPadding}px;");
                        outerStyles.Append($"left:{margin}px;");
                        break;
                }
            }

            outerStyles.Append($"z-index:{zindex};");
            outerStyles.Append($"position:{outerPosition};");

            return outerStyles.ToString();
        }
    }
}
