using BrawhallaMods.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace BrawhallaMods {
    public partial class Form1 : Form
    {
        private string caminhoBrawlhalla = "";
        private string caminhoMods = Directory.GetCurrentDirectory();
        private string arquivoJson = Directory.GetCurrentDirectory() + "\\00\\dados.json";

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            //JSON
            string json = File.ReadAllText(arquivoJson);
            JavaScriptSerializer jss = new JavaScriptSerializer();
            Dados dados = jss.Deserialize<Dados>(json);

            string pasta = "";
            if (File.Exists(dados.caminho + "\\Brawlhalla.exe")) {
                pasta = dados.caminho;
            }
            else if (File.Exists("C:\\Program Files (x86)\\Steam\\steamapps\\common\\Brawlhalla\\Brawlhalla.exe")) {
                pasta = "C:\\Program Files(x86)\\Steam\\steamapps\\common\\Brawlhalla\\Brawlhalla.exe";
            }
            else {
                pasta = "";
            }
            caminhoBrawlhalla = pasta;
            txtPastaBrawlhalla.Text = pasta;
            escreverLabel(lbl02, "02", dados.mod02, img2);
            escreverLabel(lbl03, "03", dados.mod03, img3);
            escreverLabel(lbl04, "04", dados.mod04, img4);
            escreverLabel(lbl05, "05", dados.mod05, img5);
            escreverLabel(lbl06, "06", dados.mod06, img6);
            escreverLabel(lbl07, "07", dados.mod07, img7);
            escreverLabel(lbl08, "08", dados.mod08, img8);

            sobreescreverArquivo(pasta);

        }

        private void escreverLabel(Label label, string numero, string texto, PictureBox img) {
            if (texto == "") {
                label.Text = "";
            }
            else {
                if (texto.Substring(2, 1) == "." && int.TryParse(texto.Substring(0, 2), out int _out)) {
                    texto = texto.Substring(4);
                }
                label.Text = numero + ". " + texto;
            }
            string caminhoImagem = caminhoMods + "\\00\\" + numero + ".jpg";
            if (File.Exists(caminhoImagem)) {
                img.Image = Image.FromFile(caminhoImagem);
            }
            else {
                img.Image = Image.FromFile(caminhoMods + "\\00\\vazio.jpg");
            }
            img.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void sobreescreverArquivo(string caminho) {
            File.WriteAllText(arquivoJson,
                "{\n" +
                    "\t\"caminho\": \"" + caminho.Replace(@"\", @"\\") + "\",\n" +
                    "\t\"mod02\": \"" + lbl02.Text + "\",\n" +
                    "\t\"mod03\": \"" + lbl03.Text + "\",\n" +
                    "\t\"mod04\": \"" + lbl04.Text + "\",\n" +
                    "\t\"mod05\": \"" + lbl05.Text + "\",\n" +
                    "\t\"mod06\": \"" + lbl06.Text + "\",\n" +
                    "\t\"mod07\": \"" + lbl07.Text + "\",\n" +
                    "\t\"mod08\": \"" + lbl08.Text + "\"\n" +
                "}");
        }

        //Função iterativa para buscar nomes das pastas utilizadas
        private string[] caminhoPastas(string caminho) {
            List<string> ppastas = new List<string>();
            //Buscando pastas na pasta atual
            foreach (string dir in Directory.GetDirectories(caminho)){
                ppastas.Add(dir);
            }
            foreach(string dir in ppastas.ToArray()) {
                //Verificando pastas nas pastas da pasta atual
                string[] ppastasAux = caminhoPastas(dir);
                //Concatenando tudo que foi encontrado
                foreach (string dir2 in ppastasAux) {
                    ppastas.Add(dir2);
                }
            }
            //Retornando para a pasta mais próxima à raiz ou para terminar a função
            return ppastas.ToArray();
        }

        private int copiarArquivos(string mod) {
            string[] arquivos = { };
            //Acessando as pastas
            string[] pastas = caminhoPastas(caminhoMods + "\\" + mod);
            foreach (string pasta in pastas) {
                string pastaAtual = pasta.Substring(pasta.IndexOf(mod) + mod.Length);
                //Verificar se a pasta do vetor existe
                if (Directory.Exists(caminhoMods + "\\" + mod + "\\" + pastaAtual)) {
                    //Analisando os arquivos
                    arquivos = Directory.GetFiles(caminhoMods + "\\" + mod + "\\" + pastaAtual);
                    //Copiando cada arquivo para a pasta do brawlhalla correta
                    foreach (string arquivo in arquivos) {
                        //Nome do arquivo + extensão
                        string nomeArquivo = Path.GetFileName(arquivo);
                        File.Copy(arquivo, caminhoBrawlhalla + "\\" + pastaAtual + "\\" + nomeArquivo, true);
                    }
                }
            }
            return pastas.Length;
        }

        private void ativarModOriginal() {
            foreach (Control c in this.Controls) {
                if (c is Button && c != btnSearchFolder) {
                    c.BackColor = System.Drawing.Color.Red;
                    c.Text = "Ativar";
                }
            }
            btn1.BackColor = System.Drawing.Color.ForestGreen;
            copiarArquivos("01");
        }

        private void ativarBotao(Button btn, string pasta) {
            //Atualizar caminho do instalador do brawlhalla
            caminhoBrawlhalla = txtPastaBrawlhalla.Text;
            //Verificar se é este que foi ativado por último
            if (btn.BackColor != System.Drawing.Color.ForestGreen) {
                //Verificar se o caminho do jogo está correto
                if (File.Exists(caminhoBrawlhalla + "\\Brawlhalla.exe")) {
                    string caminhoModAtual = caminhoMods + "\\" + pasta;
                    //Verificar se o mod existe: caso não exista, será interrompido
                    if (!Directory.Exists(caminhoModAtual)) {
                        string mensagem = "O modo selecionado não possui arquivos de modificação.";
                        string titulo = "Mod incompleto";
                        MessageBoxButtons ok = MessageBoxButtons.OK;
                        MessageBox.Show(mensagem, titulo, ok);
                        return;
                    }
                    //Caso realmente exista vai continuar aqui
                    ativarModOriginal();
                    btn.BackColor = System.Drawing.Color.ForestGreen;
                    //Verificar se é original ou mod
                    if (btn.Name == "btn1") {
                        btn.Text = "Original ativado";
                        //Parar pois os próximos comandos são referentes aos mods (não originais)
                        return;
                    }
                    else {
                        btn.Text = "Mod ativado";
                    }
                    //Só executa os comandos abaixo caso não seja o mod original, devido ao return no if
                    btn1.BackColor = System.Drawing.Color.Red;
                    copiarArquivos(pasta);
                }
                //Caso o caminho do jogo esteja incorreto
                else {
                    string mensagem = "O caminho do jogo está incorreto!";
                    string titulo = "Jogo não encontrado";
                    MessageBoxButtons ok = MessageBoxButtons.OK;
                    MessageBox.Show(mensagem, titulo, ok);
                }
            }
            //Caso o mod já esteja ativado
            else {
                string mensagem = "O modo selecionado já estava ativado.";
                string titulo = "Modo já ativado";
                MessageBoxButtons ok = MessageBoxButtons.OK;
                MessageBox.Show(mensagem, titulo, ok);
            }
        }

        //Salvar caminho do instalador do Brawlhalla
        private string salvarCaminho() {
            caminhoBrawlhalla = txtPastaBrawlhalla.Text;
            string pasta = "";
            if (File.Exists(caminhoBrawlhalla + "\\Brawlhalla.exe")) {
                pasta = caminhoBrawlhalla;
            }
            if (pasta != "") {
                sobreescreverArquivo(pasta);
            }
            return pasta;
        }

        //Botão para procurar o executável do jogo
        private void btnSearchFolder_Click(object sender, EventArgs e) {
            caminhoBrawlhalla = txtPastaBrawlhalla.Text;
            string pasta = "";
            if (File.Exists(caminhoBrawlhalla + "\\Brawlhalla.exe")) {
                pasta = caminhoBrawlhalla;
            }
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = pasta;
            openFileDialog1.Title = "Selecione o executável do Brawlhalla";
            openFileDialog1.FileName = "Brawlhalla";
            openFileDialog1.Filter = "Exe Files (.exe)|*.exe|All Files (*.*)|*.*";
            openFileDialog1.ShowDialog();
            if (Path.GetDirectoryName(openFileDialog1.FileName) != "") {
                txtPastaBrawlhalla.Text = Path.GetDirectoryName(openFileDialog1.FileName);
            }
            salvarCaminho();
        }
        private void btnSearchFolder_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(btnSearchFolder,
                "Caso o endereço da pasta esteja incorreto,\n" +
                "selecione o executável do jogo por aqui.");
        }

        //Modo 01 - Original
        private void btn1_Click(object sender, EventArgs e) {
            ativarBotao(btn1, "01");
        }
        //Modo 02 - Mahamadag3ns
        private void btn2_Click(object sender, EventArgs e) {
            ativarBotao(btn2, "02");
        }
        //Modo 03 - Escuro
        private void btn3_Click(object sender, EventArgs e) {
            ativarBotao(btn3, "03");
        }
        //Modo 04 - BrawlzzFeed
        private void btn4_Click(object sender, EventArgs e) {
            ativarBotao(btn4, "04");
        }
        //Modo 05 - Cachorríneos
        private void btn5_Click(object sender, EventArgs e) {
            ativarBotao(btn5, "05");
        }
        //Modo 06 - ???
        private void btn6_Click(object sender, EventArgs e) {
            ativarBotao(btn6, "06");
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            ativarBotao(btn7, "07");
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            ativarBotao(btn8, "08");
        }
        
    }

    public class Dados {
        public string caminho { get; set; }
        public string mod02 { get; set; }
        public string mod03 { get; set; }
        public string mod04 { get; set; }
        public string mod05 { get; set; }
        public string mod06 { get; set; }
        public string mod07 { get; set; }
        public string mod08 { get; set; }
    }
}