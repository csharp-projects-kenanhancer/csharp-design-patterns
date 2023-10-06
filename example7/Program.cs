using Example7;

var socialMediaLinks = new SocialMediaLinks();
socialMediaLinks.AddLink(TwitterLink.Create("John's Twitter", "https://twitter.com/johndoe"));
socialMediaLinks.AddLink(InstagramLink.Create("John's Instagram", "https://instagram.com/johndoe"));
socialMediaLinks.AddLink(FacebookLink.Create("John's Facebook", "https://facebook.com/johndoe"));
socialMediaLinks.AddLink(OfficialWebsite.Create("John's Official Website", "https://www.johndoe.com"));

var actor = new Actor("John", "Doe", "John Doe is an acclaimed actor...", socialMediaLinks);

// Get a specific social media link
Console.WriteLine($"Original Twitter: {actor.SocialMediaLinks.GetLink("John's Twitter").Link}");
Console.WriteLine($"Original Instagram: {actor.SocialMediaLinks.GetLink("John's Instagram").Link}");
Console.WriteLine($"Original Facebook: {actor.SocialMediaLinks.GetLink("John's Facebook").Link}");
Console.WriteLine($"Original OfficialWebsite: {actor.SocialMediaLinks.GetLink("John's Official Website").Link}");

// Update social media links for the actor
actor.SocialMediaLinks.UpdateLink(TwitterLink.Create("John's Twitter", "https://twitter.com/new-johndoe"));
actor.SocialMediaLinks.UpdateLink(InstagramLink.Create("John's Instagram", "https://instagram.com/new-johndoe"));
actor.SocialMediaLinks.UpdateLink(FacebookLink.Create("John's Facebook", "https://facebook.com/new-johndoe"));
actor.SocialMediaLinks.UpdateLink(OfficialWebsite.Create("John's Official Website", "https://www.new-johndoe.com"));

// Get a specific social media link
Console.WriteLine($"Updated Twitter: {actor.SocialMediaLinks.GetLink("John's Twitter").Link}");
Console.WriteLine($"Updated Instagram: {actor.SocialMediaLinks.GetLink("John's Instagram").Link}");
Console.WriteLine($"Updated Facebook: {actor.SocialMediaLinks.GetLink("John's Facebook").Link}");
Console.WriteLine($"Updated OfficialWebsite: {actor.SocialMediaLinks.GetLink("John's Official Website").Link}");

// Remove a specific social media link
actor.SocialMediaLinks.RemoveLink("John's Twitter");
actor.SocialMediaLinks.RemoveLink("John's Instagram");
actor.SocialMediaLinks.RemoveLink("John's Facebook");
actor.SocialMediaLinks.RemoveLink("John's Official Website");