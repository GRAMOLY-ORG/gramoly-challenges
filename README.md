# [GRAMOLY Challenges](https://challenges.gramoly.org)
GRAMOLY Challenges is a modern concept, a new platform, and a new route of doing POTD. The challenges brought to you by GRAMOLY are daily problems of STEM assigned to you by the team which consist of live and interactive rankings, dynamic leaderboards, and points. It will help you become better at problem-solving in a really fun and gamified way.

If this doesn’t excite you enough then you will be hooked to learn that due to our powerful servers, the leaderboard will be revised every second!

Last but not the least, you can attempt it over your favorite social platform, [discord](https://gramoly.org/discord). No more hassle of changing the platform. Although, don’t be afraid if you aren’t active on discord. You can very well attempt it over the website as well.

> Learn more at https://challenges.gramoly.org/ 

- [Math Challenges](https://math-challenges.gramoly.org)
- [Physics Challenges](https://physics-challenges.gramoly.org)



## Requirements

If you are planning to use the full version of this app you will need access to:

- A MySQL server
- A SMTP server 


## Installation

#### Clone GRAMOLY Challenges

```
git clone https://github.com/TheBlapse/gramoly-challenges
```

#### Install .NET Core SDK 6.0

Using Ubuntu 20.04? Just run `sudo bash install-dotnet.sh`. Otherwise:

Please visit [https://docs.microsoft.com/en-us/dotnet/core/install/linux-ubuntu](https://docs.microsoft.com/en-us/dotnet/core/install/linux-ubuntu) for instructions on how to install .NET Core SDK 6.0 in your Ubuntu distribution.

#### Edit `appsettings.json.example`

Rename `appsettings.json.example` to `appsettings.json` and add values.

#### Publish it

```
sudo bash build.sh
```

NOTE: published apps are usually under `src/[project_folder]/bin/Release/net6.0/publish/` directories.

#### Execute both apps

<!-- [TODO] Add scripts to auto generate systemd service files  -->

```
dotnet "path_to_the_published_discord_bot.dll" &
dotnet "path_to_the_published_website.dll" &
```

### Default login:
username: `admin`
password: `Admin123!`


> **Note:** This platform is a fork of [@Et3rnos](https://github.com/Et3rnos/)'s [ImaginaryCTF](https://github.com/Et3rnos/ImaginaryCTF) but modified to fullfill GRAMOLY's needs.
