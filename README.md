# Xamarin.Forms-Toolkit
Toolkit for Xamarin.Forms (Controls, Behaviors, and Converters)!

## What is this?
I created this repo for reference of a nice collection of controls, behaviors, and converters that could come in nifty for you when creating Xamarin.Forms applications. I plan on adding to this over time and eventually consuming it in a bunch of my applications and hope you will to.

## What's the plan and when can I have it?
You can grab it from: https://www.nuget.org/packages/FormsToolkit

Once installed you must call ```Toolkit.Init();``` from under your ```Forms.Init()``` call in each project.

## Can I contribute?
Sure! Ideally, I would love to bring in anything that is very small and light weight. No need to bring in tons of custom controls as those should be smaller NuGet packages. The goal here is to just create a library with small tweaks that are nifty.

If you want to add something please create an issue and mark it with [Proposed] and we can have a discussion around it.

## What is in it?

### Controls
Namespace: **FormsToolkit.Controls**

* EntryLine: Custom iOS entry control that looks like a line
* ListViewGrouped: It is a ListView, but on iOS it is of UITableViewStyle.Grouped, which looks very nice!

### Behaviors
Namespace: **FormsToolkit.Behaviors**

* EmailValidator: Checks to see if a string is a valid email address
* EmptyValidator: Checks to see if a string is empty or null

### Converters
Namespace: **FormsToolkit.Converters**

* BooleanToObject: Takes a bool and coverter is to any object you need all templated up
* HexToColor: Takes in a string hex and coverts to a Xamarin.Forms color
* InvertedBoolean: Inverts that bool!

### Services
Namespace: **FormsToolkit.Services**

* MessagingService: Simplivies the MessagingService into having a singleton subscriber so you never have to worry. Also added a common question and alert class.
*

#### MessagingService
Subscribe
```csharp
MessagingService.Current.Subscribe<MessagingServiceQuestion> ("question", async (arg1, arg2) => 
{
    var result = await DisplayAlert (arg2.Title, arg2.Question, arg2.Positive, arg2.Negative);

    await DisplayAlert ("Result", result.ToString(), "OK");
});

MessagingService.Current.Subscribe<MessagingServiceAlert> ("alert", async (arg1, arg2) => 
{
   await DisplayAlert (arg2.Title, arg2.Message, arg2.Cancel);
});

MessagingService.Current.Subscribe ("message", async (e) => 
{
    await DisplayAlert ("Received", "Got message from Messaging Service", "OK");
});
```

Unsubscribe:
```csharp
MessagingService.Current.Unsubscribe<MessagingServiceQuestion> ("question");
MessagingService.Current.Unsubscribe<MessagingServiceAlert> ("alert");
MessagingService.Current.Unsubscribe ("message");
```

Send Messages:
```csharp
MessagingService.Current.SendMessage("question", new MessagingServiceQuestion
{
    Title = "Question",
    Question = "Is this awesome?",
    Positive = "YES",
    Negative = "NO"
});

MessagingService.Current.SendMessage("alert", new MessagingServiceAlert
{
    Title = "Alert",
    Message = "This is is coming form messaging service",
    Cancel = "OK",
});

MessagingService.Current.SendMessage("message");
```

### License

MIT, see the license file
