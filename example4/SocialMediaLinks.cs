namespace example4;

public class SocialMediaLinks
{
    public string? Twitter { get; private set; }
    public string? Instagram { get; private set; }
    public string? Facebook { get; private set; }
    public string? OfficialWebsite { get; private set; }

    public SocialMediaLinks(string? twitter, string? instagram, string? facebook, string? officialWebsite)
    {
        if (twitter != null)
            ValidateSocialMediaLink(SocialMediaType.Twitter, twitter);
        if (instagram != null)
            ValidateSocialMediaLink(SocialMediaType.Instagram, instagram);
        if (facebook != null)
            ValidateSocialMediaLink(SocialMediaType.Facebook, facebook);
        if (officialWebsite != null)
            ValidateSocialMediaLink(SocialMediaType.OfficialWebsite, officialWebsite);

        Twitter = twitter;
        Instagram = instagram;
        Facebook = facebook;
        OfficialWebsite = officialWebsite;
    }

    public SocialMediaLinks UpdateLink(SocialMediaType type, string newLink)
    {
        ValidateSocialMediaLink(type, newLink);

        var updated = Clone();

        switch (type)
        {
            case SocialMediaType.Twitter:
                updated.Twitter = newLink;
                break;
            case SocialMediaType.Instagram:
                updated.Instagram = newLink;
                break;
            case SocialMediaType.Facebook:
                updated.Facebook = newLink;
                break;
            case SocialMediaType.OfficialWebsite:
                updated.OfficialWebsite = newLink;
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(type), type, $"Unsupported social media type: {type}");
        }

        return updated;
    }

    public SocialMediaLinks RemoveLink(SocialMediaType type)
    {
        var updated = Clone();

        switch (type)
        {
            case SocialMediaType.Twitter:
                updated.Twitter = null;
                break;
            case SocialMediaType.Instagram:
                updated.Instagram = null;
                break;
            case SocialMediaType.Facebook:
                updated.Facebook = null;
                break;
            case SocialMediaType.OfficialWebsite:
                updated.OfficialWebsite = null;
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(type), type, $"Unsupported social media type: {type}");
        }

        return updated;
    }

    private void ValidateSocialMediaLink(SocialMediaType type, string link)
    {
        if (!IsValidSocialMediaLink(link, type))
            throw new InvalidOperationException($"Invalid {type} link.");
    }

    private bool IsValidSocialMediaLink(string link, SocialMediaType type)
    {
        if (String.IsNullOrWhiteSpace(link))
            return false;

        if (!Uri.TryCreate(link, UriKind.Absolute, out Uri? uri))
            return false;

        // If an expected domain is provided, check if the link belongs to that domain.
        var expectedDomain = GetExpectedDomain(type);

        if (expectedDomain != null && !uri.Host.EndsWith(expectedDomain, StringComparison.OrdinalIgnoreCase))
            return false;

        return true;
    }

    private string? GetExpectedDomain(SocialMediaType type)
    {
        return type switch
        {
            SocialMediaType.Twitter => "twitter.com",
            SocialMediaType.Instagram => "instagram.com",
            SocialMediaType.Facebook => "facebook.com",
            SocialMediaType.OfficialWebsite => null, // No specific domain for the official website
            _ => throw new ArgumentOutOfRangeException(nameof(type), $"Unsupported social media tye: {type}")
        };
    }

    private SocialMediaLinks Clone() => new SocialMediaLinks(Twitter, Instagram, Facebook, OfficialWebsite);
}