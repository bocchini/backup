using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.IO;

namespace backup.Controller
{
    public class CompressController
    {
        //Pasta usário logado
        static string nameUser = Environment.UserName;
        //private string pathUser = @"c:\Users";
        private List<string> sources;


        public bool CompactMyDocuments(string folderDestination, List<string> folderSource, string nameArchive = "")
        {
            if (!String.IsNullOrEmpty(nameArchive))
            {
                nameUser = nameArchive;
            }

            if (Directory.Exists(folderDestination))
            {
                string destination = folderDestination + @"\" + nameUser + ".zip";
                sources = folderSource;

                if (File.Exists(destination))
                {
                    File.Delete(destination);
                }

                using (ZipFile zip = new ZipFile())
                {
                    // percorre todos os arquivos da lista
                    foreach (string item in sources)
                    {
                        // se o item é um arquivo
                        if (File.Exists(item))
                        {
                            try
                            {
                                // Adiciona o arquivo na pasta raiz dentro do arquivo zip
                                zip.AddFile(item, "");
                            }
                            catch
                            {
                                throw;
                            }
                        }
                        // se o item é uma pasta
                        else if (Directory.Exists(item))
                        {
                            try
                            {
                                // Adiciona a pasta no arquivo zip com o nome da pasta 
                                zip.AddDirectory(item, new DirectoryInfo(item).Name);
                            }
                            catch
                            {

                            }
                        }
                    }
                    // Salva o arquivo zip para o destino
                    try
                    {
                        zip.Save(destination);
                    }
                    catch
                    {
                        throw;
                    }

                }
                return true;
            }
            return false;
            
        }


        public string CreationTime(string folderDestination = "",string archive = "")
        {
            string dt = null;
            if (!String.IsNullOrEmpty(folderDestination) || !String.IsNullOrEmpty(archive))
            {
                if (!String.IsNullOrEmpty(archive))
                {
                    nameUser = archive;
                }
                string destination = folderDestination + @"\" + nameUser + ".zip";


                if (File.Exists(destination))
                {
                    dt = File.GetCreationTime(destination).ToShortDateString();
                }
            }

            return dt;
        }
    }
}



