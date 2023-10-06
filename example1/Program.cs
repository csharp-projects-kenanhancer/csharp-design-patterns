using example1;

var actor = new Actor("John", "Doe", "John Doe is an acclaimed actor...", "https://twitter.com/johndoe",
    "https://instagram.com/johndoe",
    "https://facebook.com/johndoe", "https://www.johndoe.com");

// Get a specific social media link
Console.WriteLine($"Original Twitter: {actor.Twitter}");
Console.WriteLine($"Original Instagram: {actor.Instagram}");
Console.WriteLine($"Original Facebook: {actor.Facebook}");
Console.WriteLine($"Original OfficialWebsite: {actor.OfficialWebsite}");

// Update social media links for the actor
actor.UpdateTwitterLink("https://twitter.com/new-johndoe");
actor.UpdateInstagramLink("https://instagram.com/new-johndoe");
actor.UpdateFacebookLink("https://facebook.com/new-johndoe");
actor.UpdateOfficialWebsite("https://www.new-johndoe.com");

// Get a specific social media link
Console.WriteLine($"Updated Twitter: {actor.Twitter}");
Console.WriteLine($"Updated Instagram: {actor.Instagram}");
Console.WriteLine($"Updated Facebook: {actor.Facebook}");
Console.WriteLine($"Updated OfficialWebsite: {actor.OfficialWebsite}");

// Remove a specific social media link
actor.RemoveTwitterLink();
actor.RemoveInstagramLink();
actor.RemoveFacebookLink();
actor.RemoveOfficialWebsite();