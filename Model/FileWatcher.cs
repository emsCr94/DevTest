using System;
using System.IO;
using System.Linq;
using System.Text;
using OfficeOpenXml;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace DevTest.Model
{
    class FileWatcher
    {

        /*  
            This class contains the logic to look up for files move files
            manage file watcher settings and also create folders and validate
            paths.
        */

        private string _defaultDirectoryPath;  

        public string DefaultDirectoryPath    
        {
            get => _defaultDirectoryPath;
            set => _defaultDirectoryPath = value;
        }

        private string _masterFileName; 
        public string MasterFileName   
        {
            get => _masterFileName;
            set => _masterFileName = value;
        }

        private string _state;  
        public string State    
        {
            get => _state;
            set => _state = value;
        }

        public FileWatcher()
        {
            DefaultDirectoryPath = @"C:\Users\Spider-Ban\Documents\";
            MasterFileName = @"\Master.xlsx";
        }

        /// <summary>
        ///    This method validates the given path
        ///    
        ///
        /// <Parameters>
        ///    string directoryPath -> the path tha came from the controller
        ///     
        /// </Parameters>
        /// </summary>
        public void WatchFiles(string directoryPath)
        {           
            if (Directory.Exists(directoryPath))
            {
                ProcessFiles(directoryPath);
            }        
        }

        /// <summary>
        ///    This method get all the files from directory path and process each one
        ///    
        ///
        /// <Parameters>
        ///    string directoryPath -> the path tha came from the controller
        ///     
        /// </Parameters>
        /// </summary>
        private void ProcessFiles(string directoryPath)
        {           
            DirectoryInfo directoryInfo = new DirectoryInfo(directoryPath);
            foreach (var fileInfo in directoryInfo.GetFiles())
                ProcessFile(fileInfo);
        }

        /// <summary>
        ///    This method copy and moves the a file to a especific path given 
        ///    
        ///
        /// <Parameters>
        ///    FileInfo fileInfo -> FileInfo class object
        ///    string folder -> the path tha came from the controller
        /// </Parameters>
        /// </summary>
        private void MoveFile(FileInfo fileInfo, string folder)
        {
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);

            }

            if (!File.Exists(folder + fileInfo.Name))
            {
                File.Copy(fileInfo.FullName, folder + fileInfo.Name);
                File.Delete(fileInfo.FullName);
            }

        }

        /// <summary>
        ///    This method process .xlsx file and move it to the process folder, also
        ///    take charge of avoiding not excel files and moving them to the Not applicable folder
        ///    main class method WatchFiles will execute the logic to look up for files
        ///
        /// <Parameters>
        ///     FileInfo fileInfo -> FileInfo class object 
        /// </Parameters>
        /// </summary>
        private void ProcessFile(FileInfo fileInfo) 
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            string fileExtension = fileInfo.Extension;
            string filePath = fileInfo.FullName;
            string fileName = fileInfo.Name;

            if (fileExtension == ".xlsx" && fileName != "Master.xlsx")
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                try
                {
                    using (ExcelPackage xlPackage = new ExcelPackage(new FileInfo(@filePath)))
                    {
                        if (!File.Exists(fileInfo.DirectoryName + @"\Processed\" + fileName))
                        {
                            using (ExcelPackage xlPackageAux = new ExcelPackage(new FileInfo(@fileInfo.DirectoryName + MasterFileName)))
                            {
                                var fileWorkSheets = xlPackage.Workbook.Worksheets;
                                foreach (ExcelWorksheet sheet in fileWorkSheets)
                                {
                                    xlPackageAux.Workbook.Worksheets.Add(fileName + "-" + sheet.Name, sheet);
                                    xlPackageAux.Save();
                                }
                            }
                        }

                    }
                    MoveFile(fileInfo, fileInfo.DirectoryName + @"\Processed\");
                }
                catch (System.IO.IOException ex)
                {
                    Console.WriteLine(ex);
                }
              
                
            }
            else {
                if (fileName != "Master.xlsx") 
                {
                    MoveFile(fileInfo, fileInfo.DirectoryName + @"\Not applicable\");
                }
            }
        }
    }
}
