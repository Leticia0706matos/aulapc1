Console.WriteLine("-----------------------------");
Console.WriteLine("---- Carrinho de Compras ----");
Console.WriteLine("-----------------------------");

Produto produtoUm = new Produto();

produtoUm.Preco = 40;
produtoUm.Descricao = "Camisa P";
produtoUm.Codigo = 1;

Produto produtoDois = new Produto();

produtoDois.Preco = 45;
produtoDois.Descricao = "Camisa M";
produtoDois.Codigo = 2;

List<Produto> produtosDisponiveis = new List<Produto>();
produtosDisponiveis.Add(produtoUm);
produtosDisponiveis.Add(produtoDois);

ExibirListaDeProdutos(produtosDisponiveis);

void ExibirListaDeProdutos(List<Produto> produtos)
{
    Console.WriteLine($"| Código | Descrição   | Valor unitário |");
    Console.WriteLine($"| ------ | ----------- | -------------- |");

    produtos.ForEach(produto => {
        Console.WriteLine($"| {produto.Codigo}      | {produto.Descricao}    | {produto.Preco:C2}       |");    
    });

    // for (int i = 0; i < produtosDisponiveis.Count; i++)
    // {
    //     Produto produto = produtosDisponiveis[i];
    //     Console.WriteLine($"| {produto.Codigo}   | {produto.Descricao}  | {produto.Preco:C2} |");    
    // }

    // foreach(var produto in produtos)
    // {
    //     Console.WriteLine($"| {produto.Codigo}   | {produto.Descricao}  | {produto.Preco:C2} |");    
    // } 
}
