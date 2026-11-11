namespace WorkManagement.Shared;

/// <summary>
/// Keys for hosting static SPA from wwwroot.
/// Override with environment variable <c>Hosting__ServeSpa</c> (true/false).
/// </summary>
public static class HostingOptions
{
    public const string SectionName = "Hosting";

    /// <summary>
    /// When true (default), enables static file server (<c>UseFileServer</c>)
    /// and SPA fallback to index.html.
    /// When false, API-only pipeline (no wwwroot / no MapFallbackToFile).
    /// </summary>
    public const string ServeSpa = nameof(ServeSpa);
}
