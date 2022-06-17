

# Classe

Toda classe do C# é uma subclasse da classe Object
   Object possui os seguintes métodos:
      GetType: retorna o tipo do objeto
      Equals: compara se o objeto é igual a outro
      GetHashCode: retorna um código hash do objeto
      ToString: converte o objeto para string

# Membros de classe: atributos(dados/ campos), métodos(funções/ operações)

# Recursos: Construtores, Sobrecarga, Encapsulamento, Herança, Polimorfismo.

# Exemplos

# Entidadas: Produto, Cliente
# Serviços: ProdutoService, ClienteService
# Controladores: ProdutoController, ClienteController
# Utilitários: Calculadora
# Outros: Views, repositórios, gerenciadores

# Membros estáticos. 
   São membros que fazem sentido independetemente de objetos. Não precisam de objeto para serem
   chamados. São chamados a partir do próprio nome da class. Ex.: Math.Sqrt(bouble).

   Obs.: Uma classe que possui somente membros estáticos, pode ser uma classe estática. Se a classe for estática não poderá ser instanciada.
         Se a classe for estática só poderá ser declarado métodos do tipo estático. Do contrário, será necessário instanciar uma classe.   
   
# Construtor
   Obs.: Executa no momento da instanciação do objeto. 
         Sobrecarga é quando criamos um construtor com carga nos atributos.

# Encapsulamento
   Obs.: Consiste em esconder detalhes de implementação de um componente, expondo apenas operações
         seguras. O objeto deve sempre estar em um estado consistente e a classe deve garantir isso.

# Ordem sugerida para implementação de membros
   > Atributos privados
   > Propriedades autoimplementadas
   > Construtores
   > Propriedades customizadas
   > Outros métodos da classe

# Modificadores de acesso
   > public
   > protected internal
   > internal
   > protected
   > private protected
   > private

# Reference
https://docs.microsoft.com/pt-br/dotnet/csharp/
