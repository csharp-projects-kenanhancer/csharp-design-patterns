using System.Text.RegularExpressions;

namespace Example6;

public class TwitterLink : BaseSocialMediaLink
{
    private const string TwitterDomain = "twitter.com";

    public TwitterLink(string name, string link) : base(SocialMediaType.Twitter, name, link)
    {
    }

    public override string GetProfilePictureUrl()
    {
        // Extract the screen name from the Link
        var screenName = Link.Split("/").Last();

        // Construct the profile picture URL
        return $"https://{TwitterDomain}/{screenName}/profile_image?size=original";
    }

    protected override bool IsValidLink(string link, out ValidationResult result)
    {
        base.IsValidLink(link, out result);

        if (!link.Contains(TwitterDomain))
            result.AddError($"{nameof(link)} must contain '{TwitterDomain}'.");

        string userName = ExtractUsernameFromLink(link);

        // If the profile part is not alphanumeric, return false
        if (!IsValidTwitterUsername(userName))
            result.AddError($"{nameof(link)}'s profile section after '{TwitterDomain}' should be alphanumeric.");

        return result.IsValid;
    }

    private string ExtractUsernameFromLink(string link)
    {
        // Extracting potential username or profile id after "twitter.com"
        return link.Substring(link.IndexOf(TwitterDomain, StringComparison.Ordinal) + TwitterDomain.Length + 1);
    }

    private bool IsValidTwitterUsername(string username)
    {
        return Regex.IsMatch(username, @"^[a-zA-Z0-9._-]+$");
    }
}