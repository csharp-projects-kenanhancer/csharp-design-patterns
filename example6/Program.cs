using Example6;

var socialMediaLinks = new SocialMediaLinks();
socialMediaLinks.AddLink(new TwitterLink("John's Twitter", "https://twitter.com/johndoe"));
socialMediaLinks.AddLink(new InstagramLink("John's Instagram", "https://instagram.com/johndoe"));
socialMediaLinks.AddLink(new FacebookLink("John's Facebook", "https://facebook.com/johndoe"));
socialMediaLinks.AddLink(new OfficialWebsite("John's Official Website", "https://www.johndoe.com"));

var actor = new Actor("John", "Doe", "John Doe is an acclaimed actor...", socialMediaLinks);

// Get a specific social media link
Console.WriteLine($"Original Twitter: {actor.SocialMediaLinks.GetLink("John's Twitter").Link}");
Console.WriteLine($"Original Instagram: {actor.SocialMediaLinks.GetLink("John's Instagram").Link}");
Console.WriteLine($"Original Facebook: {actor.SocialMediaLinks.GetLink("John's Facebook").Link}");
Console.WriteLine($"Original OfficialWebsite: {actor.SocialMediaLinks.GetLink("John's Official Website").Link}");

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
// actor.SocialMediaLinks.UpdateLink(SocialMediaType.Twitter, "https://twitter.com/new-johndoe");
// actor.SocialMediaLinks.UpdateLink(SocialMediaType.Instagram, "https://instagram.com/new-johndoe");
// actor.SocialMediaLinks.UpdateLink(SocialMediaType.Facebook, "https://facebook.com/new-johndoe");
// actor.SocialMediaLinks.UpdateLink(SocialMediaType.OfficialWebsite, "https://www.new-johndoe.com");

// V4 - Immutable
// actor.SetSocialMediaLinks(
//     actor.SocialMediaLinks.UpdateLink(SocialMediaType.Twitter, "https://twitter.com/new-johndoe"));
// actor.SetSocialMediaLinks(
//     actor.SocialMediaLinks.UpdateLink(SocialMediaType.Instagram, "https://instagram.com/new-johndoe"));
// actor.SetSocialMediaLinks(
//     actor.SocialMediaLinks.UpdateLink(SocialMediaType.Facebook, "https://facebook.com/new-johndoe"));
// actor.SetSocialMediaLinks(
//     actor.SocialMediaLinks.UpdateLink(SocialMediaType.OfficialWebsite, "https://www.new-johndoe.com"));

// V5
// actor.SocialMediaLinks.UpdateLink(SocialMediaType.Twitter, "https://twitter.com/new-johndoe");
// actor.SocialMediaLinks.UpdateLink(SocialMediaType.Instagram, "https://instagram.com/new-johndoe");
// actor.SocialMediaLinks.UpdateLink(SocialMediaType.Facebook, "https://facebook.com/new-johndoe");
// actor.SocialMediaLinks.UpdateLink(SocialMediaType.OfficialWebsite, "https://www.new-johndoe.com");

// V6
actor.SocialMediaLinks.UpdateLink(new TwitterLink("John's Twitter", "https://twitter.com/new-johndoe"));
actor.SocialMediaLinks.UpdateLink(new InstagramLink("John's Instagram", "https://instagram.com/new-johndoe"));
actor.SocialMediaLinks.UpdateLink(new FacebookLink("John's Facebook", "https://facebook.com/new-johndoe"));
actor.SocialMediaLinks.UpdateLink(new OfficialWebsite("John's Official Website", "https://www.new-johndoe.com"));

// Get a specific social media link
Console.WriteLine($"Updated Twitter: {actor.SocialMediaLinks.GetLink("John's Twitter").Link}");
Console.WriteLine($"Updated Instagram: {actor.SocialMediaLinks.GetLink("John's Instagram").Link}");
Console.WriteLine($"Updated Facebook: {actor.SocialMediaLinks.GetLink("John's Facebook").Link}");
Console.WriteLine($"Updated OfficialWebsite: {actor.SocialMediaLinks.GetLink("John's Official Website").Link}");

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
// actor.SocialMediaLinks.RemoveLink(SocialMediaType.Twitter);
// actor.SocialMediaLinks.RemoveLink(SocialMediaType.Instagram);
// actor.SocialMediaLinks.RemoveLink(SocialMediaType.Facebook);
// actor.SocialMediaLinks.RemoveLink(SocialMediaType.OfficialWebsite);

// V4 - Immutable
// actor.SetSocialMediaLinks(actor.SocialMediaLinks.RemoveLink(SocialMediaType.Twitter));
// actor.SetSocialMediaLinks(actor.SocialMediaLinks.RemoveLink(SocialMediaType.Instagram));
// actor.SetSocialMediaLinks(actor.SocialMediaLinks.RemoveLink(SocialMediaType.Facebook));
// actor.SetSocialMediaLinks(actor.SocialMediaLinks.RemoveLink(SocialMediaType.OfficialWebsite));

// V5
// actor.SocialMediaLinks.RemoveLink(SocialMediaType.Twitter);
// actor.SocialMediaLinks.RemoveLink(SocialMediaType.Instagram);
// actor.SocialMediaLinks.RemoveLink(SocialMediaType.Facebook);
// actor.SocialMediaLinks.RemoveLink(SocialMediaType.OfficialWebsite);

// V6
actor.SocialMediaLinks.RemoveLink("John's Twitter");
actor.SocialMediaLinks.RemoveLink("John's Instagram");
actor.SocialMediaLinks.RemoveLink("John's Facebook");
actor.SocialMediaLinks.RemoveLink("John's Official Website");