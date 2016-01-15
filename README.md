# Xamarin.Forms-Toolkit
Toolkit for Xamarin.Forms (Controls, Behaviors, and Converters)!

Build status: [![Build status](https://ci.appveyor.com/api/projects/status/87pdyrxft9kthibg/branch/master?svg=true)](https://ci.appveyor.com/project/JamesMontemagno/xamarin-forms-toolkit/branch/master)

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

* EntryLine: Custom iOS entry control that looks like a line
* ListViewGrouped: It is a ListView, but on iOS it is of UITableViewStyle.Grouped, which looks very nice!

### Behaviors

* EmailValidator: Checks to see if a string is a valid email address
* EmptyValidator: Checks to see if a string is empty or null

### Converters

* BooleanToObject: Takes a bool and coverter is to any object you need all templated up
* HexToColor: Takes in a string hex and coverts to a Xamarin.Forms color
* InvertedBoolean: Inverts that bool!

### Services

* [MessagingService](https://github.com/jamesmontemagno/xamarin.forms-toolkit/wiki/Services#messagingservice): Simplifies the Messaging Center API into having a singleton subscriber so you never have to worry. Also, adds a common question and alert class that can be used across your project.


### License

MIT, see the license file
