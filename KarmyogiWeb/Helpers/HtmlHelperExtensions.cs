using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace KarmyogiWeb
{
    public static class HtmlHelperExtensions
    {
        public static MvcHtmlString AgeFormat(this HtmlHelper helper, DateTime dob)
        {
            string today = DateTime.Now.ToString("yyyyMMdd");

            TagBuilder tb = new TagBuilder("span");
            tb.InnerHtml = ((Convert.ToInt32(today) - Convert.ToInt32(dob.ToString("yyyyMMdd"))) / 10000).ToString();
            return new MvcHtmlString(tb.ToString());
        }

        public static MvcHtmlString ActionImage(this HtmlHelper helper, String controller, String action, Object parameters, String iconClass, String iconText)
        {
            TagBuilder tagBuilder = new TagBuilder("i");
            UrlHelper urlHelper = new UrlHelper(helper.ViewContext.RequestContext);
            String url = urlHelper.Action(action, controller, parameters);

            String icon = "";
            StringBuilder html = new StringBuilder();

            // build the image tag.
            tagBuilder.MergeAttribute("class", iconClass);
            tagBuilder.InnerHtml = iconText;
            icon = tagBuilder.ToString(TagRenderMode.Normal);

            html.Append("<a href=\"");
            html.Append(url);
            html.Append("\">");
            html.Append(icon);
            html.Append("</a>");

            return MvcHtmlString.Create(html.ToString());
        }

        public static MvcHtmlString ActionImage(this HtmlHelper html, string action, string controller, Object parameters, string iconClass, string iconText, object htmlAttributesForAnchor)
        {
            var url = new UrlHelper(html.ViewContext.RequestContext);

            // build the <i> tag
            var imgBuilder = new TagBuilder("i");
            imgBuilder.MergeAttribute("class", iconClass);
            imgBuilder.InnerHtml = iconText;
            string imgHtml = imgBuilder.ToString(TagRenderMode.Normal);

            // build the <a> tag
            var anchorBuilder = new TagBuilder("a");
            anchorBuilder.MergeAttribute("href", action != null ? url.Action(action, controller, parameters) : "javascript:void(0)");
            anchorBuilder.InnerHtml = imgHtml; // include the <i> tag inside
            anchorBuilder.MergeAttributes(new RouteValueDictionary(htmlAttributesForAnchor));

            string anchorHtml = anchorBuilder.ToString(TagRenderMode.Normal);
            return MvcHtmlString.Create(anchorHtml);
        }

    }
}