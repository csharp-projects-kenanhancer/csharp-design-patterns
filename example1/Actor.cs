namespace example1;

public class Actor
{
    public Guid Id { get; set; }
    
    // Personal Details
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string Biography { get; private set; }
    
    // Social Media Links
    public string? Twitter { get; private set; }
    public string? Instagram { get; private set; }
    public string? Facebook { get; private set; }
    public string? OfficialWebsite { get; private set; }

    public Actor(string firstName, string lastName, string biography, string? twitter, string? instagram, string? facebook, string? officialWebsite)
    {
        Id = Guid.NewGuid();
        FirstName = firstName;
        LastName = lastName;
        Biography = biography;
        Twitter = twitter;
        Instagram = instagram;
        Facebook = facebook;
        OfficialWebsite = officialWebsite;
    }

    public void UpdateTwitterLink(string newLink)
    {
        if (!IsValidSocialMediaLink(newLink, "twitter.com"))
            throw new InvalidOperationException("Invalid Twitter link.");

        Twitter = newLink;
    }

    public void UpdateInstagramLink(string newLink)
    {
        if (!IsValidSocialMediaLink(newLink, "instagram.com"))
            throw new InvalidOperationException("Invalid Instagram link.");

        Instagram = newLink;
    }

    public void UpdateFacebookLink(string newLink)
    {
        if (!IsValidSocialMediaLink(newLink, "facebook.com"))
            throw new InvalidOperationException("Invalid Facebook link.");

        Facebook = newLink;
    }

    public void UpdateOfficialWebsite(string newLink)
    {
        if (!IsValidSocialMediaLink(newLink))
            throw new InvalidOperationException("Invalid official website link.");

        OfficialWebsite = newLink;
    }

    public void RemoveTwitterLink()
    {
        Twitter = null;
    }

    public void RemoveInstagramLink()
    {
        Instagram = null;
    }

    public void RemoveFacebookLink()
    {
        Facebook = null;
    }

    public void RemoveOfficialWebsite()
    {
        OfficialWebsite = null;
    }

    private bool IsValidSocialMediaLink(string link, string? expectedDomain = null)
    {
        if (String.IsNullOrWhiteSpace(link))
            return false;

        if (!Uri.TryCreate(link, UriKind.Absolute, out Uri? uri))
            return false;

        // If an expected domain is provided, check if the link belongs to that domain.
        if (expectedDomain != null && !uri.Host.EndsWith(expectedDomain, StringComparison.OrdinalIgnoreCase))
            return false;
        
        return true;
    }
}