using System;
using System.IO;

namespace LearnProgramming.FileSystemDemo
{
    class WorkingWithSystemIO
    {
        //static string rootPath = @"C:\Users\kgets\Desktop\Builds\FileSystem";
        //static string newPath = @"C:\Users\kgets\Desktop\Builds\FileSystem\SubFolder A\";
        //static void Main(string[] args)
        //{
        //    string rootPath = @"C:\Temp\Dir";

        //    WorkingWithFiles(rootPath);


        //    Console.ReadLine();
        //}

        #region Move or CopyFiles 
        /// <summary>
        /// The method Moves or copy files
        /// </summary>
        /// <param name="rootPath"></param>
        /// <param name="newPath"></param>
        static void WorkingWithDirectoryGetFiles(string rootPath, string newPath)
        {
            string[] files = Directory.GetFiles(rootPath);

            ////Move files
            foreach (string file in files)
            {
                File.Move(file, $"{newPath}{Path.GetFileName(file)}");
            }

            ////copy files
            //for (int i = 0; i < files.Length; i++)
            //{
            //    File.Copy(files[i], $"{newPath}{i}", true);
            //}

            ////copy files
            //foreach (string file in files)
            //{
            //    File.Copy(file, $"{newPath}{Path.GetFileName(file)}", true);
            //}
        }
        #endregion

        #region Check DirectoryExists (folder path)
        /// <summary>
        /// Check to see if directory Exist
        /// </summary>
        /// <param name="newPath">The path to check if the directory Exists</param>
        static void WorkingWithDirectoryExists(string newPath)
        {
            ////Fourth Examples
            bool dirExist = Directory.Exists(newPath);
            if (dirExist)
            {
                
                Console.WriteLine("dirExist exist");
            }
            else
            {
                
                Console.WriteLine("dirExist not exist");
                Directory.CreateDirectory(newPath);
            }
        }
        #endregion

        #region WorkingWithFiles and Search Partterns or folders
        static void WorkingWithFiles(string rootPath)
        {
            //////Second Examples
            //file Scearch options A,B,C

            ////search pattern is folder Name "*studentData*.*" 
            var files = Directory.GetFiles(rootPath, "*Gra*.*", SearchOption.TopDirectoryOnly);

            ////search by file extention  "*.txt*
            //var files = Directory.GetFiles(rootPath, "*.txt", SearchOption.AllDirectories);

            foreach (var file in files)
            {
                Green();
                Console.WriteLine("Full PAth is: "+file);
                //Console.WriteLine(Path.GetFileName(file));
                //Console.WriteLine(Path.GetDirectoryName(file));
                var info = new FileInfo(file);
                White();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"{Path.GetFileNameWithoutExtension(file)}: ");
                Green();
                White();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write($"{info.Length}bytes\n");
               // Console.Write($"{info.Length / 1024 / 1024} .MB/ .kbytes\n");
            }
        }
        #endregion


        #region First Example WorkingDirectory
        /// <summary>
        /// Get All Directories in parent folder & subfolder
        /// </summary>
        /// <param name="rootPath"></param>
        static void WorkingDirectory(string rootPath)
        {
            /////First Example
            string[] dirs = Directory.GetDirectories(rootPath, "*", SearchOption.AllDirectories);

            //prints all directories
            foreach (string dir in dirs)
            {
                Console.WriteLine(dir);
            }
        }
        #endregion

        #region Console Colours
        private static void White()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void Green()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
        private static void Red()
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        #endregion
    }
}
