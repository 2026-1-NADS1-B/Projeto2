```sh
Utilize o site <https://www.toptal.com/developers/gitignore> para gerar seu arquivo gitignore e apague este campo.

Vide tutoriais do PI.
```

# FECAP - Fundação de Comércio Álvares Penteado

<p align="center">
<a href= "https://www.fecap.br/"><img src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRhZPrRa89Kma0ZZogxm0pi-tCn_TLKeHGVxywp-LXAFGR3B1DPouAJYHgKZGV0XTEf4AE&usqp=CAU" alt="FECAP - Fundação de Comércio Álvares Penteado" border="0"></a>
</p>

# Nome do Projeto 
Sistema Messier – Gestão de Assinaturas de Jogos Educacionais

## Nome do Grupo: Grupo 2

## Integrantes: 

| Nome                                  | RA (se houver) |
|---------------------------------------|----------------|
| Enzo Lemos Souza do Nascimento        | — 26028677     |
| Vitor de Moura Lima                   | — 23011238     |
| Felipe Okada Corleto                  | — 26028544     |
| Felipe Rodrigues dos Santos Farias    | — 26029082     |



## Professores Orientadores: Francisco de Souza Escobar, Renata Muniz, Marcelo Amorim, Katia Bossi, Robson Cardoso, Daniel da Cunha.

## Descrição


O projeto consiste no desenvolvimento de um aplicativo desktop para gestão de assinaturas de jogos educacionais, criado para atender a uma demanda da empresa Messier Data & Creative. O sistema tem como foco gerenciar o acesso de escolas de ensino fundamental e médio a uma plataforma de jogos digitais, permitindo o controle de pacotes de jogos, limites de acessos mensais, IPs autorizados e a geração de relatórios de consumo.

As funcionalidades principais dividem-se em um módulo administrativo para cadastros (CRUD) de jogos, pacotes e escolas, e um módulo escola para autenticação de login com validação de pacote ativo e verificação de IP de origem. O controle de acesso é realizado via registro automático de logs, garantindo o bloqueio imediato caso o limite do pacote contratado seja atingido.

Desenvolvido com a linguagem C# (.NET) e interface em WinForms ou WPF, o projeto utiliza SQLite para persistência de dados e Git/GitHub para controle de versão. A solução adota uma abordagem interdisciplinar, integrando conceitos de modelagem de banco de dados, segmentação de redes, lógica de proposição da matemática discreta e estruturas de decisão e repetição de algoritmos.


## 🛠 Estrutura de pastas

```text
PI-Messier-1ADS/
│
├── README.md                          # ← Você está aqui
│
├── src
└── DOCUMENTOS/
    │
    └── Entrega 1/
        │
        ├── Redes/
        │   └── SimulacaoIP/           
        │     
        │
        ├── BancoDeDados/
        │   └── README.md              # Modelagem conceitual (DER)
        │
        ├── Algoritmos/
        │   └── Entrega1_Algoritmos.pdf   # Estruturas sequencial, decisão, repetição
        │
        ├── ModelagemSoftware/
        │   └── DocumentoAbertura.pdf     # Requisitos funcionais e não funcionais
        │
        └── MatematicaDiscreta/
            └── RegrasLogica.pdf          # Lógica proposicional, tabela-verdade, cenários.

```

## 🛠 Instalação

## 🔄 Fluxo Resumido do Sistema (Módulo Escola)

1. **Login** – a escola se autentica; o sistema verifica se o pacote está ativo e se o IP de origem é autorizado.
2. **Catálogo** – exibe apenas os jogos disponíveis no pacote da escola.
3. **Acesso** – a escola simula o acesso a um jogo; o sistema registra o consumo do mês e bloqueia caso o limite seja atingido.

---

## 📦 Principais Funcionalidades (Requisitos Funcionais)

- **CRUD de Games** (nome, descrição, tema, faixa etária, ativo/inativo)
- **CRUD de Pacotes** (nome, lista de games, limite de acessos/mês, preço)
- **CRUD de Escolas** (dados, pacote ativo, lista de IPs autorizados)
- **Login** com validação de pacote ativo + IP de origem
- **Catálogo dinâmico** baseado no pacote da escola
- **Registro de acesso** (log com data/hora, escola, game, IP, resultado)
- **Bloqueio automático** ao atingir o limite mensal do pacote
- **Relatórios**:
  - Acessos por escola e período
  - Escolas, pacotes, limite mensal, consumo e percentual de uso

---

## 🛠️ Tecnologias Sugeridas

| Camada            | Tecnologia                                         |
|-------------------|----------------------------------------------------|
| Linguagem         | C# (.NET 8 / .NET 9)                               |
| Interface Desktop | WinForms (recomendado) ou WPF                      |
| Banco de Dados    | SQLite                                             |
| Acesso a Dados    | ADO.NET ou Entity Framework Core                   |
| Versionamento     | Git + GitHub                                       |
| Modelagem         | Draw.io, StarUML, Lucidchart                       |

---



## 💻 Configuração para Desenvolvimento

Descreva como instalar todas as dependências para desenvolvimento e como rodar um test-suite automatizado de algum tipo. Se necessário, faça isso para múltiplas plataformas.

Para abrir este projeto você necessita das seguintes ferramentas:

-<a href="https://godotengine.org/download">GODOT</a>

```sh
make install
npm test
Coloque código do prompt de comnando se for necessário
```

## 📋 Licença/License



## 🎓 Entrega Disciplina 
| Entrega | Valor | Data limite            | Descrição resumida                                          |
|---------|-------|------------------------|-------------------------------------------------------------|
| **E1**  | 3,0   | 13/04/2026 – 23:59:56  | Modelagem conceitual BD, simulação IP (C#), lógica, algoritmos, requisitos |
| **E2**  | 4,0   | 11/05/2026 – 23:59:56  | Modelagem física BD, Packet Tracer, módulos implementados, relatórios |
| **Apresentação** | 3,0 | Semana FECAP de Tecnologia (21 a 27/05) | Pitch + banner + demo funcional |





## 🎓 Referências

Aqui estão as referências usadas no projeto.

1. <https://github.com/iuricode/readme-template>
2. <https://github.com/gabrieldejesus/readme-model>
3. <https://chooser-beta.creativecommons.org/>
4. <https://freesound.org/>
5. <https://www.toptal.com/developers/gitignore>
6. Músicas por: <a href="https://freesound.org/people/DaveJf/sounds/616544/"> DaveJf </a> e <a href="https://freesound.org/people/DRFX/sounds/338986/"> DRFX </a> ambas com Licença CC 0.
