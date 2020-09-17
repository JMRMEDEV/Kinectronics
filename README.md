# Kinectronics

![logo](https://github.com/JMRMEDEV/Kinectronics/blob/master/RepositoryMedia/Kinectronics.png)

Welcome!

**Disclaimer:** this is a work in progress. The software and its documentations is constantly changing. Please keep this in mind. May be missing information. If you strongly consider it necessary, you can make **new issues**. Please, do so only if you find extremely dangerous bugs or vulnerabilities or if you find missing documentation. I'll do my best to fix it as soon as I can. You can also make **pull requests** if you already made important improvements to the project. For further contact, comments or questions you can join to the [**Official Discord Server**](https://discord.gg/fzERgZa).

**Kinectronics** is an **API** (Application Programming Interface) and an **extensible application** (for graphic joint tracking) written in **C#** for **standard .NET framework**. It is inttended to be an easier and practical way to control (by programming) several devices such as **drones**, **mobile robots**, **robotic arms** and many more through **gesture recognition** by using **Microsoft's Kinect v2**.

## Features:

- Predefined working gesture databases
- Support for creation of custom gesture databases
- Joint tracking data graphic interface
- Sensor status message
- Skeleton drawing in GUI
- Support for official and popular mechatronic and robotic devices
- Modular programming
- Good performance

## Requirements

- Windows (any version compatible with Kinect v2 SDK)
- 64 Bit architecture
- Visual Studio IDE (any version compatible with .NET framework 4.8). You can find the **free** Community version in [**here**](https://visualstudio.microsoft.com/es/vs/community/)
- **Kinect v2**
- Kinect v2 adapter for PC
- [Kinect v2 official SDK](https://www.microsoft.com/en-us/download/details.aspx?id=44561)

## Installation

Just Git Clone this repository in your favourite folder and build the solution with Visual Studio.

## Warning 

As stated in the MIT license, this software is provided with no warranty of any kind. Therefore, me or the contributors are not responsible for any damage to your real hardware, like drones, robots and so. Please, before trying this software in your real hardware, do some tests in the recommended simulations and consult the bug state of the support for your device.

## Usage

Just create a new **device** object in **GestureDetector** Class, make reference to an existing **Gesture Data Base** and define your own controller method in **GestureDetector**. 
A clear example of this can be found in [**here**](https://github.com/JMRMEDEV/KinectronicsApps/blob/master/Bebop2Controller/Kinectronics/Kinectronics/GestureDetector.cs).

**Note:** For a deeper explanation of the features and usage of **Kinectronics**, please, visit the [**wiki**](https://github.com/JMRMEDEV/Kinectronics/wiki).

## Example Apps

Please, take a look to stable applications that already implement Kinectronics in [**here**](https://github.com/JMRMEDEV/KinectronicsApps).

## Future Releases

It is intendded to add a lot of features to the software. In mid-term, I'm planning to:

- Add support for **Kinect V1**
- Add support for **Azure Kinect**
- Release C++ version of the software
- Release a Linux compatible version of the software
- Add support for ROS
- Add support for Webots

## Special Thanks

I want to specially thank to:

- [Vangos Pterneas](https://github.com/Vangos) because of its great labor on explaining Kinect, its features and making a great job with this technology through the years. His work was a great inspiration for this project. You can visit his [site](https://pterneas.com/).
- [Josué Martínez Buenrrostro](https://github.com/josuemb) my beloved father, who in terms of software developing, is a great inspiration and teacher for me.

## Media

**User Interface**

A clear joint tracking is seen.

![GUI](https://github.com/JMRMEDEV/Kinectronics/blob/master/RepositoryMedia/Yf9WsgCtdw.png)

**Data tracker**

Real time joint position data tracking.

![DataTracker](https://github.com/JMRMEDEV/Kinectronics/blob/master/RepositoryMedia/iOcZeyRK8S.png)
