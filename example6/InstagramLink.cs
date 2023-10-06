using System.Text.RegularExpressions;

namespace Example6;

public class InstagramLink : BaseSocialMediaLink
{
    private const string InstagramDomain = "instagram.com";

    public InstagramLink(string name, string link) : base(SocialMediaType.Instagram, name, link)
    {
    }

    public override string GetProfilePictureUrl()
    {
        // Extract the username from the Link
        var username = Link.Split("/").Last();

        // Construct the mock profile picture URL
        return $"https://{InstagramDomain}/{username}/profile_pic_mock.jpg";
    }

    protected override bool IsValidLink(string link, out ValidationResult result)
    {
        base.IsValidLink(link, out result);

        if (!link.Contains(InstagramDomain))
            result.AddError($"{nameof(link)} must contain '{InstagramDomain}'.");

        string userName = ExtractUsernameFromLink(link);

        // If the profile part is not alphanumeric, return false
        if (!IsValidInstagramUsername(userName))
            result.AddError($"{nameof(link)}'s profile section after '{InstagramDomain}' should be alphanumeric.");

        return result.IsValid;
    }

    private string ExtractUsernameFromLink(string link)
    {
        // Extracting potential username or profile id after "instagram.com" 
        return link.Substring(link.IndexOf(InstagramDomain, StringComparison.Ordinal) + InstagramDomain.Length + 1);
    }

    private bool IsValidInstagramUsername(string username)
    {
        // Instagram usernames are alphanumeric and can contain periods and underscores
        return Regex.IsMatch(username, @"^[a-zA-Z0-9._-]+$");
    }
}