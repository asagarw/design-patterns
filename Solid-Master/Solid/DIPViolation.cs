namespace Solid_Master.Solid
{
    internal class EventLogWriter
    {
        public void Write(string message)
        {
            //Write to event log here
        }
    }

    internal class ServiceWatcher
    {
        // Handle to EventLog writer to write to the logs
        private EventLogWriter writer;

        // This function will be called when the app pool has problem
        public void Notify(string message)
        {
            if (writer == null)
                writer = new EventLogWriter();
            writer.Write(message);
        }
    }
}