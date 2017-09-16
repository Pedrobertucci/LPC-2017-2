<h1>Criar um CRUD de pessoa</h1>

* crie um novo projeto mvc com o nome **crud_people**

<h2> Model</h2>

- criar o model Person.cs com id e nome e construtor
- criar o repositorio PersonRepository com os métodos de crud: *Create, Delete, Update, GetById, GetAll
- criar uma public static list para "simular o db de people". Importar o System.Collections.Generic;
- implementar **GetAll()* return people;
- Criar um método fill para preencher inicialmente a lista com dados fixos
<br><br>

---

<h2>Controller</h2>

 instalar o plugin asp.net snippets
- crie uma nova classe com o nome PersonController e digite HomeController
- instanciar o repositorio de Person
- implementar o GetAll para a Action Index
- passar para a view a lista people
<br><br>

---

<h2>View</h2>

- criar uma pasta Person (a pasta deve ter o mesmo nome do controller, e para cada Action, uma cshtml);
- Criar a *Index.cshtml*
- Tipar a view com IEnumerable<Person>: 
    > @model IEnumerable<crud_w_mvc_ram.Models.Person>
- Desenvolver uma tabela para mostrar a lista de Person
- utilizar foreach para percorrer a lista people e mostrar os dados.


<h3>bibliografia</h3>

- [Documentação sobre VIEWS E RAZOR](https://docs.microsoft.com/pt-br/aspnet/core/mvc/views/razor)
- [Documentação sobre CONTROLLERS](https://docs.microsoft.com/pt-br/aspnet/core/mvc/controllers/actions)
- [Documentação sobre MODELS](https://docs.microsoft.com/pt-br/aspnet/core/mvc/models)