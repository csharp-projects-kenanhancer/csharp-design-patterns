namespace example3;

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
        FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
        LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
        Biography = biography ?? throw new ArgumentNullException(nameof(biography));
        SocialMediaLinks = socialMediaLinks ?? throw new ArgumentNullException(nameof(socialMediaLinks));
    }
}