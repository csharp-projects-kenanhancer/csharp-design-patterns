using Example5;

var socialMediaLinks = new SocialMediaLinks();
socialMediaLinks.AddLink(SocialMediaType.Twitter, "https://twitter.com/johndoe");
socialMediaLinks.AddLink(SocialMediaType.Instagram, "https://instagram.com/johndoe");
socialMediaLinks.AddLink(SocialMediaType.Facebook, "https://facebook.com/johndoe");
socialMediaLinks.AddLink(SocialMediaType.OfficialWebsite, "https://www.johndoe.com");

var actor = new Actor("John", "Doe", "John Doe is an acclaimed actor...", socialMediaLinks);

// Get a specific social media link
Console.WriteLine($"Original Twitter: {actor.SocialMediaLinks.GetLink(SocialMediaType.Twitter)}");
Console.WriteLine($"Original Instagram: {actor.SocialMediaLinks.GetLink(SocialMediaType.Instagram)}");
Console.WriteLine($"Original Facebook: {actor.SocialMediaLinks.GetLink(SocialMediaType.Facebook)}");
Console.WriteLine($"Original OfficialWebsite: {actor.SocialMediaLinks.GetLink(SocialMediaType.OfficialWebsite)}");

// V1
// actor.SocialMediaLinks.UpdateTwitterLink("https://twitter.com/new-johndoe");
// actor.SocialMediaLinks.UpdateInstagramLink("https://instagram.com/new-johndoe");
// actor.SocialMediaLinks.UpdateFacebookLink("https://facebook.com/new-johndoe");
// actor.SocialMediaLinks.UpdateOfficialWebsite("https://www.new-johndoe.com");

// V2
// actor.SocialMediaLinks.UpdateLink(SocialMediaType.Twitter, "https://twitter.com/new-johndoe");
// actor.SocialMediaLinks.UpdateLink(SocialMediaType.Instagram, "https://instagram.com/new-johndoe");
// actor.SocialMediaLinks.UpdateLink(SocialMediaType.Facebook, "https://facebook.com/new-johndoe");
// actor.SocialMediaLinks.UpdateLink(SocialMediaType.OfficialWebsite, "https://www.new-johndoe.com");

// V3 - Immutable
// actor.SetSocialMediaLinks(actor.SocialMediaLinks.UpdateLink(SocialMediaType.Twitter, "https://twitter.com/new-johndoe"));
// actor.SetSocialMediaLinks(actor.SocialMediaLinks.UpdateLink(SocialMediaType.Instagram, "https://instagram.com/new-johndoe"));
// actor.SetSocialMediaLinks(actor.SocialMediaLinks.UpdateLink(SocialMediaType.Facebook, "https://facebook.com/new-johndoe"));
// actor.SetSocialMediaLinks(actor.SocialMediaLinks.UpdateLink(SocialMediaType.OfficialWebsite, "https://www.new-johndoe.com"));

// V4
actor.SocialMediaLinks.UpdateLink(SocialMediaType.Twitter, "https://twitter.com/new-johndoe");
actor.SocialMediaLinks.UpdateLink(SocialMediaType.Instagram, "https://instagram.com/new-johndoe");
actor.SocialMediaLinks.UpdateLink(SocialMediaType.Facebook, "https://facebook.com/new-johndoe");
actor.SocialMediaLinks.UpdateLink(SocialMediaType.OfficialWebsite, "https://www.new-johndoe.com");

// Get a specific social media link
Console.WriteLine($"Updated Twitter: {actor.SocialMediaLinks.GetLink(SocialMediaType.Twitter)}");
Console.WriteLine($"Updated Instagram: {actor.SocialMediaLinks.GetLink(SocialMediaType.Instagram)}");
Console.WriteLine($"Updated Facebook: {actor.SocialMediaLinks.GetLink(SocialMediaType.Facebook)}");
Console.WriteLine($"Updated OfficialWebsite: {actor.SocialMediaLinks.GetLink(SocialMediaType.OfficialWebsite)}");

// Remove a specific social media link
// V1
// actor.SocialMediaLinks.RemoveTwitterLink();
// actor.SocialMediaLinks.RemoveInstagramLink();
// actor.SocialMediaLinks.RemoveFacebookLink();
// actor.SocialMediaLinks.RemoveOfficialWebsite();

// V2
// actor.SocialMediaLinks.RemoveLink(SocialMediaType.Twitter);
// actor.SocialMediaLinks.RemoveLink(SocialMediaType.Instagram);
// actor.SocialMediaLinks.RemoveLink(SocialMediaType.Facebook);
// actor.SocialMediaLinks.RemoveLink(SocialMediaType.OfficialWebsite);

// V3 - Immutable
// actor.SetSocialMediaLinks(actor.SocialMediaLinks.RemoveLink(SocialMediaType.Twitter));
// actor.SetSocialMediaLinks(actor.SocialMediaLinks.RemoveLink(SocialMediaType.Instagram));
// actor.SetSocialMediaLinks(actor.SocialMediaLinks.RemoveLink(SocialMediaType.Facebook));
// actor.SetSocialMediaLinks(actor.SocialMediaLinks.RemoveLink(SocialMediaType.OfficialWebsite));

// V4
actor.SocialMediaLinks.RemoveLink(SocialMediaType.Twitter);
actor.SocialMediaLinks.RemoveLink(SocialMediaType.Instagram);
actor.SocialMediaLinks.RemoveLink(SocialMediaType.Facebook);
actor.SocialMediaLinks.RemoveLink(SocialMediaType.OfficialWebsite);