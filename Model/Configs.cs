using System.Collections.Generic;
using System.IO;


namespace backup.Model
{
    public class Configs
    {
        private string directoryCurrent = Directory.GetCurrentDirectory() + @"\folders.txt";

        public void SaveFoldersToBackup(string[] folders)
        {
            /*
            //Declaração do método StreamWriter passando o caminho e nome do arquivo que deve ser salvo
            StreamWriter writer = new StreamWriter(directoryCurrent,false);

            foreach (string item in folders)
            {
                //Escrevendo o Arquivo e pulando uma linha
                writer.WriteLine(item);
            }
            //Fechando o arquivo
            writer.Close();
            */
            File.WriteAllLines(directoryCurrent, folders);
        }
  
        public List<string> loadFolders()
        {
            List<string> listFolders = new List<string> { };
            if(!File.Exists(directoryCurrent))
            {
                //declarando a variavel do tipo StreamWriter para 
                //abrir ou criar um arquivo para escrita 
                StreamWriter x;

                //Colocando o caminho fisico e o nome do arquivo a ser criado
                //finalizando com .txt
                string CaminhoNome = directoryCurrent;

                //utilizando o método para criar um arquivo texto
                //e associando o caminho e nome ao metodo
                x = File.CreateText(CaminhoNome);
                x.Close();
            }

            string[] folders = File.ReadAllLines(directoryCurrent) ;
           
           

            if (File.Exists(directoryCurrent))
            {
                foreach (string folder in folders)
                {

                        listFolders.Add(folder);
                    
                }
            }

            return listFolders;
        }



    }
}
