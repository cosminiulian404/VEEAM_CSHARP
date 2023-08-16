namespace VEEAM1
{
    public class CopyDir
    {
        private static DirectoryInfo? _source;
        private static DirectoryInfo? _target;
        public static List<string> _coppyedFiles = new List<string>();
        public static List<string> _removedFiles = new List<string>();

        public CopyDir(string source, string target)
        {
            _source = new DirectoryInfo(source);
            _target = new DirectoryInfo(target);
            CopyAll(_source, _target);

        }

        public List<string> CoppyedFiles
        { get { return _coppyedFiles; } }


        public void CopyAll(DirectoryInfo source, DirectoryInfo target)
        {

            if (source.FullName.ToLower() == target.FullName.ToLower())
            {
                return;
            }


           

            // Check if the target directory exists, if not, create it.
            if (Directory.Exists(target.FullName) == false)
            {
                Directory.CreateDirectory(target.FullName);
            }

            // Copy each file into it's new directory.
            foreach (FileInfo fi in source.GetFiles())
            {

                _coppyedFiles.Add(target.FullName + "\\" + fi.Name);

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

        public void CompareFiles()
        {
           

            foreach (FileInfo sourceFi in _source.GetFiles())
            {
                foreach (FileInfo targetFi in _target.GetFiles())
                {
                    if (sourceFi == targetFi)
                        Console.WriteLine($"Copying {sourceFi}");

                }
            }

        }


    }
}