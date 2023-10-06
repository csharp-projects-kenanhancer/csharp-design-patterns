using example3;

var socialMediaLinks = new SocialMediaLinks("https://twitter.com/johndoe",
    "https://instagram.com/johndoe",
    "https://facebook.com/johndoe", "https://www.johndoe.com");

var actor = new Actor("John", "Doe", "John Doe is an acclaimed actor...", socialMediaLinks);

// Get a specific social media link
Console.WriteLine($"Original Twitter: {actor.SocialMediaLinks.Twitter}");
Console.WriteLine($"Original Instagram: {actor.SocialMediaLinks.Instagram}");
Console.WriteLine($"Original Facebook: {actor.SocialMediaLinks.Facebook}");
Console.WriteLine($"Original OfficialWebsite: {actor.SocialMediaLinks.OfficialWebsite}");

// Update social media links for the actor
// V1
// actor.UpdateTwitterLink("https://twitter.com/new-johndoe");
// actor.UpdateInstagramLink("https://instagram.com/new-johndoe");
// actor.UpdateFacebookLink("https://facebook.com/new-johndoe");
// actor.UpdateOfficialWebsite("https://www.new-johndoe.com");

// V2
// actor.SocialMediaLinks.UpdateTwitterLink("https://twitter.com/new-johndoe");
// actor.SocialMediaLinks.UpdateInstagramLink("https://instagram.com/new-johndoe");
// actor.SocialMediaLinks.UpdateFacebookLink("https://facebook.com/new-johndoe");
// actor.SocialMediaLinks.UpdateOfficialWebsite("https://www.new-johndoe.com");

// V3
actor.SocialMediaLinks.UpdateLink(SocialMediaType.Twitter, "https://twitter.com/new-johndoe");
actor.SocialMediaLinks.UpdateLink(SocialMediaType.Instagram, "https://instagram.com/new-johndoe");
actor.SocialMediaLinks.UpdateLink(SocialMediaType.Facebook, "https://facebook.com/new-johndoe");
actor.SocialMediaLinks.UpdateLink(SocialMediaType.OfficialWebsite, "https://www.new-johndoe.com");

// Get a specific social media link
Console.WriteLine($"Updated Twitter: {actor.SocialMediaLinks.Twitter}");
Console.WriteLine($"Updated Instagram: {actor.SocialMediaLinks.Instagram}");
Console.WriteLine($"Updated Facebook: {actor.SocialMediaLinks.Facebook}");
Console.WriteLine($"Updated OfficialWebsite: {actor.SocialMediaLinks.OfficialWebsite}");

// Remove a specific social media link
// V1
// actor.RemoveTwitterLink();
// actor.RemoveInstagramLink();
// actor.RemoveFacebookLink();
// actor.RemoveOfficialWebsite();

// V2
// actor.SocialMediaLinks.RemoveTwitterLink();
// actor.SocialMediaLinks.RemoveInstagramLink();
// actor.SocialMediaLinks.RemoveFacebookLink();
// actor.SocialMediaLinks.RemoveOfficialWebsite();

// V3
actor.SocialMediaLinks.RemoveLink(SocialMediaType.Twitter);
actor.SocialMediaLinks.RemoveLink(SocialMediaType.Instagram);
actor.SocialMediaLinks.RemoveLink(SocialMediaType.Facebook);
actor.SocialMediaLinks.RemoveLink(SocialMediaType.OfficialWebsite);