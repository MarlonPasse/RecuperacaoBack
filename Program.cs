using RecuperacaoBack.Classes;

Console.Clear();

Console.WriteLine(@"Selecione uma opcao
    1 - Inserir
    2 - Ler
    0 - Sair
");

PessoaJuridica funcoesPJ = new PessoaJuridica();

switch(Console.ReadLine()) 
{
    case "1":
        PessoaJuridica pj = new PessoaJuridica();

        Console.WriteLine("Informe o nome da pessoa juridica");
        pj.Nome = Console.ReadLine();

        Console.WriteLine("Informe o rendimento da pessoa juridica");
        pj.Rendimento = float.Parse(Console.ReadLine()!);

        Console.WriteLine("Informe o cnpj da pessoa juridica");
        pj.CNPJ = Console.ReadLine();

        funcoesPJ.Inserir(pj);
        break;
    case "2":
        Console.WriteLine("Insira o nome da pessoa juridica");
        string nome = Console.ReadLine()!;

        PessoaJuridica pjBuscado = funcoesPJ.Ler(nome);

        Console.WriteLine(@$"
Informacoes da pessoa juridica:
    Nome: {pjBuscado.Nome}
    Rendimento: {pjBuscado.Rendimento}
    CNPJ: {pjBuscado.CNPJ}
        ");

        break;
    case "0":
        break;
}