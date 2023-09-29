namespace example2;

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
        FirstName = firstName;
        LastName = lastName;
        Biography = biography;
        SocialMediaLinks = socialMediaLinks;
    }
}