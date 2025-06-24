Desenvolvi um sistema de agenda pessoal. Cada agenda pode conter vários contatos, mas você quero garantir que:

A lista de contatos não possa ser acessada nem modificada diretamente por fora da classe.
Nenhum contato com o mesmo nome seja adicionado duas vezes.
O sistema informe se o contato foi adicionado ou recusado, para que outras partes possam reagir.

Então para isso, criei:

- Uma classe Contato, com:
    - Propriedades públicas Nome e Telefone.
  
- Uma classe Agenda, com:
    - Propriedade pública Proprietario.
   -  Um campo privado e readonly contatos (do tipo List<Contato>).
   -  Um método público bool AdicionarContato(Contato contato), que verifica se o nome já existe.
   -  Um método ListarContatos(), que imprime os contatos.
   -  Uma propriedade pública somente leitura QuantidadeContatos.
