using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class Agenda {

    public string Proprietario { get; set; }
    private readonly List<Contato> contatos;

    public Agenda(string proprietario) {
        Proprietario = proprietario;
        contatos = new List<Contato>();
    }

    public bool AdicionarContato(Contato contato) {
        if (contatos.Any(c => c.Nome == contato.Nome)) {
            Console.WriteLine("Contato com esse nome ja está na agenda.\n");
            return false;
        }
        contatos.Add(contato);
        return true;
    
    }

    public void ListarContatos() {

        Console.WriteLine($"Agenda de: {Proprietario}");
        Console.WriteLine($"\nContatos: ");
        foreach (var c in contatos) {
            Console.WriteLine($" -  {c.Nome} | {c.Telefone}");
        }
        Console.WriteLine($"\nTotal de Contatos: {QuantidadeContatos}");
    }

    public int QuantidadeContatos {
        get {  return contatos.Count; }
    }
}


