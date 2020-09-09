# Kinectronics

![logo](https://github.com/JMRMEDEV/Kinectronics/blob/master/RepositoryMedia/Kinectronics.png)

Welcome!

Kinectronics is an API (Application Programming Interface) written in C# for standard .NET framework. It is inttended to be an easier and practical way to control (by programming) several devices such as drones, mobile robots, robotic arms and many more through gesture recognition by using Microsoft's Kinect v2.

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
- Visual Studio (any version compatible with .NET framework 4.8)
- Kinect v2
- Kinect v2 adapter for PC
- Kinect v2 official SDK

## Installation

Just Git Clone this repository in your favourite folder and build the solution with Visual Studio.

## Warning 

As stated in the MIT license, this software is provided with no warranty of any kind. Therefore, me or the contributors are not responsible for any damage to your real hardware, like drones, robots and so. Please, before trying this software in your real hardware, do some tests in the recommended simulations and consult the bug state of the support for your device.

## Usage

Just create a new **device** object in **GestureDetector** Class, make reference to an existing **Gesture Data Base** and define your own controller method in **GestureDetector**. 
A clear example of this can be found in [here](https://github.com/JMRMEDEV/KinectronicsApps/blob/master/Bebop2Controller/Kinectronics/Kinectronics/GestureDetector.cs).

## Media

**User Interface**

A clear joint tracking is seen.

![GUI](https://github.com/JMRMEDEV/Kinectronics/blob/master/RepositoryMedia/Yf9WsgCtdw.png)

**Data tracker**

Real time joint position data tracking.

![DataTracker](https://github.com/JMRMEDEV/Kinectronics/blob/master/RepositoryMedia/iOcZeyRK8S.png)
