using System.Text.RegularExpressions;

namespace Example6;

public class FacebookLink : BaseSocialMediaLink
{
    private const string FacebookDomain = "facebook.com";

    public FacebookLink(string name, string link) : base(SocialMediaType.Facebook, name, link)
    {
    }

    public override string GetProfilePictureUrl()
    {
        // Extract the username or ID from the Link
        var userId = Link.Split("/").Last();

        // Construct the mock profile picture URL
        return $"https://{FacebookDomain}/{userId}/profile_pic_mock.jpg";
    }

    protected override bool IsValidLink(string link, out ValidationResult result)
    {
        base.IsValidLink(link, out result);

        if (!link.Contains(FacebookDomain))
            result.AddError($"{nameof(link)} must contain '{FacebookDomain}'.");

        // Extracting potential username or profile id after "facebook.com"
        string username = ExtractUsernameFromLink(link);

        // If the profile part is not alphanumeric, return false
        if (!IsValidFacebookUsername(username))
            result.AddError($"{nameof(link)}'s profile section after '{FacebookDomain}' should be alphanumeric.");

        return result.IsValid;
    }

    private string ExtractUsernameFromLink(string link)
    {
        // Extracting potential username or profile id after "facebook.com"
        return link.Substring(link.IndexOf(FacebookDomain, StringComparison.Ordinal) + FacebookDomain.Length + 1);
    }

    private bool IsValidFacebookUsername(string username)
    {
        // Facebook usernames are alphanumeric and can contain periods and underscores
        return Regex.IsMatch(username, @"^[a-zA-Z0-9._-]+$");
    }
}