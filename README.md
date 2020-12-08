# Portfolio-Unity-FPSTutorial

Sample project provided by the Unity IDE, "FPS Tutorials".

The main scene of this project is "MainScene.unity". File -> Open Scene -> FPS/Scenes/MainScene.unity

## Modifications:
### Mobile interface
Added mobile interface to play on phone or tablet.
![alt text](https://github.com/steve-levesque/Portfolio-Unity-FPSTutorial/blob/main/Mobile_Screenshot.jpg?raw=true)

## Additional information
### Unity version:
2019.4.16f1 LTS
### WebGL compiled link: 
https://steve-levesque.github.io/Portfolio-Unity-FPSTutorial/

## How to run game or code/scripts
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
