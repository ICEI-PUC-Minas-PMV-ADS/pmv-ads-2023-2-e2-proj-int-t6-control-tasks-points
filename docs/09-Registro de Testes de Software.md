# Registro de Testes de Software

<span style="color:red">Pré-requisitos: <a href="3-Projeto de Interface.md"> Projeto de Interface</a></span>, <a href="8-Plano de Testes de Software.md"> Plano de Testes de Software</a>

Relatório com as evidências dos testes de software realizados no sistema pela equipe, baseado em um plano de testes pré-definido.

## Testes de Software

### Login

#### 1.1 Caso de Teste: Login bem-sucedido
1. Acesse a página de login.
2. Insira um nome de usuário(e-mail) válido.
3. Insira uma senha válida.
4. Clique no botão "Acessar".
   
**Esperado:** O usuário deve ser redirecionado para a página inicial do sistema (página de tarefas).

**Resultado do teste:** Êxito. O usuário é redirecionado a página principal da aplicação como podemos ver nos prints abaixo.

![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t6-control-tasks-points/assets/122751654/be9ec7c8-f71a-4b70-968f-9e957d16217c)
*Figura 1 - Um usuário e senha válidos e preeviamente cadastrados são inseridos.*
![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t6-control-tasks-points/assets/122751654/7ef5bda2-e166-4093-a0c1-ac1c6e16672d)
*Figura 2 - O usuário é redirecionado para a view de Tarefas.*

#### 1.2 Caso de Teste: Tentativa de login com credenciais inválidas

1. Acesse a página de login.
2. Insira um nome de usuário inválido.
3. Insira uma senha inválida.
4. Clique no botão "Acessar".

**Esperado:** Uma mensagem de erro deve ser exibida indicando que as credenciais são inválidas.

**Resultado do teste:** Êxito. É exibida uma mensagem informando que usuário e/ou senha são inválidos.

![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t6-control-tasks-points/assets/122751654/59ee8c9f-c6ae-49fd-9db0-8164919dd70a)
*Figura 1 - Usuário e senha inválidos são inseridos e uma mensagem de alerta é exibida.*

### Controle de Usuários

#### 2.1 Caso de Teste: Criar um novo usuário

*Obs.: Esta ação só pode ser executada por um usuário que tenha permissão de "admin". Usuários com permissão de "user" não conseguem visualizar a aba usuários nem fazer alterações como criar um novo usuário, editar dados, visualizar ou excluir.*

1. Acesse a aba Usuários na área de navegação (canto superior esquerdo).
2. Clique no botão "Criar novo".
3. Insira o nome do usuário.
4. Informe o e-mail do usuário.
5. Crie uma senha.
6. Selecione a permissão que este usuário terá (user ou admin).
7. Aperte no botão "Cadastrar".

**Esperado:** Cadastro deve ser realizado com sucesso e o novo usuário deve aparecer na view de usuários, mostrando seu nome, e-mail e permissão(mas sem mostrar a senha que está criptografada na base de dados).

**Resultado do teste:** Êxito. O novo usuário foi criado com sucesso como podemos ver nas imagens abaixo.

![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t6-control-tasks-points/assets/122751654/4344c3b4-e8ee-483e-a281-e596c3d4d9e0)
*Figura 1 - Os dados do novo usuário são preenchidos e a ção é concluída clicando sobre o botão "Cadastrar".*
![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t6-control-tasks-points/assets/122751654/f8c0bca3-f529-446a-978e-4e0f3a7dafb1)
*Figura 2 - O usuário que acabou de ser inserido aparece na view.*

#### 2.2 Caso de Teste: Tentativa de criar um novo usuário sem preencher todos os campos obrigatórios

1. Acesse a aba Usuários na área de navegação (canto superior esquerdo).
2. Clique no botão "Criar novo".
3. Deixe de preencher um ou mais campos.
4. Aperte no botão "Cadastrar".

