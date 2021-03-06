﻿using System.Web;
using System.Web.Mvc;
using SquishIt.Framework.CSS;
using SquishIt.Framework.JavaScript;

namespace SquishIt.Mvc
{
	public static class MvcExtensions
	{
		public static MvcHtmlString RenderMvc(this CSSBundle cssBundleBuilder, string renderTo)
		{
			return MvcHtmlString.Create(cssBundleBuilder.Render(renderTo));
		}

		public static MvcHtmlString MvcRender(this JavaScriptBundle javaScriptBundleBuilder, string renderTo)
		{
			return MvcHtmlString.Create(javaScriptBundleBuilder.Render(renderTo));
		}

		public static MvcHtmlString MvcRenderNamed(this JavaScriptBundle javaScriptBundle, string name)
		{
			return MvcHtmlString.Create(javaScriptBundle.RenderNamed(name));
		}

		public static MvcHtmlString MvcRenderNamed(this CSSBundle cssBundle, string name)
		{
			return MvcHtmlString.Create(cssBundle.RenderNamed(name));
		}

		public static MvcHtmlString MvcRenderCachedAssetTag(this JavaScriptBundle javaScriptBundle, string name)
		{
			return MvcHtmlString.Create(javaScriptBundle.RenderCachedAssetTag(name));
		}

		public static MvcHtmlString MvcRenderCachedAssetTag(this CSSBundle cssBundle, string name)
		{
			return MvcHtmlString.Create(cssBundle.RenderCachedAssetTag(name));
		}
	}
}