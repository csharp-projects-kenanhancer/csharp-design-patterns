namespace Example6;

public abstract class BaseSocialMediaLink : ISocialMediaLink
{
    public SocialMediaType SocialMediaType { get; }
    public string Name { get; }
    public string Link { get; }
    public bool Active { get; private set; }

    protected BaseSocialMediaLink(SocialMediaType socialMediaType, string name, string link, bool active = true)
    {
        SocialMediaType = socialMediaType;

        if (!Validate(name, link, out ValidationResult result))
            throw new InvalidOperationException(result.ErrorMessage);

        Name = name;
        Link = link;
        Active = active;
    }

    public virtual string GetProfilePictureUrl() => $"{Link}/profile-pic";

    public virtual void SetActive(bool active) => Active = active;

    protected virtual bool IsValidName(string name, out ValidationResult result)
    {
        result = new ValidationResult();

        return result.IsValid;
    }

    protected virtual bool IsValidLink(string link, out ValidationResult result)
    {
        result = new ValidationResult();

        return result.IsValid;
    }

    private bool Validate(string name, string link, out ValidationResult result)
    {
        result = new ValidationResult();

        if (!ValidateName(name, out ValidationResult nameResult))
            result.Merge(nameResult);
        if (!ValidateLink(link, out ValidationResult linkResult))
            result.Merge(linkResult);

        return result.IsValid;
    }

    private bool ValidateName(string name, out ValidationResult result)
    {
        result = new ValidationResult();

        if (String.IsNullOrWhiteSpace(name))
            result.AddError($"${name} cannot be empty.");

        if (name.Length < 3)
            result.AddError($"{nameof(name)} must be at least 3 characters long.");

        if (name.Length > 50)
            result.AddError($"{nameof(name)} must not exceed 20 characters.");

        if (name.StartsWith(" ") || name.EndsWith(" "))
            result.AddError($"{nameof(name)} cannot start or end with a space.");

        if (name.Contains("  ")) // Checking for consecutive spaces
            result.AddError($"{nameof(name)} cannot contain consecutive spaces.");

        if (!IsValidName(name, out ValidationResult result2))
            result.Merge(result2);

        return result.IsValid;
    }

    private bool ValidateLink(string link, out ValidationResult result)
    {
        result = new ValidationResult();

        if (string.IsNullOrWhiteSpace(link))
            result.AddError($"{nameof(link)} cannot be empty.");

        if (!link.StartsWith("https://"))
            result.AddError($"{nameof(link)} must start with 'https://'.");

        if (link.Contains(" "))
            result.AddError($"{nameof(link)} cannot contain spaces.");

        if (!IsValidLink(link, out ValidationResult result2))
            result.Merge(result2);

        return result.IsValid;
    }
}