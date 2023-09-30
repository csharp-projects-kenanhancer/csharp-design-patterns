namespace example4;

public class Actor
{
    public Guid Id { get; private set; }

    // Personal Details
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string Biography { get; private set; }

    // Social Media Links
    public SocialMediaLinks SocialMediaLinks { get; private set; }

    public Actor(string firstName, string lastName, string biography, SocialMediaLinks socialMediaLinks)
    {
        Id = Guid.NewGuid();
        // FirstName = firstName is not null and not "" ? firstName : throw new ArgumentNullException(nameof(firstName));
        FirstName = !string.IsNullOrWhiteSpace(firstName) ? firstName : throw new ArgumentNullException(nameof(firstName));
        LastName = !string.IsNullOrWhiteSpace(lastName) ? lastName : throw new ArgumentNullException(nameof(lastName));
        Biography = !string.IsNullOrWhiteSpace(biography) ? biography : throw new ArgumentNullException(nameof(biography));
        SetSocialMediaLinks(socialMediaLinks);
    }

    public void SetSocialMediaLinks(SocialMediaLinks newSocialMediaLinks)
    {
        SocialMediaLinks = newSocialMediaLinks ?? throw new ArgumentNullException(nameof(newSocialMediaLinks));
    }
}