﻿using System.Timers;

namespace VEEAM1
{
    internal class AppBuilder
    {
        private static string? _sourceDirectory;
        private static string? _targetDirectory;
        private static string? _loggerPath;
        private System.Timers.Timer _aTimer;

        public AppBuilder(string sourceDirectory, string targetDirectory, string loggerPath, int time)
        {
            _loggerPath = loggerPath;
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
<<<<<<< HEAD

=======
            
>>>>>>> 6fd095866cc8eb1ffcf63f8e2311b39c6e7dedb0
            _aTimer.AutoReset = true;
            _aTimer.Enabled = true;
            _aTimer.Start();
            Console.ReadLine();
<<<<<<< HEAD

=======
            
>>>>>>> 6fd095866cc8eb1ffcf63f8e2311b39c6e7dedb0
        }

        private void OnTimeEvent(object? sender, ElapsedEventArgs e)
        {
<<<<<<< HEAD
            CopyDir copyDir = new CopyDir(_sourceDirectory!, _targetDirectory!, _loggerPath);
            
        }

        


=======
            Console.WriteLine($"Time:{DateTime.Now}.");
            CopyDir copyDir = new CopyDir(_sourceDirectory!, _targetDirectory!);
            CompareFiles(_sourceDirectory, _targetDirectory);


        }

        private void CompareFiles(string source, string target)
        {
            DirectoryInfo checkSource = new DirectoryInfo(source);
            DirectoryInfo checkTarget = new DirectoryInfo(target);

            foreach (FileInfo sourceFile in checkSource.GetFiles())
            {
                foreach (FileInfo targetFile in checkTarget.GetFiles())
                {
                    if (sourceFile.Exists && string.Equals(sourceFile.Name, targetFile.Name))
                    {
                        Console.WriteLine("XXXXXXXXXXXXXXXXXXXX");
                        Console.WriteLine($"Copying {sourceFile.FullName}");
                    }
                    else if (targetFile.Exists && File.Exists(Path.Combine(targetFile.Name, checkSource.FullName)))
                    {
                        Console.WriteLine("////////////");
                        Console.WriteLine($"Removed {targetFile.Name}");
                        targetFile.Delete();
                    }
                    else if (sourceFile.Exists && File.Exists(Path.Combine(sourceFile.Name, checkTarget.FullName)))
                    {
                        Console.WriteLine("+++++++++++++++++++++++");
                        Console.WriteLine($"Created {sourceFile.FullName}");
                    }


                }
            }
            foreach (DirectoryInfo subDir in checkSource.GetDirectories())
            {
                foreach (DirectoryInfo subDirTarget in checkTarget.GetDirectories())
                {
                    CompareFiles(subDir.FullName, subDirTarget.FullName);
                }
            }
        }

        
>>>>>>> 6fd095866cc8eb1ffcf63f8e2311b39c6e7dedb0
    }
}
