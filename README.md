# Projeto2

# 🎮 Projeto Interdisciplinar – Messier Data & Creative

## 📌 Identificação do Projeto

| Campo             | Informação                                               |
|-------------------|----------------------------------------------------------|
| **Título**        | Sistema Desktop para Gestão de Assinaturas de Jogos Educacionais |
| **Empresa parceira** | Messier Data & Creative                              |
| **Curso**         | Análise e Desenvolvimento de Sistemas (ADS)              |
| **Turma**         | 1º Semestre – 2026                                       |
| **Tema**          | Desenvolvimento de um Aplicativo Desktop com acesso a Banco de Dados |

---

## 👥 Integrantes do Grupo

| Nome                                  |
|---------------------------------------|
| Enzo Lemos Souza do Nascimento        | 
| Vitor de Moura Lima                   | 
| Felipe Okada Corleto                  | 
| Felipe Rodrigues dos Santos Farias    | 

---

## 🎯 Objetivo Geral do Projeto

Desenvolver uma **aplicação Desktop** (Windows Forms / WPF) com banco de dados para:

- Gerenciar **assinaturas de jogos educacionais** contratadas por escolas;
- Controlar **pacotes contratados**, **limites de acessos mensais** e **IPs autorizados**;
- Gerar **relatórios de consumo** e **logs de acesso**.

---

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

## 📅 Entregas e Prazos

| Entrega | Valor | Data limite            | Descrição resumida                                          |
|---------|-------|------------------------|-------------------------------------------------------------|
| **E1**  | 3,0   | 13/04/2026 – 23:59:56  | Modelagem conceitual BD, simulação IP (C#), lógica, algoritmos, requisitos |
| **E2**  | 4,0   | 11/05/2026 – 23:59:56  | Modelagem física BD, Packet Tracer, módulos implementados, relatórios |
| **Apresentação** | 3,0 | Semana FECAP de Tecnologia (21 a 27/05) | Pitch + banner + demo funcional |

---

## 📁 Estrutura das Entregas neste Repositório

```text
PI-Messier-1ADS/
│
├── README.md                          # ← Você está aqui
│
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
            └── RegrasLogica.pdf          # Lógica proposicional, tabela-verdade, cenários
