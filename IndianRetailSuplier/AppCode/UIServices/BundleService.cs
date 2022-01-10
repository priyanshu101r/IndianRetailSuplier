using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndianRetailSuplier.Common.ExtensionMethods;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Html;

namespace IndianRetailSuplier.AppCode.UIServices
{
    public class BundleService
    {
        //private readonly IWebHostEnvironment _webHostEnvironment;
        //public BundleService(IWebHostEnvironment webHostEnvironment)
        //{
        //    _webHostEnvironment = webHostEnvironment;
        //}
        //private string BundleJsonAbsolutePath => _webHostEnvironment.WebRootPath;    //("~/bundleconfig.json");

        //public static HtmlString CacheBustScript(string relativeUrl)
        //{
        //    Func<string, string> generateTag = cacheBustedUrl => $" <script src=\"{cacheBustedUrl}\"></script>";

        //    return CreateResourceTags(relativeUrl, "js", generateTag);
        //}

        //public static HtmlString CacheBustStyle(string relativeUrl, string media = "")
        //{
        //    string mediaAttribute = media.HasValue() ? $"media={media} " : string.Empty;

        //    Func<string, string> generateTag = cacheBustedUrl => $"<link href=\"{cacheBustedUrl}\" rel=\"stylesheet\" {mediaAttribute}/>";

        //    return CreateResourceTags(relativeUrl, "css", generateTag);
        //}

        //private static HtmlString CreateResourceTags(string relativeUrl, string extension, Func<string, string> generateTag)
        //{
        //    var bundleFiles = GetBundleFiles(relativeUrl);
        //    string generatedHtmlResourceTag;

        //    if (bundleFiles.HasItems() && AppSettings.IsLocalDevelopment)
        //    {
        //        StringBuilder stringBuilder = new StringBuilder();

        //        foreach (var file in bundleFiles)
        //        {
        //            string cacheBustedUrl = CacheBustResource($"~/{file}");
        //            stringBuilder.AppendLine(generateTag(cacheBustedUrl));
        //        }

        //        generatedHtmlResourceTag = stringBuilder.ToString();
        //    }
        //    else
        //    {
        //        string appropriateUrl = $"~{GetAppropriateResourceUrl(relativeUrl, extension)}";
        //        string cacheBustedUrl = CacheBustResource(appropriateUrl);
        //        generatedHtmlResourceTag = generateTag(cacheBustedUrl);
        //    }

        //    return new HtmlString(generatedHtmlResourceTag);
        //}

        //private static IEnumerable<BundleConfig> BundleConfigs()
        //{
        //    string bundleConfigJson = IO.ReadFileShared(BundleJsonAbsolutePath);

        //    var bundleConfigs = bundleConfigJson.ToCSharpObject<IEnumerable<BundleConfig>>();

        //    return bundleConfigs;
        //}

        //private static string[] GetBundleFiles(string relativeUrl)
        //{
        //    return
        //         BundleConfigs()
        //            .Where(bc => bc.OutputFileName.CaseInsensitiveCompare(relativeUrl.ReplaceLast(".min", string.Empty).ReplaceFirst("~/", string.Empty)))
        //            .SelectMany(bc => bc.InputFiles)
        //            .ToArray();
        //}

        //private static string GetAppropriateResourceUrl(string url, string fileExtension)
        //{
        //    string fileName = IO.GetFileNameFromRelativePath(url, false);
        //    string originalFileName = $"{fileName}.{fileExtension}".ToLower();

        //    if (!AppSettings.IsLocalDevelopment)
        //    {
        //        fileName = $"{fileName}.min.{fileExtension}";
        //    }
        //    else
        //    {
        //        fileName = originalFileName;
        //    }

        //    url = url.ToLower().Replace(originalFileName, fileName).Replace("~", string.Empty);

        //    return url;
        //}

        //private static string CacheBustResource(string relativeUrl)
        //{
        //    if (HttpRuntime.Cache[relativeUrl] == null)
        //    {
        //        string absoluteUrl = HostingEnvironment.MapPath(relativeUrl);

        //        DateTime date = File.GetLastWriteTime(absoluteUrl);

        //        string cacheBustedUrl = $"{relativeUrl.ReplaceFirst("~", string.Empty)}?v={date.Ticks}";

        //        HttpRuntime.Cache.Insert(relativeUrl, cacheBustedUrl, new CacheDependency(absoluteUrl));
        //    }

        //    return HttpRuntime.Cache[relativeUrl] as string;
        //}
    }
}
