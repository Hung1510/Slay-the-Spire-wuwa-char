This folder is intentionally near-empty.

Run this once, inside `shorekeeper-sts2/`, after installing the template pack:

    dotnet new install Alchyr.Sts2.Templates
    dotnet new list                     # confirm the exact character-template short name
    cd Shorekeeper
    dotnet new sts2-character           # generates the real .csproj / .sln / manifest json here

Delete this file once the real project files exist.

Why this step isn't pre-generated in this scaffold: the template pulls the current BaseLib
version and STS2/Godot .NET target from NuGet at generation time, and hardcoding a snapshot here
would go stale the moment STS2 patches. Generating it fresh locally guarantees you're building
against whatever BaseLib/STS2 version you actually have installed.
