using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VEEAM1
{
    public class CopyDir
    {
        private static DirectoryInfo? _source;
        private static DirectoryInfo? _target;
<<<<<<< HEAD
        private string _loggerPath;
        public CopyDir(string source, string target, string loggerPath)
=======
        public static List<string> _coppyedFiles = new List<string>();
        public static List<string> _removedFiles = new List<string>();


        public CopyDir(string source, string target)
>>>>>>> 6fd095866cc8eb1ffcf63f8e2311b39c6e7dedb0
        {
            _loggerPath = loggerPath;
            _source = new DirectoryInfo(source);
            _target = new DirectoryInfo(target);
            CopyAll(_source, _target);
<<<<<<< HEAD
            CompareFiles(_source, _target);

        }


=======

        }

        public List<string> CoppyedFiles
        { get { return _coppyedFiles; } }
>>>>>>> 6fd095866cc8eb1ffcf63f8e2311b39c6e7dedb0


        public void CopyAll(DirectoryInfo source, DirectoryInfo target)
        {

            if (source.FullName.ToLower() == target.FullName.ToLower())
            {
                return;
            }



<<<<<<< HEAD

=======
>>>>>>> 6fd095866cc8eb1ffcf63f8e2311b39c6e7dedb0
            // Check if the target directory exists, if not, create it.
            if (Directory.Exists(target.FullName) == false)
            {

                Directory.CreateDirectory(target.FullName);
            }

            // Copy each file into it's new directory.
            foreach (FileInfo fi in source.GetFiles())
            {
<<<<<<< HEAD
=======

                _coppyedFiles.Add(target.FullName + "\\" + fi.Name);

>>>>>>> 6fd095866cc8eb1ffcf63f8e2311b39c6e7dedb0
                fi.CopyTo(Path.Combine(target.ToString(), fi.Name), true);
            }


            // Copy each subdirectory using recursion.
            foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
            {
                DirectoryInfo nextTargetSubDir =
                    target.CreateSubdirectory(diSourceSubDir.Name);
                CopyAll(diSourceSubDir, nextTargetSubDir);
            }

        }

        private void CompareFiles(DirectoryInfo source, DirectoryInfo target)
        {
            using (StreamWriter outputFile = new StreamWriter(_loggerPath, true))
            {

                foreach (FileInfo sourceFile in source.GetFiles())
                {
                    Console.WriteLine("______________________________________________");
                    foreach (FileInfo targetFile in target.GetFiles())
                    {
                        if (sourceFile.Exists && File.Exists(Path.Combine(sourceFile.Name, target.Name)) == false)
                        {
                            outputFile.WriteLine($"{DateTime.Now} Copying: {sourceFile.FullName}");
                            Console.WriteLine($"{DateTime.Now} Copying: {sourceFile.FullName}");

                        }

                        else if (sourceFile.Exists && File.Exists(Path.Combine(sourceFile.Name, target.Name)))
                        {
                            outputFile.WriteLine($"{DateTime.Now} Created: {sourceFile.FullName}");
                            Console.WriteLine($"{DateTime.Now} Created: {sourceFile.FullName}");
                        }
                        else if (targetFile.Exists && File.Exists(Path.Combine(targetFile.Name, source.Name)) == false)
                        {
                            outputFile.WriteLine($"{DateTime.Now} Removed: {targetFile.FullName}");
                            Console.WriteLine($"{DateTime.Now} Removed: {targetFile.FullName}");
                            File.Delete(@"targetFile.FullName");
                        }

                    }

                }

                foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
                {
                    DirectoryInfo nextTargetSubDir =
                        target.CreateSubdirectory(diSourceSubDir.Name);
                    CompareFiles(diSourceSubDir, nextTargetSubDir);
                }

                outputFile.WriteLine("_________________________________________________");
            }
        }

<<<<<<< HEAD
=======

>>>>>>> 6fd095866cc8eb1ffcf63f8e2311b39c6e7dedb0
    }


}
