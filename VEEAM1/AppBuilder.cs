using System.Timers;

namespace VEEAM1
{
    internal class AppBuilder
    {
        private static string? _sourceDirectory;
        private static string? _targetDirectory;
        private System.Timers.Timer _aTimer;

        public AppBuilder(string sourceDirectory, string targetDirectory, int time)
        {
            _aTimer = new System.Timers.Timer(time);
            _sourceDirectory = sourceDirectory;
            _targetDirectory = targetDirectory;
        }

        public void Start()
        {
            SetTimer();
        }

        private void SetTimer()
        {

            _aTimer.Elapsed += OnTimeEvent;
            
            _aTimer.AutoReset = true;
            _aTimer.Enabled = true;
            _aTimer.Start();
            Console.ReadLine();
            
        }

        private void OnTimeEvent(object? sender, ElapsedEventArgs e)
        {
            new CopyDir(_sourceDirectory, _targetDirectory);
        }

        
    }
}