**Esperado:** Uma mensagem informando a necessidade de preecher os campos que ficaram vazios.

**Resultado do teste:** Êxito. São exibidas mensagens informando a necessidade de preencher estes campos.

![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t6-control-tasks-points/assets/122751654/ae9b5451-cd3b-45b0-b3b8-02874e40389d)
*Figura 1 - É exibido um alerta falando sobre a obrigatoriedade de preencher os campos vazios.*

#### 2.3 Caso de Teste: Tentativa de criar um novo usuário informando um e-mail inválido

1. Acesse a aba Usuários na área de navegação (canto superior esquerdo).
2. Clique no botão "Criar novo".
3. Informe o nome do usuário.
4. Insira um e-mail inválido.
5. Crie uma senha.
6. Selecione o nível de permissão.

**Esperado:** Uma mensagem informando a necessidade de informar um e-mail válido.

**Resultado do teste:** Êxito. É exibido uma mensagem de alerta informando que um e-mail válido deve ser informado.

![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t6-control-tasks-points/assets/122751654/9f06dfef-09f2-4fd4-ac09-6b0dfb193f4e)
*Figura 1 - Uma mensagem é exibida informando que se deve informar um e-mail válido.*

#### 2.4 Caso de Teste: Tentativa de criar um novo usuário informando um e-mail já cadastrado

1. Acesse a aba Usuários na área de navegação (canto superior esquerdo).
2. Clique no botão "Criar novo".
3. Informe o nome do usuário.
4. Insira um e-mail já cadastrado.
5. Crie uma senha.
6. 6. Selecione a permissão que o usuário terá.

**Esperado:** Uma mensagem informando que já existe um usuário com este e-mail cadastrado.

**Resultado do teste:** Insucesso. Não é exibido nenhum alerta e é possível cadastrar outro usuário com o mesmo e-mail gerando uma duplicidade.

![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t6-control-tasks-points/assets/122751654/87376efb-8d1a-46cc-96ae-f875ed10fd39)
*Figura 1 - É possível identificar uma falha, pois como vemos na imagem acima é possível utilizar um e-mail já cadastrado gerando duplicidade.*

#### 2.5 Caso de Teste: Atualizar cadastro de um usuário modificando o e-mail 
1. Acesse a aba Usuários.
2. Selecione um usuário.
3. Clique no botão "Editar".
4. Informe o novo e-mail.
5. Informe a senha.

**Esperado:** O cadastro deve ser atualizado e o e-mail atualizado.

**Resultado do teste:** Sucesso. O e-mail foi atualizado. Para este teste modifiquei o e-mail do usuário "Guilherme" que havia cadastrado antes (no caso de teste 2.1). Mudei o email de "guilherme1818@gmail.com" para "guilhermefranklin2003@gmail.com".

![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t6-control-tasks-points/assets/122751654/c791bbd5-ea56-4638-9a71-a4a0ece97f0a)
*Figura 1 - E-mail é atualizado com sucesso já aparecendo na view com a modificação.*

#### 2.6 Caso de Teste: Visualizar detalhes a cerca do cadastro de um usuário 

1. Acesse a aba Usuários.
2. Selecione um usuário.
3. Clique no botão "Visualizar".

**Esperado:** Deve ser possível visualizar os detalhes do usuário como seu nome, email e permissão, contudo a senha não deve ser exibida.

**Resultado do teste:** Sucesso. Conseguimos visualizar o nome, e-mail e permissão do usuário, sem que a senha fique visível.

![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t6-control-tasks-points/assets/122751654/ec58d4da-a249-440b-8378-6577dd699609)
*Figura 1 - Visualização dos detalhes a cerca do usuário.*

#### 2.7 Caso de Teste: Deletar/excluir um usuário

1. Acesse a aba Usuários.
2. Selecione um usuário.
3. Clique no botão "Deletar".
4. Confirme que tem certeza que deseja deletar este usuário e aperte no botão "Deletar".

