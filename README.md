<!--
*** Thanks for checking out the Best-README-Template. If you have a suggestion
*** that would make this better, please fork the repo and create a pull request
*** or simply open an issue with the tag "enhancement".
*** Thanks again! Now go create something AMAZING! :D
-->



<!-- PROJECT SHIELDS -->
<!--
*** I'm using markdown "reference style" links for readability.
*** Reference links are enclosed in brackets [ ] instead of parentheses ( ).
*** See the bottom of this document for the declaration of the reference variables
*** for contributors-url, forks-url, etc. This is an optional, concise syntax you may use.
*** https://www.markdownguide.org/basic-syntax/#reference-style-links
-->
[![Issues][issues-shield]][issues-url]
[![Stars][stars-shield]][stars-url]
[![Forks][forks-shield]][forks-url]


<!-- PROJECT LOGO -->
<br />
<p align="center">
  <a href="https://github.com/OniSensei/Intersect-GUI-Editor">
    <img src="https://imgur.com/hbkoYdj.png" alt="Logo" width="580" height="176">
  </a>

  <h3 align="center">Intersect Admin Editor</h3>

  <p align="center">
    An admin tool for the <a href="https://github.com/AscensionGameDev/Intersect-Engine">Intersect 2D MMORPG Engine</a>. Allows users to administrate their server without having to load the game client. This tool also provides additional information regarding the server itself. This tool utilizes the <a href="hhttps://docs.freemmorpgmaker.com/en-US/api/v1/">API</a>.
    <br />
    <br />
    <a href="https://github.com/OniSensei/Intersect-Admin/issues">Report Bug</a>
    ·
    <a href="https://github.com/OniSensei/Intersect-Admin/issues">Request Feature</a>
  </p>
</p>



<!-- TABLE OF CONTENTS -->
<details open="open">
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
      <ul>
        <li><a href="#built-with">Built With</a></li>
      </ul>
    </li>
    <li><a href="#roadmap">Roadmap</a></li>
    <li><a href="#contributing">Contributing</a></li>
    <li><a href="#contact">Contact</a></li>
  </ol>
</details>



<!-- ABOUT THE PROJECT -->
## About The Project

[![IAE Screen Shot][product-screenshot]](https://imgur.com/z0ETKXQ.png)

The Intersect Admin Editor was made for my personal use, but I decided to share it as it may be userfull for some people until the official one @jcsnider is working on is released. This is still a work in progress and not all things  are functional at this moment (game objects tab page). The application folder must be placed in the same directory that contains the **Client and Editor**. 

[![Folder Preview][folder-preview]](https://imgur.com/jAAJJU4.png)

Some things you can do with this tool:
* See a list of online players

[![Online Users][online-users]](https://imgur.com/fpQ5AcF.png)
* See Top 10 players by level

[![Ranking][ranking]](https://imgur.com/Cc55dfw.png)
* Moderate players/users
  * Ban & Mute
  * Unban & Unmute
  * Kick & Kill
  * Warp 
* Send messages into the game
  * Send a global broadcast to all clients
  * Send a direct message to a player
  * Send a message to a map

[![Send Chat Message][send-chat]](https://imgur.com/haTB6Mp.png)
* Modify users
  * Access power
  * Password
  * Email
* Register a new user
* Check character information

[![Character Info][character-info]](https://imgur.com/oB0Q2Ab.png)

Of course, nothing is perfect and I will be trying to make it better with every chance i get! Feel free to contribute if you can!


### Built With

* [Chilkat](https://www.chilkatsoft.com/)
* [.NET Framework 4.7.2](https://dotnet.microsoft.com/download/dotnet-framework/net472)
* [Json.NET](https://github.com/JamesNK/Newtonsoft.Json)
* [System.Data.SQLite](https://system.data.sqlite.org/index.html/doc/trunk/www/index.wiki)


<!-- ROADMAP -->
## Roadmap

See the [projects tab](https://github.com/OniSensei/Intersect-Admin/projects) for a list of proposed features (and known issues).



<!-- CONTRIBUTING -->
## Contributing

Contributions are what make the open source community such an amazing place to be learn, inspire, and create. Any contributions you make are **greatly appreciated**.

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request


<!-- CONTACT -->
## Contact

OniSensei - [OniSensei#0420](https://discord.com/users/542094478513668176/)


<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[issues-shield]: https://img.shields.io/github/issues-raw/OniSensei/Intersect-Admin?style=for-the-badge
[issues-url]: https://github.com/OniSensei/Intersect-Admin/issues
[stars-shield]: https://img.shields.io/github/stars/OniSensei/Intersect-Admin?style=for-the-badge
[stars-url]: https://github.com/OniSensei/Intersect-Admin/stargazers
[forks-shield]: https://img.shields.io/github/forks/OniSensei/Intersect-Admin?style=for-the-badge
[forks-url]: https://github.com/OniSensei/Intersect-Admin/network/members
[product-screenshot]: https://imgur.com/z0ETKXQ.png
[folder-preview]: https://imgur.com/jAAJJU4.png
[online-users]: https://imgur.com/fpQ5AcF.png
[ranking]: https://imgur.com/Cc55dfw.png
[character-info]: https://imgur.com/oB0Q2Ab.png
[send-chat]: https://imgur.com/haTB6Mp.png
