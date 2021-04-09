using System;

namespace FlightRecorder.Client.SimConnectMSFS
{
    public class AircraftPositionUpdatedEventArgs : EventArgs
    {
        public AircraftPositionUpdatedEventArgs(AircraftPositionStruct position)
        {
            Position = position;
        }


        public AircraftPositionUpdatedEventArgs(string video_position)
        {
            Video_Position = video_position;
        }

        public AircraftPositionStruct Position { get; }
        public string Video_Position { get; }
    }
}
