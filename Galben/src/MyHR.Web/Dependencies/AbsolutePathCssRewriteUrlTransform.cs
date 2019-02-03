using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyHR.Web.Dependencies
{
    public class AbsolutePathCssRewriteUrlTransform : System.Web.Optimization.IItemTransform
    {
        internal static string RebaseUrlToAbsolute(string baseUrl, string url)
        {
            if (string.IsNullOrWhiteSpace(url) || string.IsNullOrWhiteSpace(baseUrl) || url.StartsWith("/", StringComparison.OrdinalIgnoreCase))
                return url;
            if (!baseUrl.EndsWith("/", StringComparison.OrdinalIgnoreCase))
                baseUrl = baseUrl + "/";
            return VirtualPathUtility.ToAbsolute(baseUrl + url);
        }

        internal static string ConvertUrlsToAbsolute(string baseUrl, string content)
        {
            return string.IsNullOrWhiteSpace(content) ? content :
                new System.Text.RegularExpressions.Regex("url\\(['\"]?(?<url>[^)]+?)['\"]?\\)").Replace(content, match => "url(" + RebaseUrlToAbsolute(baseUrl, match.Groups["url"].Value) + ")");
        }

        public string Process(string includedVirtualPath, string input)
        {
            if (includedVirtualPath == null)
                throw new ArgumentNullException("includedVirtualPath");

            return ConvertUrlsToAbsolute(VirtualPathUtility.GetDirectory(includedVirtualPath), input);
        }
    }
}