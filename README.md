# 🎓 Portal de Aulas - LiraCode

Projeto didático estruturado com template responsivo, menu de navegação e páginas dedicadas para apoiar os alunos nas aulas de programação e computação.

---

## 🧭 Estrutura de Páginas do Portal

- **[index.html](index.html) - Página Inicial (Home):**
  - Boas-vindas aos estudantes.
  - Painel de módulos disponíveis com atalhos de navegação.
  - Dicas e metodologia de estudo.
- **[logica.html](logica.html) - Aula 01: Lógica de Programação:**
  - O que é lógica de programação.
  - Conceito de algoritmos com exemplos do cotidiano.
  - Pilares fundamentais (Variáveis, Condicionais, Loops e Funções).
  - Dicas práticas.
- **[arquivos-seguranca.html](arquivos-seguranca.html) - Aula 02: Extensões de Arquivos & Segurança:**
  - Explicação sobre extensões e formatos de arquivos.
  - Cartões com níveis de risco de cada formato (.txt, .json, .png, .exe).
  - Botões para download dos arquivos de exemplo para os alunos testarem em sala de aula.
  - Alerta de cibersegurança: O golpe da extensão dupla e como exibir extensões no Windows.
- **[style.css](style.css):**
  - Estilização unificada, menu de navegação responsivo (desktop e mobile), cards com badges de status e paleta moderna.

---

## 📁 Arquivos de Exemplo para Download (pasta `exemplos/`)
- `exemplo-texto.txt`: Arquivo de texto puro (.txt) - *Risco Muito Baixo*
- `exemplo-dados.json`: Arquivo de dados estruturados (.json) - *Risco Baixo*
- `exemplo-imagem.png`: Imagem raster com transparência (.png) - *Risco Baixo / Atenção*
- `exemplo-programa.exe`: Executável de teste seguro compilado em C# (.exe) - *Risco Alto* (exibe janela didática de alerta)
- `ExemploApp.cs`: Código-fonte aberto do executável de exemplo.

---

## 🌐 Como Rodar / Publicar
1. **Localmente:** Basta dar um duplo clique em `index.html` no seu computador.
2. **Online (GitHub Pages):** Ative o **GitHub Pages** nas configurações do repositório (`Settings > Pages > Branch main / root`) para disponibilizar o site em um link público gratuito para todos os alunos acessarem diretamente do navegador ou celular!