**Esperado:** Deve ser possível excluir um usuário (somente usuário com permissão de admin pode realizar esta tarefa).

**Resultado do teste:** Sucesso. Conseguimos excluir o usuário. Deletei o usuário "Guilherme" incluído anteriormente.

![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t6-control-tasks-points/assets/122751654/31c89724-68c3-4710-9f47-05950aa23bf8)
*Figura 1 - Exibição da view delete onde o usuário confirma seu interesse em apagar o registro do usuário.*
![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t6-control-tasks-points/assets/122751654/e338965e-2c2b-4442-9607-d74d2391ccab)
*Figura 2 - O cadastro do usuário foi excluído e não aparece mais na view de usuários(como era esperado)*.

### Lista de Tarefas

#### 3.1 Caso de Teste: Criar uma nova tarefa

*Obs.: Essa ação de criar uma nova tarefa só pode ser executada por um usuário com permissão de "admin".*

1. Acesse a view de Tarefas.
2. Clique no botão "Criar nova".
3. Preencha todos os campos.
4. Aperte no botão "Adicionar".

**Esperado:** O cadastro deve ser realizado com êxito e nova tarefa deve ser exibida na view.

**Resultado do teste:** Sucesso. A tarefa foi criada sem nenhuma intercorrência.

![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t6-control-tasks-points/assets/122751654/8d3dc8cb-9e8f-405b-90a5-d0aab93d40ad)
*Figura 1 - Todos os campos são preenchidos e após clicar no botão adicionar a nova tarefa é criada.*
![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t6-control-tasks-points/assets/122751654/5c7e4cec-cf38-45f8-a74e-65511f677618)
*Figura 2 - A tarefa récem-criada é exibida na view.*


#### 3.2 Caso de Teste: Tentativa de adicionar uma tarefa sem preencher um ou mais campos
1. Acesse a view de Tarefas.
2. Clique no botão "Criar nova".
3. Deixe de preencher um ou mais campos.
4. Aperte no botão "Adicionar".

**Esperado:** Mensagem informando a necessidade de preencher os campos vazios.

**Resultado do teste:** Sucesso. Uma mensagem de alerta é exibida.

![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t6-control-tasks-points/assets/122751654/1efdfccb-76cc-4a0d-a6dc-1c686e01a283)
*Figura 1 - Mensagens de alerta são mostradas.*

#### 3.3 Caso de Teste: Tentativa de criar/excluir uma tarefa com usuário sem permissão de administrador

1. Faça login com um usuário comum (sem permissão de adminstrador).
2. Após a view tarefas ser carregada clique em "Criar nova" e/ou selecione uma tarefa e tente exluí-la.

**Esperado:** Usuário seja redirecionado para página de "Acesso Negado".

**Resultado do teste:** Sucesso. Usuário é informado que não possui acesso para realizar estas operações.

![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t6-control-tasks-points/assets/122751654/dc658ecc-6836-440f-85d8-49ad1e530a90)
*Figura 1 - Tela de "Acesso Negado".*

#### 3.3 Caso de Teste: Tentativa de alterar outros dados além do status da tarefa por usuário comum

1. Faça login com um usuário comum (sem permissão de "admin").
2. Selecione um usuário comum e clique no botão "Editar".
3. Tente alterar os dados contidos em outros campos(além do status).

**Esperado:** O usuário deve conseguir alterar apenas o status da tarefa e não modificar, por exemplo, o responsável por aquela tarefa nem a quantidade de coins ganha por ela. Todos os campos, exceto o de status, devem estar desabilitados.

**Resultado do teste:** Sucesso. O usuário consegue alterar apenas o status da tarefa, demais campos estão desabilitados.

![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t6-control-tasks-points/assets/122751654/41db099a-5dc6-45a6-b75e-066f23fd498e)
*Figura 1 - Apenas o campo status é editável.*




