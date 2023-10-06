namespace Example7;

public class SocialMediaLinks
{
    private readonly List<ISocialMediaLink> _links = new List<ISocialMediaLink>();

    public void AddLink(ISocialMediaLink link)
    {
        if (link == null)
            throw new ArgumentNullException(nameof(link));

        if (_links.Any(l => l.Link.Equals(link.Link, StringComparison.OrdinalIgnoreCase)))
            throw new ArgumentException($"Link already exists: {link.Link}");

        _links.Add(link);
    }

    public void UpdateLink(ISocialMediaLink newLink)
    {
        if (newLink == null)
            throw new ArgumentNullException(nameof(newLink));

        if (String.IsNullOrWhiteSpace(newLink.Name))
            throw new ArgumentNullException(nameof(newLink.Name));

        var existingLink = _links.FirstOrDefault(l => l.Name.Equals(newLink.Name, StringComparison.OrdinalIgnoreCase));
        if (existingLink == null)
            throw new ArgumentException($"Link not found: {newLink.Name}");

        _links.Remove(existingLink);
        _links.Add(newLink);
    }

    public void RemoveLink(string name)
    {
        if (String.IsNullOrWhiteSpace(name))
            throw new ArgumentNullException(nameof(name));

        var link = _links.FirstOrDefault(l => l.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        if (link == null)
            throw new ArgumentException($"Link not found: {name}");

        _links.Remove(link);
    }

    public ISocialMediaLink GetLink(string name)
    {
        if (String.IsNullOrWhiteSpace(name))
            throw new ArgumentNullException(nameof(name));

        var link = _links.FirstOrDefault(l => l.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

        if (link == null)
            throw new ArgumentException($"Link not found: {name}");

        return link;
    }
}