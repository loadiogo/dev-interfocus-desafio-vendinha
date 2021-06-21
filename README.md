# **Vendinha**

## **Intruções**

### **Utilizando template Github**

Caso queira utilizar o template, siga os passos abaixo.

* Clique no botão "Use this template":
  
![](https://ias-release-note.s3.amazonaws.com/ImagemUpload/c9e84435-274a-44e8-8882-1847e6d2d236template-github1.png)

* Preencha um nome para o repositório e clique em "Create repository from template":

![](https://ias-release-note.s3.amazonaws.com/ImagemUpload/f21de1c0-5dd2-4134-972a-8dcd07742a46template-github2.png)


### **Rodando projeto backend**

Para executar o projeto, abra o terminal e execute os comandos a seguir:

* *Abre a pasta do projeto*

    ``cd .\backend\TemplateApi``

* *Executa o projeto*

    ``dotnet run .\TemplateApi.csproj``

    
* *A aplicação estará rodando no endereço e porta:*

    ``http://localhost:5000``


### **Rodando projeto frontend**

Para executar o projeto, abra o terminal e execute os comandos a seguir:

* *Abre a pasta do projeto*

    ``cd .\frontend``

* *Instala dependencias*

    ``npm install``

* *Executa o projeto com o live-server*

    ``npm start``

* *A aplicação estará rodando no endereço e porta:*

    ``http://127.0.0.1:8080``

## **Cenário**

Uma vendinha precisa informatizar o controle de dívidas de seus clientes (dívidas penduradas) para facilitar a busca e o cadastro desses dados que antes eram feitas por papel. O cliente chega na loja, faz a compra e pede para o atendente pendurar para que seja acertado no final do mês.

Pensando nisso, é necessário criar um sistema simples de cadastro para que o dono da venda consiga controlar as dívidas de seus clientes.

### **Requisitos**

- O sistema deve permitir o cadastro, recuperação, atualização e exclusão de clientes ¹
- Os dados necessários para se criar a conta são:
    - Nome completo *
    - CPF *
      - Validar quantidade de caracteres
    - Descricao
      - O que comprou?
    - Situacao
      - Esta pago?
    - Valor divida *

    \*: campos obrigatórios 
- Deverá haver uma tela que liste as dividas, onde haverão as validações abaixo:        
    - Saldo devedor total deverá ser calculado de acordo com a lista de dividas com situação "false"(pendente)
    - Deve ser possível marcar uma conta como paga
    - Não deve ser possível incluir novas dividas para um mesmo cpf que possua dividas em aberto(retornar mensagem)
    - As dívidas deverão ser ordenadas por valor em ordem decrescente

¹: a persistência pode ser feita em arquivo ou em memória, não é mandatório o uso de qualquer banco de dados.

## **O projeto**
Você fará uma API que possibilidade o CRUD de dívidas com dados no formato JSON, além de desenvolver uma interface para que o atendente possa fazer essas operações.

### **Requisitos**
- A API deve ser desenvolvida preferencialmente em Asp.NET Core com a linguagem C#, quaisquer bibliotecas ou frameworks estão permitidos.
- A API deve aceitar e devolver dados no formato JSON
- A interface deve ser desenvolvida com HTML, CSS e Javascript, quaisquer bibliotecas ou frameworks estão permitidos.
- A interface deve possuir uma listagem que possibilite o cadastro, alteração(marcar como pago) e exclusão da dívida
- O cadastro deve ser validado e caso haja algum erro de validação (um campo obrigatório não foi preenchido, por exemplo), você deve mostrar o erro na tela para que o atendente possa consertar.
- O projeto deve estar salvo num repositório git **público** da sua escolha (BitBucket, GitHub, GitLab etc)
- README.md explicando o motivo do uso das bibliotecas escolhidas (caso se aplique)
- README.md deve conter instruções de como executar a aplicação

### **Avaliação**

Serão avaliados nesse projeto o seu domínio nas tecnologias .NET e Javascript, além da forma que você levou para resolver o problema.

#### **Pontos Essenciais**
- Linguagem C#
- Linguagem Javascript
- Programação orientada a objetos
- Construção de API
- Apresentação de informação
- Domínio de Git


#### **Pontos Adicionais**
- Uso de bibliotecas e frameworks Javascript como React ou Angular
- Uso de banco de dados relacional
- Uso de ORM
- REST
- Testes Unitários
- Documentação da API com postman ou swagger


**OBS**: Caso não consiga finalizar, envie até onde você conseguiu, é importante sabermos como você resolveu, ainda que parcialmente, a proposta do projeto.

## Resultado final

![](https://ias-release-note.s3.amazonaws.com/ImagemUpload/e77e833a-787e-462a-8bcc-628b9f2b9250video_vendinha_demo.mov)
