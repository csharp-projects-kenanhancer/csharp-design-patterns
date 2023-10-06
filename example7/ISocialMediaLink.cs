namespace Example7;

public interface ISocialMediaLink
{
    SocialMediaType SocialMediaType { get; }
    string Name { get; }
    string Link { get; }
    bool Active { get; }
    string GetProfilePictureUrl();
    void SetActive(bool active);
}