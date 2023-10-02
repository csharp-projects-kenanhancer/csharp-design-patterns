namespace example3;

public class SocialMediaLinks
{
    public string? Twitter { get; private set; }
    public string? Instagram { get; private set; }
    public string? Facebook { get; private set; }
    public string? OfficialWebsite { get; private set; }

    public SocialMediaLinks(string? twitter, string? instagram, string? facebook, string? officialWebsite)
    {
        if (twitter != null && !IsValidSocialMediaLink(twitter, SocialMediaType.Twitter))
            throw new ArgumentException("Invalid Twitter link.", nameof(twitter));
        if (instagram != null && !IsValidSocialMediaLink(instagram, SocialMediaType.Instagram))
            throw new ArgumentException("Invalid Instagram link.", nameof(instagram));
        if (facebook != null && !IsValidSocialMediaLink(facebook, SocialMediaType.Facebook))
            throw new ArgumentException("Invalid Facebook link.", nameof(facebook));
        if (officialWebsite != null && !IsValidSocialMediaLink(officialWebsite, SocialMediaType.OfficialWebsite))
            throw new ArgumentException("Invalid OfficialWebsite link.", nameof(officialWebsite));

        Twitter = twitter;
        Instagram = instagram;
        Facebook = facebook;
        OfficialWebsite = officialWebsite;
    }

    public void UpdateLink(SocialMediaType type, string newLink)
    {
        if (!IsValidSocialMediaLink(newLink, type))
            throw new InvalidOperationException($"Invalid {type} link.");

        switch (type)
        {
            case SocialMediaType.Twitter:
                break;
            case SocialMediaType.Instagram:
                break;
            case SocialMediaType.Facebook:
                break;
            case SocialMediaType.OfficialWebsite:
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(type), type, $"Unsupported social media type: {type}");
        }
    }

    public void RemoveLink(SocialMediaType type)
    {
        switch (type)
        {
            case SocialMediaType.Twitter:
                Twitter = null;
                break;
            case SocialMediaType.Instagram:
                Instagram = null;
                break;
            case SocialMediaType.Facebook:
                Facebook = null;
                break;
            case SocialMediaType.OfficialWebsite:
                OfficialWebsite = null;
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(type), type, $"Unsupported social media type: {type}");
        }
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
}