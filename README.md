<!-- Repo's Banner -->
![Portfolio-Unity-FPSTutorial](https://user-images.githubusercontent.com/42849270/124336482-2ba33800-db6c-11eb-8d4b-7c0c19092192.png)



<!-- Shield Badges -->
[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![MIT License][license-shield]][license-url]



<!-- Description of the Project -->
## About
Sample project provided by the Unity IDE, "FPS Tutorials".

The main scene of this project is "MainScene.unity". File -> Open Scene -> FPS/Scenes/MainScene.unity

### Modifications:
#### Mobile interface
Added mobile interface to play on phone or tablet.
![alt text](https://github.com/steve-levesque/Portfolio-Unity-FPSTutorial/blob/main/Mobile_Screenshot.jpg?raw=true)

### Additional information
#### Unity version:
2019.4.16f1 LTS
#### WebGL compiled link: 
https://steve-levesque.github.io/Portfolio-Unity-FPSTutorial/



<!-- Repo's Content Tree -->
## Directories and Files
<details open>
  <summary><b>Project's Tree</b></summary>
    
  ``` bash
    |- Assets                 # Contains add-ons and csharp classes. 
    |- Mobile_Screenshot.jpg  # Screenshot of the game with mobile add-ons.
    |- LICENSE
    |- README.md              # This file
  ```
</details>


<!-- Getting Started -->
## Installation
C# and Unity is needed on the computer.

The Java JDK and Android Graddle is needed for mobile android compiling.



## How to Execute
### C#
- Edit -> Preferences -> External Tools -> External Script Editor -> Visual Studio 20xx
- Assets -> Open C# Project (Skipping step above will make this one fail)
### PC:
Press play on your Unity IDE.
### Android:
- Get Java JDK and SDK and place it in a clean place (no directory with spaces, will not work otherwise to get final product)
- Edit -> Preferences -> External Tool -> link Java JDK & SDK
- Build Settings -> Swtich Platform (Android) -> Build/Build & Run
- More info: https://docs.unity3d.com/Manual/android-BuildProcess.html
### WebGL:
- Build Settings -> Swtich Platform (WebGL) -> Check if Dev Build (*) -> Build/Build & Run
- (*) Choose before Build/Run to do Development or Production Build.
- More info: https://docs.unity3d.com/Manual/webgl-building.html



<!-- Contribution -->
## Contribution

Contributions are always welcome, thank you for you time. Here are the steps to do so.

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/MyContribution`)
3. Commit your Changes (`git commit -m 'Add MyContribution'`)
4. Push to the Branch (`git push origin feature/MyContribution`)
5. Open a Pull Request



<!-- License -->
## License

See the `LICENSE` file at the root of the project directory for more information.



<!-- Acknowlegements and Sources -->
## Acknowlegements and Sources
- Unity's included app template FPSTutorial.



<!-- md links & imgs -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[contributors-shield]: https://img.shields.io/github/contributors/steve-levesque/Portfolio-Unity-FPSTutorial.svg?style=for-the-badge
[contributors-url]: https://github.com/steve-levesque/Portfolio-Unity-FPSTutorial/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/steve-levesque/Portfolio-Unity-FPSTutorial.svg?style=for-the-badge
[forks-url]: https://github.com/steve-levesque/Portfolio-Unity-FPSTutorial/network/members
[stars-shield]: https://img.shields.io/github/stars/steve-levesque/Portfolio-Unity-FPSTutorial.svg?style=for-the-badge
[stars-url]: https://github.com/steve-levesque/Portfolio-Unity-FPSTutorial/stargazers
[issues-shield]: https://img.shields.io/github/issues/steve-levesque/Portfolio-Unity-FPSTutorial.svg?style=for-the-badge
[issues-url]: https://github.com/steve-levesque/Portfolio-Unity-FPSTutorial/issues
[license-shield]: https://img.shields.io/github/license/steve-levesque/Portfolio-Unity-FPSTutorial.svg?style=for-the-badge
[license-url]: https://github.com/steve-levesque/Portfolio-Unity-FPSTutorial/blob/main/LICENSE
