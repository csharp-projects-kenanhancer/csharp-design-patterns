namespace Example6;

public class OfficialWebsite : BaseSocialMediaLink
{
    public OfficialWebsite(string name, string link) : base(SocialMediaType.OfficialWebsite, name, link)
    {
    }

    public override string GetProfilePictureUrl() => $"{Link}/assets/profile-pic.jpg";
}