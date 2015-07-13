using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Loja.BO
{
    public class Colecao<T>
    {
        List<T> Lista { get; set; }

        public Colecao()
        {
            Lista = new List<T>();
        }

        public bool Adicionar(T objeto)
        {
            if (Consultar((objeto as Base).Id) == null)
            {
                Lista.Add(objeto);
                return true;
            }
            return false;
        }

        public T Consultar(int id)
        {
            foreach (T item in Lista)
            {
                if ((item as Base).Id == id)
                    return item;
            }
            return default(T);
        }

        public bool Excluir( int id)
        {
            T objeto = Consultar(id);
            if (objeto != null)
            {
                Lista.Remove(objeto);
                return true;
            }
              return false;
        }

        public void Gravar(string diretorio)
        {
            string json = JsonConvert.SerializeObject(Lista, Formatting.Indented);
            StreamWriter escritor = new StreamWriter(diretorio + "\\" + typeof(T).Name + ".json");
            escritor.WriteLine(json);
            escritor.Flush();
            escritor.Close();
        }

        public void Recuperar(string diretorio)
        {
            string arquivo = diretorio + "\\" + typeof(T).Name + ".json"; 

            if (File.Exists(arquivo))
            {
                StreamReader leitor = new StreamReader(arquivo);
                string json = leitor.ReadToEnd();
                Lista = JsonConvert.DeserializeObject<List<T>>(json);
                leitor.Close();
            }
        }
    }
}
