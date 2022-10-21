# Reebok-Asp.Net-C#


O objetivo deste projeto é o desenvolvimento de uma aplicação em ambiente Web, para a marca de ténis REEBOK, utilizando as seguintes tecnologias:
• ASPX
• CSHARP
• XML
• XSLT
• HTML

O site deverá ser composto no mínimo por 5 páginas:
• Login.aspx
o Esta página permitirá ao utilizador autenticar-se com o utilizador “admin” e a palavra-passe “123”. Utilizar validadores e mensagens de erro caso o utilizador/palavra-passe esteja errado. Após autenticação o utilizador deverá ser redirecionado para a página “App.aspx”
• App.aspx

o Esta página apresenta a mensagem de bem-vindo e uma outra mensagem com a data e horas atuais.
o Deverá apresentar as últimas 5, 10, 25 ou todas as notícias sobre desporto de um qualquer site que disponibilize RSS. O utilizador deverá ter a possibilidade de poder escolher o nº de notícias que pretende ver através de uma dropdownlist.
o Apresenta também um botão de redireccionamento para a página “Inscricao.aspx”
• Inscricao.aspx
o Esta página apresenta a mensagem de bem-vindo e uma outra mensagem com a data e horas atuais.
o Deverá conter um formulário com os campos com os respetivos validadores:
▪ Nome – Textbox – campo obrigatório
▪ Morada – Textbox multiline – campo obrigatório, garantir que a Morada tem escrito uma destas opções: “Rua”, “Avenida”, “Av”, “Praceta”, “Pc”, “Travessa”, “Tv”.
▪ Regime – DropDownlist – Previamente carregada com as opções “Diurno / Noturno”
▪ Curso – DropDownlist – Apresenta os cursos em função da opção selecionada na DropDownlist “Regime”
▪ Género – 2 RadioButtons – apenas pode estar selecionado um de cada vez
▪ Hobbies – 6 Checkboxs – apenas pode selecionar no máximo 3
▪ Email – Textbox – Campo obrigatório e o email tem de ser válido
▪ Código-postal – Textbox – Campo obrigatório e tem de ser válido (0000-000)
▪ Palavra-Passe – Textbox – Campo obrigatório e tem de ter uma palavra-passe forte
o Esta página terá um botão de “submeter” e outro de “limpar”. O botão “submeter” redireciona para a página “Dados.aspx” caso os validadores tenham sido “ultrapassados”
• Dados.aspx
o Esta página apresenta a mensagem de bem-vindo e uma outra mensagem com a data e horas atuais.
o Deverá apresentar todos os dados que o utilizador preencheu na página anterior e tem os seguintes botões:
▪ XML – exporta todo o conteúdo para XML
▪ EXCEL – exporta todo o conteúdo para EXCEL
▪ WORD – exporta todo o conteúdo para WORD
▪ PDF – exporta todo o conteúdo para um PDF utilizando um template
• Mostra o PDF gerado no ecran e envia-o por email para o endereço que o utilizador preencheu
o Deverá conter um botão de “Ver loja” que redireciona para a página “Loja.aspx”
• Loja.aspx
o Esta página apresenta a mensagem de bem-vindo e uma outra mensagem com a data e horas atuais.
o Deverá apresentar uma lista de ténis carregada a partir de um ficheiro de XML com os seguintes campos: Modelo, peso, preço, género (homem, senhora ou unissexo) e foto
o Deverá ser possível filtrar os ténis por género
NOTAS:
• Deverão existir páginas personalizadas para os erros e para o “Page not found”
• Garantidamente quem não estiver “logado”, não poderá aceder às páginas “App.aspx, Inscricao.aspx, Dados.aspx e Loja.aspx”
• Deverá ser utilizado um template gráfico de boa qualidade e responsive
• O menu do template a utilizar deverá ser “alimentado” através de um ficheiro XML
• Sempre que possível devem ser utilizados UpdatePanels
