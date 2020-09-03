using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinectronics
{
    public class VisualDataTracker
    {
        public struct SelectedJoints
        {
            public struct Head
            {
                public int joint_number;
                public bool tracked;
            }
            public struct Neck
            {
                public int joint_number;
                public bool tracked;
            }
            public struct SpineShoulder
            {
                public int joint_number;
                public bool tracked;
            }
            public struct ShoulderRight
            {
                public int joint_number;
                public bool tracked;
            }
            public struct ShoulderLeft
            {
                public int joint_number;
                public bool tracked;
            }
            public struct SpineMid
            {
                public int joint_number;
                public bool tracked;
            }
            public struct ElbowRight
            {
                public int joint_number;
                public bool tracked;
            }
            public struct ElbowLeft
            {
                public int joint_number;
                public bool tracked;
            }
            public struct SpineBase
            {
                public int joint_number;
                public bool tracked;
            }
            public struct HipRight
            {
                public int joint_number;
                public bool tracked;
            }
            public struct HipLeft
            {
                public int joint_number;
                public bool tracked;
            }
            public struct WristRight
            {
                public int joint_number;
                public bool tracked;
            }
            public struct WristLeft
            {
                public int joint_number;
                public bool tracked;
            }
            public struct ThumbRight
            {
                public int joint_number;
                public bool tracked;
            }
            public struct ThumbLeft
            {
                public int joint_number;
                public bool tracked;
            }
            public struct HandRight
            {
                public int joint_number;
                public bool tracked;
            }
            public struct HandLeft
            {
                public int joint_number;
                public bool tracked;
            }
            public struct HandTipRight
            {
                public int joint_number;
                public bool tracked;
            }
            public struct HandTipLeft
            {
                public int joint_number;
                public bool tracked;
            }
            public struct KneeRight
            {
                public int joint_number;
                public bool tracked;
            }
            public struct KneeLeft
            {
                public int joint_number;
                public bool tracked;
            }
            public struct AnkleRight
            {
                public int joint_number;
                public bool tracked;
            }
            public struct AnkleLeft
            {
                public int joint_number;
                public bool tracked;
            }
            public struct FootRight
            {
                public int joint_number;
                public bool tracked;
            }
            public struct FootLeft
            {
                public int joint_number;
                public bool tracked;
            }
            public Head head;
            public Neck neck;
            public SpineShoulder spineShoulder;
            public ShoulderRight shoulderRight;
            public ShoulderLeft shoulderLeft;
            public SpineMid spineMid;
            public ElbowRight elbowRight;
            public ElbowLeft elbowLeft;
            public WristRight wristRight;
            public WristLeft wristLeft;
            public SpineBase spineBase;
            public HipRight hipRight;
            public HipLeft hipLeft;
            public HandRight handRight;
            public HandLeft handLeft;
            public HandTipRight handTipRight;
            public HandTipLeft handTipLeft;
            public ThumbRight thumbRight;
            public ThumbLeft thumbLeft;
            public KneeRight kneeRight;
            public KneeLeft kneeLeft;
            public AnkleRight ankleRight;
            public AnkleLeft ankleLeft;
            public FootRight footRight;
            public FootLeft footLeft;
        }
    }
}
