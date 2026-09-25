using System;
using System.Windows.Forms;

namespace AulaExemplo {
    class Program {
        [STAThread]
        static void Main() {
            MessageBox.Show(
                "Olá, aluno(a)!\n\n" +
                "Este é um arquivo EXECUTÁVEL (.EXE) criado exclusivamente para fins didáticos.\n\n" +
                "⚠️ POR QUE O .EXE TEM RISCO ALTO?\n" +
                "Arquivos .exe contêm código de máquina e instruções diretas para o processador e sistema operacional.\n" +
                "Eles têm permissão para:\n" +
                "- Criar, alterar ou apagar arquivos no disco;\n" +
                "- Conectar-se à internet e transferir dados;\n" +
                "- Instalar programas em segundo plano.\n\n" +
                "🛡️ DICA DE SEGURANÇA:\n" +
                "Nunca execute arquivos .exe baixados de e-mails suspeitos ou fontes não confiáveis!",
                "Exemplo Didático - Aula de Segurança e Extensões",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
