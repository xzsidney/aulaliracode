# 🛡️ Projeto LiraCode - Portal de Aulas & Cibersegurança

Portal web educativo com Design System inspirado em uniformes esportivos (Vermelho Carmesim `#b91c1c`, Azul Marinho `#0f172a`/`#1e3a8a` e Dourado `#eab308`). 

O projeto é voltado para jovens de 10 a 16 anos, ensinando a **controlar o computador e a tecnologia por baixo do capô**, e não apenas ser um usuário passivo de telas de celular.

---

## 🛣️ A Trilha da Estrada (Roadmap de Aulas)

A página inicial ([index.html](index.html)) conta com a **Trilha da Estrada Interativa**, onde cada aula é um marco quilométrico e pegadas (**👣**) indicam a localização do progresso atual da turma:

- 🟢 **Marco 01 (Aula 01):** [Dominando Arquivos e Pastas no Windows](aula01.html) — *Concluída*
- 🟡 **Marco 02 (Aula 02):** [O Crachá dos Arquivos: Extensões e Cibersegurança](aula02.html) — *Aula Atual (Onde o pezinho 👣 está!)*
- 🔒 **Marco 03 (Aula 03):** Primeiras Linhas de Lógica — *Bloqueada / Em Breve*
- 🔒 **Marco 04 (Aula 04):** Criando sua Primeira Página Web — *Bloqueada / Em Breve*
- 🔒 **Marco 05 (Aula 05):** Python e Automação Prática — *Bloqueada / Em Breve*

> Conforme as novas aulas forem ministradas aos sábados, basta criar o arquivo `aula03.html`, `aula04.html`, etc. e alterar a classe do card no `index.html` de `locked` para `unlocked`!

---

## 🧪 Laboratório Interativo da Aula 02

A página [aula02.html](aula02.html) inclui componentes interativos em JavaScript nativo:
1. **Cards Dinâmicos de Extensões:** Análise detalhada de `.txt`, `.png`, `.json` e `.exe/.bat` com medidores visuais de risco.
2. **Gerador de Downloads Reais via `Blob`:** Botões que criam e baixam arquivos reais diretamente no navegador do aluno:
   - `minha_anotacao.txt` (texto puro)
   - `personagem_game.json` (ficha RPG completa com atributos e inventário)
   - `escudo_liracode.png` (imagem gerada nativamente via HTML5 Canvas)
   - `teste_seguro.bat` (script demonstrativo inofensivo)
3. **Simulador do Golpe do Arquivo Oculto:** Interruptor interativo que demonstra como golpistas disfarçam executáveis (ex: `foto.png.exe`) quando a opção de ocultar extensões está ativa no Windows.

---

## 👨‍👩‍👧‍👦 Área dos Pais (Transparência e Parceria)
Seção especial no portal explicando aos pais:
- A bagagem de mais de 30 anos na área de TI (desde os computadores 486).
- Por que ensinar segurança, raciocínio lógico e resolução de problemas aos sábados.

---

## 🌐 Como Visualizar e Hospedar

1. **Localmente:** Basta dar um duplo clique em [index.html](index.html) para abrir no navegador.
2. **Online no GitHub Pages:**
   - Acesse seu repositório no GitHub: `Settings` &rarr; `Pages`.
   - Em *Source*, selecione a branch `main` e a pasta `/(root)`.
   - Clique em **Save**. O portal ficará online gratuitamente para todos os alunos acessarem em seus computadores ou celulares!
