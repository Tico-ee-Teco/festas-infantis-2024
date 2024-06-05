using eAgenda.ConsoleApp.Compartilhado;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace FestasInfantis.WinApp.Compartilhado
{
    public class RepositorioBaseEmArquivo<T> where T : EntidadeBase
    {
        protected List<T> registros = new List<T>();

        protected int contadorId = 1;

        private string caminho = string.Empty;

        public RepositorioBaseEmArquivo(string nomeArquivo)
        {
            caminho = $"C:\\temp\\fetasInfantis\\{nomeArquivo}";

            registros = DeserializarRegistros();

            if (registros.Count > 0)
                contadorId = registros.Max(r => r.Id) + 1;
        }

        public void Cadastrar(T novoRegistro)
        {
            novoRegistro.Id = contadorId++;

            registros.Add(novoRegistro);

            SerializarRegistros();
        }

        public bool Editar(int id, T novaEntidade)
        {
            T registro = SelecionarPorId(id);

            if (registro == null)
                return false;

            registro.AtualizarRegistro(novaEntidade);

            SerializarRegistros();

            return true;
        }

        public bool Excluir(int id)
        {
            bool conseguiuExcluir = registros.Remove(SelecionarPorId(id));

            if(!conseguiuExcluir)
                return false;

            SerializarRegistros() ;

            return true;
        }

        public List<T> SelecionarTodos()
        {
            return registros;
        }

        public T SelecionarPorId(int id)
        {
            return registros.Find(x => x.Id == id);
        }

        public bool Existe(int id)
        {
            return registros.Any(x => x.Id == id);
        }

        public void CadastrarVarios(List<T> registrosAdicionados)
        {
            foreach (T registro in registrosAdicionados)
            {
                registro.Id = contadorId++;
                registros.Add(registro);
            }
        }

        protected void SerializarRegistros()
        {
            FileInfo arquivos = new FileInfo(caminho);

            arquivos.Directory.Create();

            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true,
                ReferenceHandler = ReferenceHandler.Preserve
            };

            byte[] registrosEmBytes = JsonSerializer.SerializeToUtf8Bytes(registros, options);

            File.WriteAllBytes(caminho, registrosEmBytes);
        } 
        
        protected List<T> DeserializarRegistros()
        {
            FileInfo arquivo = new FileInfo(caminho);

            if(!arquivo.Exists)
                return new List<T>();

            byte[] registrosEmBytes = File.ReadAllBytes(caminho);

            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                ReferenceHandler = ReferenceHandler.Preserve
            };

            List<T> registros = JsonSerializer.Deserialize<List<T>>(registrosEmBytes, options);

            return registros;

        }
    }
}
