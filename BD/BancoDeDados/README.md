Fundamentos de Banco de Dados – Modelagem Conceitual

PROFESSORA ORIENTADORA: Kátia Milani Lara Bossi

INTEGRANTES DO GRUPO: 

Enzo Lemos Souza do Nascimento 

Vitor de Moura Lima 

Felipe Okada Corleto 

Felipe Rodrigues dos Santos Farias


Este documento foi desenvolvido para a Messier Data & Creative, empresa de desenvolvimento de jogos e experiências interativas.

Qual o objetivo da modelagem?
A modelagem conceitual (DER) apresentada neste documento tem como objetivo:
1.	Estruturar os dados necessários para o funcionamento do sistema de gestão de assinaturas de jogos educacionais.
2.	Garantir a integridade das informações, evitando inconsistências como uma escola ter dois pacotes ativos ou um IP pertencer a duas escolas diferentes.
3.	Facilitar o desenvolvimento do sistema, fornecendo uma base clara para a implementação do banco de dados relacional.
4.	Permitir o controle de acesso por escola, pacote contratado, IP autorizado e limite mensal de acessos.
5.	Gerar relatórios gerenciais sobre consumo de acessos, escolas inadimplentes e pacotes mais contratados.
   
<img width="1076" height="552" alt="image" src="https://github.com/user-attachments/assets/0c4b8069-faf0-4f74-92da-b9b471711a92" />

<img width="1050" height="598" alt="image" src="https://github.com/user-attachments/assets/0d7a74a8-1cdb-4898-91b8-26da2b61c884" />

1. ESCOLA ⟷ PACOTE
Uma escola só pode ter um pacote ativo por vez. Se a escola quiser trocar de pacote, o pacote antigo é desativado e o novo é associado. Um mesmo pacote pode ser contratado por várias escolas, mas na modelagem relacional isso é representado pela chave estrangeira na tabela ESCOLA.
________________________________________
2. PACOTE ⟷ GAME (via PACOTE_GAMES)
Um pacote pode conter muitos jogos. Por exemplo, o pacote Premium contém 15 jogos. Um mesmo jogo pode fazer parte de vários pacotes. Por exemplo, o jogo 'Matemática Divertida' pode estar tanto no pacote Básico quanto no Premium. Para representar isso no banco de dados, criamos uma tabela intermediária chamada PACOTE_GAMES.
________________________________________
3. ESCOLA ⟷ IP_AUTORIZADO
Uma escola pode autorizar vários endereços de IP para acessar os jogos. Por exemplo, uma escola pode autorizar o IP do laboratório 1, do laboratório 2 e da secretaria. Por outro lado, cada IP autorizado pertence exclusivamente a uma única escola – o mesmo IP não pode ser usado por duas escolas diferentes.
________________________________________
4. ESCOLA ⟷ LOG_ACESSO
Cada vez que uma escola tenta acessar um jogo (com sucesso ou não), um novo log é registrado. Portanto, uma escola pode ter milhares de logs ao longo do mês. Cada log, no entanto, está associado a uma única escola – não é possível um log pertencer a duas escolas diferentes.
________________________________________
5. GAME ⟷ LOG_ACESSO
Um jogo pode ser acessado muitas vezes por diferentes escolas ao longo do tempo, gerando vários logs. Por exemplo, o jogo 'Matemática Divertida' pode ter 500 logs registrados em um mês. Cada log, no entanto, refere-se a um único jogo – um log não pode registrar dois jogos ao mesmo tempo.



