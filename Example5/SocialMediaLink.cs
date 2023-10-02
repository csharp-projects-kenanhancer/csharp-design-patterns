namespace Example5;

public class SocialMediaLink
{
    public SocialMediaType Type { get; }
    public string Link { get; private set; }

    public SocialMediaLink(SocialMediaType type, string link)
    {
        Type = type;
        UpdateLink(link);
    }

    public void UpdateLink(string link)
    {
        Link = IsValidSocialMediaLink(Type, link)
            ? link
            : throw new ArgumentException($"Invalid {Type} link.", nameof(link));
    }

    private bool IsValidSocialMediaLink(SocialMediaType type, string link)
    {
        if (String.IsNullOrWhiteSpace(link))
            return false;

        if (!Uri.TryCreate(link, UriKind.Absolute, out Uri? uri))
            return false;

        string expectedDomain = GetExpectedDomain(type);

        // If an expected domain is provided, check if the link belongs to that domain.
        if (!String.IsNullOrWhiteSpace(expectedDomain) &&
            !uri.Host.EndsWith(expectedDomain, StringComparison.OrdinalIgnoreCase))
            return false;

        return true;
    }

    private string GetExpectedDomain(SocialMediaType type)
    {
        return type switch
        {
            SocialMediaType.Twitter => "twitter.com",
            SocialMediaType.Instagram => "instagram.com",
            SocialMediaType.Facebook => "facebook.com",
            SocialMediaType.OfficialWebsite => "",
            _ => throw new ArgumentOutOfRangeException(nameof(type), type, $"Unsupported social media type: {type}")
        };
    }
}