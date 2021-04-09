namespace FlightRecorder.Client.Logics
{
    public class RecordVideoClass
    {
        public RecordVideoClass(long ms, string ts)
        {
            Milliseconds = ms;
            timeStamp = ts;
        }


        public long Milliseconds { get; set; }
        public string timeStamp { get; set; }
    }
}