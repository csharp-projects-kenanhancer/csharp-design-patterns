namespace Example7;

public class OfficialWebsite : BaseSocialMediaLink
{
    private OfficialWebsite(string name, string link) : base(SocialMediaType.OfficialWebsite, name, link)
    {
    }

    public static OfficialWebsite Create(string name, string link) => new(name, link);

    public override string GetProfilePictureUrl() => $"{Link}/assets/profile-pic.jpg";
}