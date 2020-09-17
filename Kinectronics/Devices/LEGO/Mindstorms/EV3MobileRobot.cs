﻿namespace Kinectronics.Devices.LEGO.Mindstorms
{
    using MonoBrickx64.EV3;
    using MonoLibUsb;
    using System;

    class EV3MobileRobot : GroundVehicle
    {
        private string _connectionString = null;
        public Brick<Sensor, Sensor, Sensor, Sensor> ev3;
        public sbyte movespeed = 40;
        public sbyte turnspeed = 25;
        public EV3MobileRobot(string connectionString) : base(connectionString)
        {
            _connectionString = connectionString;
        }

        public override void StablishConnection()
        {
            base.StablishConnection();
            ev3 = new Brick<Sensor, Sensor, Sensor, Sensor>(_connectionString);
            try
            {
                ev3.Connection.Open();
            } catch (Exception exc)
            {
                throw new System.NotImplementedException();
            }
        }

        public override void TurnRight()
        {
            Console.WriteLine("Turn Right");
            ev3.MotorB.On(turnspeed);
            ev3.MotorC.Off();
        }

        public override void TurnLeft()
        {
            Console.WriteLine("Turn Left");
            ev3.MotorC.On(turnspeed);
            ev3.MotorB.Off();
        }

        public override void MoveForward()
        {
            Console.WriteLine("Forward");
            ev3.MotorC.On(movespeed);
            ev3.MotorB.On(movespeed);
        }

        public override void MoveBackward()
        {
            Console.WriteLine("Backward");
            movespeed = -40;
            ev3.MotorC.On(movespeed);
            ev3.MotorB.On(movespeed);
        }

        public override void Stop()
        {
            ev3.MotorB.Brake();
            ev3.MotorC.Brake();
        }

        public override void StopConnection()
        {
            ev3.Connection.Close();
        }
    }
}
