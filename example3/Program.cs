﻿using example3;

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
// actor.SocialMediaLinks.UpdateTwitterLink("https://twitter.com/new-johndoe");
// actor.SocialMediaLinks.UpdateInstagramLink("https://instagram.com/new-johndoe");
// actor.SocialMediaLinks.UpdateFacebookLink("https://facebook.com/new-johndoe");
// actor.SocialMediaLinks.UpdateOfficialWebsite("https://www.new-johndoe.com");

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
// actor.SocialMediaLinks.RemoveTwitterLink();
// actor.SocialMediaLinks.RemoveInstagramLink();
// actor.SocialMediaLinks.RemoveFacebookLink();
// actor.SocialMediaLinks.RemoveOfficialWebsite();

actor.SocialMediaLinks.RemoveLink(SocialMediaType.Twitter);
actor.SocialMediaLinks.RemoveLink(SocialMediaType.Instagram);
actor.SocialMediaLinks.RemoveLink(SocialMediaType.Facebook);
actor.SocialMediaLinks.RemoveLink(SocialMediaType.OfficialWebsite);