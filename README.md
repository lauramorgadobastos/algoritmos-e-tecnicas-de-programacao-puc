
<div align="center">


# Algoritmos e Técnicas de Programação (ATP) - PUC Minas

<!-- Badges Principais -->
<p align="center">
  <img src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white" alt="C#" />
  <img src="https://img.shields.io/badge/.NET_8.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" alt=".NET 8.0" />
 <img src="https://img.shields.io/badge/Semestre%2F1-2026-95389E?style=for-the-badge"/>
 <img src="https://img.shields.io/badge/License-None-lightgrey?style=for-the-badge" />
</p>

</div>

Repositório consolidado dos Trabalhos Práticos (TPs) desenvolvidos para a disciplina de **Algoritmos e Técnicas de Programação (ATP)** do 1º período do curso de **Sistemas de Informação** da **PUC Minas (Campus Betim)**.

O projeto foi arquitetado em **C# (.NET 8)** de forma totalmente modularizada, centralizando a execução de todos os trabalhos práticos em um menu interativo único no terminal.

---

## Estrutura do Repositório

```text
algoritmos-e-tecnicas-de-programacao-puc/
├── .github/
│   └── workflows/
│       └── csharp-ci.yml           # Workflow do GitHub Actions (Format & Build)
├── src/
│   ├── Program.cs                  # Menu centralizador principal da aplicação
│   ├── Atp.csproj                 # Arquivo de configuração do projeto .NET
│   ├── Trabalho01/                # TP1: Calculadora de Descontos
│   │   └── CalculadoraDesconto.cs
│   ├── Trabalho02/                # TP2: Simulador de Eleição
│   │   └── SimuladorEleicao.cs
│   ├── Trabalho03/                # TP3: Monitoramento Climático
│   │   └── SistemaClimatico.cs
│   └── Trabalho04/                # TP4: Eleição com Manipulação de Arquivos
│       ├── SimuladorEleicaoSul.cs
│       ├── eleicao_in.txt         # Arquivo de entrada para leitura dos dados
│       └── eleicao_out.txt        # Arquivo de saída gerado pelo sistema
├── .gitignore                     # Configuração de arquivos ignorados do Git
└── README.md                      # Documentação principal do repositório
```

---

