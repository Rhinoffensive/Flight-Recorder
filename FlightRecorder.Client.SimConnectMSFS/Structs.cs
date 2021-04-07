﻿using Microsoft.FlightSimulator.SimConnect;
using System.Runtime.InteropServices;

namespace FlightRecorder.Client
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    public struct AircraftPositionStruct
    {
        //public int SimRate;

        [SimConnectVariable(Name = "PLANE LATITUDE", Unit = "Degrees", Type = SIMCONNECT_DATATYPE.FLOAT64)]
        public double Latitude;
        [SimConnectVariable(Name = "PLANE LONGITUDE", Unit = "Degrees", Type = SIMCONNECT_DATATYPE.FLOAT64)]
        public double Longitude;
        [SimConnectVariable(Name = "PLANE ALTITUDE", Unit = "Feet", Type = SIMCONNECT_DATATYPE.FLOAT64)]
        public double Altitude;

        [SimConnectVariable(Name = "PLANE PITCH DEGREES", Unit = "Degrees", Type = SIMCONNECT_DATATYPE.FLOAT64, Minimum = -90, Maximum = 90)]
        public double Pitch;
        [SimConnectVariable(Name = "PLANE BANK DEGREES", Unit = "Degrees", Type = SIMCONNECT_DATATYPE.FLOAT64, Minimum = -180, Maximum = 180)]
        public double Bank;
        [SimConnectVariable(Name = "PLANE HEADING DEGREES TRUE", Unit = "Degrees", Type = SIMCONNECT_DATATYPE.FLOAT64, Minimum = 0, Maximum = 360)]
        public double TrueHeading;
        [SimConnectVariable(Name = "PLANE HEADING DEGREES MAGNETIC", Unit = "Degrees", Type = SIMCONNECT_DATATYPE.FLOAT64, Minimum = 0, Maximum = 360)]
        public double MagneticHeading;

        [SimConnectVariable(Name = "VELOCITY BODY X", Unit = "Feet per second", Type = SIMCONNECT_DATATYPE.FLOAT64)]
        public double VelocityBodyX;
        [SimConnectVariable(Name = "VELOCITY BODY Y", Unit = "Feet per second", Type = SIMCONNECT_DATATYPE.FLOAT64)]
        public double VelocityBodyY;
        [SimConnectVariable(Name = "VELOCITY BODY Z", Unit = "Feet per second", Type = SIMCONNECT_DATATYPE.FLOAT64)]
        public double VelocityBodyZ;
        [SimConnectVariable(Name = "ROTATION VELOCITY BODY X", Unit = "radians per second", Type = SIMCONNECT_DATATYPE.FLOAT64)]
        public double RotationVelocityBodyX;
        [SimConnectVariable(Name = "ROTATION VELOCITY BODY Y", Unit = "radians per second", Type = SIMCONNECT_DATATYPE.FLOAT64)]
        public double RotationVelocityBodyY;
        [SimConnectVariable(Name = "ROTATION VELOCITY BODY Z", Unit = "radians per second", Type = SIMCONNECT_DATATYPE.FLOAT64)]
        public double RotationVelocityBodyZ;

        [SimConnectVariable(Name = "AILERON POSITION", Unit = "Position", Type = SIMCONNECT_DATATYPE.FLOAT64)]
        public double AileronPosition;
        [SimConnectVariable(Name = "ELEVATOR POSITION", Unit = "Position", Type = SIMCONNECT_DATATYPE.FLOAT64)]
        public double ElevatorPosition;
        [SimConnectVariable(Name = "RUDDER POSITION", Unit = "Position", Type = SIMCONNECT_DATATYPE.FLOAT64)]
        public double RudderPosition;

        [SimConnectVariable(Name = "ELEVATOR TRIM POSITION", Unit = "Radians", Type = SIMCONNECT_DATATYPE.FLOAT64)]
        public double ElevatorTrimPosition;
        [SimConnectVariable(Name = "AILERON TRIM PCT", Unit = "Percent Over 100", Type = SIMCONNECT_DATATYPE.FLOAT64)]
        public double AileronTrimPercent;
        [SimConnectVariable(Name = "RUDDER TRIM PCT", Unit = "Percent Over 100", Type = SIMCONNECT_DATATYPE.FLOAT64)]
        public double RudderTrimPercent;

        [SimConnectVariable(Name = "FLAPS HANDLE INDEX", Unit = "Number", Type = SIMCONNECT_DATATYPE.INT32)]
        public uint FlapsHandleIndex;
        [SimConnectVariable(Name = "TRAILING EDGE FLAPS LEFT PERCENT", Unit = "Position", Type = SIMCONNECT_DATATYPE.FLOAT64)]
        public double TrailingEdgeFlapsLeftPercent;
        [SimConnectVariable(Name = "TRAILING EDGE FLAPS RIGHT PERCENT", Unit = "Position", Type = SIMCONNECT_DATATYPE.FLOAT64)]
        public double TrailingEdgeFlapsRightPercent;
        [SimConnectVariable(Name = "LEADING EDGE FLAPS LEFT PERCENT", Unit = "Position", Type = SIMCONNECT_DATATYPE.FLOAT64)]
        public double LeadingEdgeFlapsLeftPercent;
        [SimConnectVariable(Name = "LEADING EDGE FLAPS RIGHT PERCENT", Unit = "Position", Type = SIMCONNECT_DATATYPE.FLOAT64)]
        public double LeadingEdgeFlapsRightPercent;

        [SimConnectVariable(Name = "GENERAL ENG THROTTLE LEVER POSITION:1", Unit = "Position", Type = SIMCONNECT_DATATYPE.FLOAT64)]
        public double ThrottleLeverPosition1;
        [SimConnectVariable(Name = "GENERAL ENG THROTTLE LEVER POSITION:2", Unit = "Position", Type = SIMCONNECT_DATATYPE.FLOAT64)]
        public double ThrottleLeverPosition2;
        [SimConnectVariable(Name = "GENERAL ENG THROTTLE LEVER POSITION:3", Unit = "Position", Type = SIMCONNECT_DATATYPE.FLOAT64)]
        public double ThrottleLeverPosition3;
        [SimConnectVariable(Name = "GENERAL ENG THROTTLE LEVER POSITION:4", Unit = "Position", Type = SIMCONNECT_DATATYPE.FLOAT64)]
        public double ThrottleLeverPosition4;

        [SimConnectVariable(Name = "SPOILERS HANDLE POSITION", Unit = "Percent", Type = SIMCONNECT_DATATYPE.FLOAT64)]
        public double SpoilerHandlePosition;
        [SimConnectVariable(Name = "GEAR HANDLE POSITION", Unit = "Bool", Type = SIMCONNECT_DATATYPE.INT32)]
        public uint GearHandlePosition;
        [SimConnectVariable(Name = "WATER RUDDER HANDLE POSITION", Unit = "Percent Over 100", Type = SIMCONNECT_DATATYPE.FLOAT64)]
        public double WaterRudderHandlePosition;

        [SimConnectVariable(Name = "BRAKE LEFT POSITION", Unit = "Position", Type = SIMCONNECT_DATATYPE.FLOAT64)]
        public double BrakeLeftPosition;
        [SimConnectVariable(Name = "BRAKE RIGHT POSITION", Unit = "Position", Type = SIMCONNECT_DATATYPE.FLOAT64)]
        public double BrakeRightPosition;

        // Some variables that can only be set by triggering events
        [SimConnectVariable(Name = "BRAKE PARKING POSITION", Unit = "Position", Type = SIMCONNECT_DATATYPE.INT32, SetType = SetType.Event, SetByEvent = "PARKING_BRAKES")]
        public uint BrakeParkingPosition;

        [SimConnectVariable(Name = "LIGHT TAXI", Unit = "Bool", Type = SIMCONNECT_DATATYPE.INT32, SetType = SetType.Event, SetByEvent = "TOGGLE_TAXI_LIGHTS")]
        public uint LightTaxi;
        [SimConnectVariable(Name = "LIGHT LANDING", Unit = "Bool", Type = SIMCONNECT_DATATYPE.INT32, SetType = SetType.Event, SetByEvent = "LANDING_LIGHTS_TOGGLE")]
        public uint LightLanding;
        [SimConnectVariable(Name = "LIGHT STROBE", Unit = "Bool", Type = SIMCONNECT_DATATYPE.INT32, SetType = SetType.Event, SetByEvent = "STROBES_TOGGLE")]
        public uint LightStrobe;
        [SimConnectVariable(Name = "LIGHT BEACON", Unit = "Bool", Type = SIMCONNECT_DATATYPE.INT32, SetType = SetType.Event, SetByEvent = "TOGGLE_BEACON_LIGHTS")]
        public uint LightBeacon;
        [SimConnectVariable(Name = "LIGHT NAV", Unit = "Bool", Type = SIMCONNECT_DATATYPE.INT32, SetType = SetType.Event, SetByEvent = "TOGGLE_NAV_LIGHTS")]
        public uint LightNav;
        [SimConnectVariable(Name = "LIGHT WING", Unit = "Bool", Type = SIMCONNECT_DATATYPE.INT32, SetType = SetType.Event, SetByEvent = "TOGGLE_WING_LIGHTS")]
        public uint LightWing;
        [SimConnectVariable(Name = "LIGHT LOGO", Unit = "Bool", Type = SIMCONNECT_DATATYPE.INT32, SetType = SetType.Event, SetByEvent = "TOGGLE_LOGO_LIGHTS")]
        public uint LightLogo;
        [SimConnectVariable(Name = "LIGHT RECOGNITION", Unit = "Bool", Type = SIMCONNECT_DATATYPE.INT32, SetType = SetType.Event, SetByEvent = "TOGGLE_RECOGNITION_LIGHTS")]
        public uint LightRecognition;
        [SimConnectVariable(Name = "LIGHT CABIN", Unit = "Bool", Type = SIMCONNECT_DATATYPE.INT32, SetType = SetType.Event, SetByEvent = "TOGGLE_CABIN_LIGHTS")]
        public uint LightCabin;

        // Some variables that are only for info and display
        [SimConnectVariable(Name = "SIMULATION RATE", Unit = "Number", Type = SIMCONNECT_DATATYPE.INT32, SetType = SetType.None)]
        public uint SimulationRate;
        [SimConnectVariable(Name = "ABSOLUTE TIME", Unit = "Seconds", Type = SIMCONNECT_DATATYPE.FLOAT64, SetType = SetType.None)]
        public double AbsoluteTime;
        [SimConnectVariable(Name = "PLANE ALT ABOVE GROUND", Unit = "Feet", Type = SIMCONNECT_DATATYPE.FLOAT64, SetType = SetType.None)]
        public double AltitudeAboveGround;
        [SimConnectVariable(Name = "SIM ON GROUND", Unit = "Bool", Type = SIMCONNECT_DATATYPE.INT32, SetType = SetType.None)]
        public uint IsOnGround;
        [SimConnectVariable(Name = "AMBIENT WIND VELOCITY", Unit = "Knots", Type = SIMCONNECT_DATATYPE.FLOAT64, SetType = SetType.None)]
        public double WindVelocity;
        [SimConnectVariable(Name = "AMBIENT WIND DIRECTION", Unit = "Degrees", Type = SIMCONNECT_DATATYPE.FLOAT64, SetType = SetType.None)]
        public double WindDirection;
        [SimConnectVariable(Name = "G FORCE", Unit = "GForce", Type = SIMCONNECT_DATATYPE.FLOAT64, SetType = SetType.None)]
        public double GForce;
        [SimConnectVariable(Name = "PLANE TOUCHDOWN NORMAL VELOCITY", Unit = "Feet per minute", Type = SIMCONNECT_DATATYPE.FLOAT64, SetType = SetType.None)]
        public double TouchdownNormalVelocity;
        [SimConnectVariable(Name = "WING FLEX PCT:1", Unit = "Percent over 100", Type = SIMCONNECT_DATATYPE.FLOAT64, SetType = SetType.None)]
        public double WingFlexPercent1;
        [SimConnectVariable(Name = "WING FLEX PCT:2", Unit = "Percent over 100", Type = SIMCONNECT_DATATYPE.FLOAT64, SetType = SetType.None)]
        public double WingFlexPercent2;
        [SimConnectVariable(Name = "WING FLEX PCT:3", Unit = "Percent over 100", Type = SIMCONNECT_DATATYPE.FLOAT64, SetType = SetType.None)]
        public double WingFlexPercent3;
        [SimConnectVariable(Name = "WING FLEX PCT:4", Unit = "Percent over 100", Type = SIMCONNECT_DATATYPE.FLOAT64, SetType = SetType.None)]
        public double WingFlexPercent4;


        //My vars
        [SimConnectVariable(Name = "PLANE TOUCHDOWN BANK DEGREES", Unit = "Degrees", Type = SIMCONNECT_DATATYPE.FLOAT64, SetType = SetType.None)]
        public double PlaneTouchDownBank;
        [SimConnectVariable(Name = "PLANE TOUCHDOWN HEADING DEGREES MAGNETIC", Unit = "Degrees", Type = SIMCONNECT_DATATYPE.FLOAT64, SetType = SetType.None)]
        public double PlaneTouchHeadingMagnetic;
        [SimConnectVariable(Name = "PLANE TOUCHDOWN LATITUDE", Unit = "Radians", Type = SIMCONNECT_DATATYPE.FLOAT64, SetType = SetType.None)]
        public double PlaneTouchLatitude;
        [SimConnectVariable(Name = "PLANE TOUCHDOWN LONGITUDE", Unit = "Radians", Type = SIMCONNECT_DATATYPE.FLOAT64, SetType = SetType.None)]
        public double PlaneTouchLongitude;
        [SimConnectVariable(Name = "PLANE TOUCHDOWN NORMAL VELOCITY", Unit = "Feet per second", Type = SIMCONNECT_DATATYPE.FLOAT64)]
        public double PlaneTouchNormalVelocity;
        [SimConnectVariable(Name = "PLANE TOUCHDOWN PITCH DEGREES", Unit = "Degrees", Type = SIMCONNECT_DATATYPE.FLOAT64, SetType = SetType.None)]
        public double PlaneTouchPitch;



    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    public partial struct AircraftPositionSetStruct
    {
        public static AircraftPositionSetStruct operator *(AircraftPositionSetStruct position, double factor)
            => AircraftPositionStructOperator.Scale(position, factor);

        public static AircraftPositionSetStruct operator +(AircraftPositionSetStruct position1, AircraftPositionSetStruct position2)
            => AircraftPositionStructOperator.Add(position1, position2);
    }
}
