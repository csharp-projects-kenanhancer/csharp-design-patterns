namespace Example5;

public class SocialMediaLinks
{
    private readonly List<SocialMediaLink> _links = new List<SocialMediaLink>();

    public IReadOnlyCollection<SocialMediaLink> Links => _links.AsReadOnly();

    public void AddLink(SocialMediaType type, string link)
    {
        if (_links.Any(l => l.Type == type))
            throw new InvalidOperationException($"Link of type {type} already exists. Use UpdateLink to modify.");

        _links.Add(new SocialMediaLink(type, link));
    }

    public void UpdateLink(SocialMediaType type, string link)
    {
        var existingLink = _links.FirstOrDefault(l => l.Type == type);
        if (existingLink == null)
            throw new InvalidOperationException($"Link of type {type} does not exist. Use AddLink to add a new link.");

        existingLink.UpdateLink(link);
    }

    public void RemoveLink(SocialMediaType type)
    {
        var link = _links.FirstOrDefault(l => l.Type == type);
        if (link == null)
            throw new InvalidOperationException($"Link of type {type} does not exist.");

        _links.Remove(link);
    }

    public string? GetLink(SocialMediaType type)
    {
        var link = _links.FirstOrDefault(l => l.Type == type);
        return link?.Link;
    }
}