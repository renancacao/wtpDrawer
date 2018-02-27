using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace wtpDrawer
{
    public partial class frmMain : Form
    {

        private String F_COR = "-c";
        private String F_MATRIX = "-m";

        private int[,] matrix = null;
        private Graphics g = null;
        private const int PTAM = 20;
        private Point lastClick = new Point(-1, -1);

        private List<SolidBrush> paleta;
        private int coresOriginais = 0;
        private int sCor = 0;
                
        private bool uPen = false;
        private bool uFill = false;
        private bool uGrade = false;
        
        public frmMain(){
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            paleta = new List<SolidBrush>();

            setPaleta();

            montaPaleta();
            exibeCor();

            bPen.Checked = true;
            bGrid.Checked = true;

                        
        }

        private void setPaleta() {

            paleta.Add(new SolidBrush(Color.FromArgb(88, 174, 124))); //fundo
            paleta.Add(new SolidBrush(Color.FromArgb(255, 201, 14))); //pele 1
            paleta.Add(new SolidBrush(Color.FromArgb(150, 87, 1))); //pele 2
           
            //complemetar
            paleta.Add(new SolidBrush(Color.Gray)); 
            paleta.Add(new SolidBrush(Color.Gray)); 
            paleta.Add(new SolidBrush(Color.Gray)); 
            paleta.Add(new SolidBrush(Color.Gray)); 
            paleta.Add(new SolidBrush(Color.Gray)); 
            paleta.Add(new SolidBrush(Color.Gray)); 
            paleta.Add(new SolidBrush(Color.Gray));
            paleta.Add(new SolidBrush(Color.Gray));
            paleta.Add(new SolidBrush(Color.Gray));

            addColors(255, 255,255, 123,123,123,0,0,0);
            addColors(255, 204, 205, 237, 28, 36, 113, 0, 3);
            addColors(255, 219, 196, 255, 127, 39, 70, 28, 0);
            addColors(255, 250, 187, 255, 242, 0, 60, 56, 0);
            addColors(204, 244, 215, 30, 153, 67, 9, 45, 19);
            addColors(206, 240, 255, 0, 162, 232, 0, 31, 45);
            addColors(225, 226, 247, 63, 72, 204, 13, 15, 47);
            addColors(241, 224, 241, 163, 73, 164, 35, 16, 35);

            coresOriginais = paleta.Count;

        }

        private void montaPaleta() {

            pPaleta.Controls.Clear();

            for (int i = 0; i < paleta.Count(); i++) {
                Panel p = new Panel();
                p.Height = 10;
                p.Width = 10;
                p.Margin = new Padding(1, 1, 1, 1);
                p.BackColor = paleta[i].Color;
                p.BorderStyle = BorderStyle.FixedSingle;
                p.Tag = i;
                p.Click += new EventHandler(paleta_Click); 
                pPaleta.Controls.Add(p);
            }

        }

        void paleta_Click(object sender, EventArgs e){
            Panel p = sender as Panel;
            sCor = (int)p.Tag;
            exibeCor();
        }

        void exibeCor() {
            pCor.BackColor = paleta[sCor].Color;
        }

        private void bNew_Click(object sender, EventArgs e)
        {
            if (matrix != null) {
                if (MessageBox.Show("Deseja iniciar um no PixelArt?", "Novo", MessageBoxButtons.YesNo) == DialogResult.No) {
                    return;
                }
            }
            inicializaCanvas();
        }

        private void inicializaCanvas() {

            
            pcCanvas.Image = new Bitmap(pcCanvas.Width, pcCanvas.Height);
            g = Graphics.FromImage(pcCanvas.Image);
            
            //tamanho da minha matrix
            matrix = new int[(pcCanvas.Width/PTAM),(pcCanvas.Height/PTAM)];

            //fundo
            g.FillRectangle( paleta[0] , new Rectangle(0,0,pcCanvas.Image.Width,pcCanvas.Image.Height));

            drawGrid();


        }

        private void bPen_CheckedChanged(object sender, EventArgs e)
        {
            //ativa lapis
            uPen = bPen.Checked;
        }

        private void pcCanvas_MouseClick(object sender, MouseEventArgs e){
            
            //Clique do mouse
            if (e.Button == MouseButtons.Left) {

                if (uPen){
                    drawPen(getPix(e.X), getPix(e.Y));
                }

                if (uFill) {
                    drawFill(getPix(e.X),getPix(e.Y));
                }
            }
            else if (e.Button == MouseButtons.Right) {

                sCor = matrix[getPix(e.X), getPix(e.Y)];
                exibeCor();

            }
        }

        private int getPix(int v){
            //pego o bloco a qual o click pertence
            double d = v / PTAM;
            return  Convert.ToInt32(Math.Floor(d));
       }

        private void drawPen(int i, int j){

            if (i == lastClick.X && j == lastClick.Y) { return; }
            if (!taDentroMatrix(i, j)) { return; }
                        
            lastClick = new Point(i, j);

            matrix[i, j] = sCor;
            this.Refresh();

        }


        private void drawFill(int i, int j)
        {

            if (!taDentroMatrix(i, j)) { return; }

            if (matrix[i, j] != sCor) {
                pintaFill(i, j, matrix[i, j]);
            }
                       
            this.Refresh();

        }

        private bool taDentroMatrix(int i, int j) {

            if (matrix == null) { return false; }
            if (i < 0 || i >= matrix.GetLength(0)) { return false; }
            if (j < 0 || j >= matrix.GetLength(1)) { return false; }

            return true;

        }

        private void pintaFill(int i, int j, int aux) {

            if (i < 0 || i > matrix.GetLength(0)-1) { return; }
            if (j < 0 || j > matrix.GetLength(1)-1) { return; }

            if (matrix[i, j] != aux) { return; }

            matrix[i, j] = sCor;

            pintaFill(i - 1, j, aux);
            pintaFill(i + 1, j , aux);
            pintaFill(i, j - 1, aux);
            pintaFill(i,  j + 1, aux);

        }

        private void frmMain_Paint(object sender, PaintEventArgs e){

            if (matrix != null){


                for (int i = 0; i < matrix.GetLength(0); i++){
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {

                        g.FillRectangle(paleta[matrix[i, j]], new Rectangle(i * PTAM, j * PTAM, PTAM, PTAM));
                }
            }

                drawGrid();
            }

        }

        private void drawGrid() {
            //grid

            if (!uGrade) { return; } 
 
            Pen linha = new Pen(Color.FromArgb(204, 51, 24));

            for (int i = PTAM; i < pcCanvas.Image.Width; i += PTAM){
                g.DrawLine(linha, new Point(i, 0), new Point(i, pcCanvas.Height));
            }
            for (int j = PTAM; j < pcCanvas.Image.Height; j += PTAM){
                g.DrawLine(linha, new Point(0, j), new Point(pcCanvas.Width, j));
            }
        }

        private void pFill_CheckedChanged(object sender, EventArgs e)
        {
            uFill = bFill.Checked;
        }

        private void pcCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Left){
                if (uPen){
                    drawPen(getPix(e.X), getPix(e.Y));
                }
            }
        }


        private void cGrid_CheckedChanged(object sender, EventArgs e)
        {
            uGrade = bGrid.Checked;
            this.Refresh();

        }

        private void bModelo_Click(object sender, EventArgs e)
        {
            if (matrix == null) { return; }
            menuModelo.Show(bModelo,new Point(0,0));
        }

        private void pixelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            matrix = Modelos.getPixel();
            this.Refresh();
        
             
        }

        private void pixelGrandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            matrix = Modelos.getGrande();
            this.Refresh();
        }

        private void pCor_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ColorDialog d = new ColorDialog();
            d.Color = pCor.BackColor;
            d.AllowFullOpen = true;
            d.FullOpen = true;
            d.AnyColor = true;
            if (d.ShowDialog() != DialogResult.Cancel) {

                SolidBrush b = new SolidBrush(d.Color);
                if (!paleta.Contains(b)) {
                    paleta.Add(b);
                    montaPaleta();
                    sCor = paleta.Count - 1;
                    exibeCor();
                }

            }
            d.Dispose();
        }



        private void addColors(int r1, int g1, int b1, int r2, int g2, int b2, int r3, int g3, int b3)
        {

            int r, g, b;
            r = (r2 - r1) / 6;
            g = (g2 - g1) / 6;
            b = (b2 - b1) / 6;

            for (int i = 0; i < 6; i++)
            {
                paleta.Add(new SolidBrush(Color.FromArgb(r1 + (r * i), g1 + (g * i), b1 + (b * i))));
            }

            
            r = (r3 - r2) / 6;
            g = (g3 - g2) / 6;
            b = (b3 - b2) / 6;

            for (int i = 0; i < 6; i++)
            {
                paleta.Add(new SolidBrush(Color.FromArgb(r2 + (r * i), g2 + (g * i), b2 + (b * i))));
            }

        }



        private void bSave_Click(object sender, EventArgs e){
            
            if (matrix != null) {

                SaveFileDialog f = new SaveFileDialog();
                f.Filter = "(*.wtp)|*.wtp";
                if (f.ShowDialog() != DialogResult.Cancel){
                    if (File.Exists(f.FileName)){
                        if (MessageBox.Show("Deseja substituir o arquivo existente?","Salvar",MessageBoxButtons.YesNo) == DialogResult.No){
                            f.Dispose();
                            return;
                        }
                    }
                    
                    StreamWriter sw = new StreamWriter(f.FileName);
                    sw.WriteLine(geraArquivo());
                    sw.Close();
                    sw.Dispose();
                    MessageBox.Show("Arquivo salvo!");

                }

                f.Dispose();

            }
        }

        private void bOpen_Click(object sender, EventArgs e){

            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "(*.wtp)|*.wtp";
            if (f.ShowDialog() != DialogResult.Cancel){

                if (matrix != null){
                    if (MessageBox.Show("Deseja abrir um no PixelArt?", "Novo", MessageBoxButtons.YesNo) == DialogResult.No) {
                        f.Dispose();
                        return;
                    }

                    setPaleta();
                    abreArquivo(f.FileName);
                    montaPaleta();

                }
            }
            f.Dispose();
        }

        private void abreArquivo(String path){


            StreamReader sr = new StreamReader(path);
            String line = "";
            int cont = 0;
            while (!sr.EndOfStream){

                line = sr.ReadLine();

                if (line == F_COR){
                    while (!sr.EndOfStream ) {

                        line = sr.ReadLine();
                        if (line == F_COR){break;}

                        String[] cps = line.Split(new Char[] { ';' });
                        if (cps.GetLength(0)==3) {
                            paleta.Add(new SolidBrush(Color.FromArgb(
                                Convert.ToInt32(cps[0]),
                                Convert.ToInt32(cps[1]),
                                Convert.ToInt32(cps[2]))));
                        }

                    }
                }
                else if (line == F_MATRIX)
                {
                    while (!sr.EndOfStream)
                    {

                        line = sr.ReadLine();
                        if (line == F_MATRIX) { break; }

                        String[] cps = line.Split(new Char[] { ';' });
                        if (cps.GetLength(0) == 2)
                        {
                            matrix = new int[Convert.ToInt32(cps[0]), Convert.ToInt32(cps[1])];
                        }

                    }
                }
                else {

                    String[] cps = line.Split(new Char[] { ';' });
                    if (cps.GetLength(0) == matrix.GetLength(1)) {

                        for (int i = 0; i < cps.GetLength(0); i++) {
                            matrix[cont, i] = Convert.ToInt32(cps[i]);
                        }

                        cont++;
                    }

                }




            }


        }

        private String geraArquivo() {

            StringBuilder sb = new StringBuilder();

            if (coresOriginais < paleta.Count){
                //vou anotar as novas cores 
                sb.AppendLine(F_COR);
                for (int i = coresOriginais; i < paleta.Count; i++)
                {
                    Color c = paleta[i].Color;
                    sb.AppendLine(c.R + ";" + c.G + ";" + c.B);
                }
            }

            sb.AppendLine(F_MATRIX);
            sb.AppendLine(matrix.GetLength(0) + ";" + matrix.GetLength(1));

            String line; ;
            for (int i = 0; i < matrix.GetLength(0); i++){
                line = "";
                for (int j = 0; j < matrix.GetLength(1); j++){
                    line += matrix[i, j] + ";";
                }
                sb.AppendLine(line.Substring(0, line.Length - 1));
            }

            return sb.ToString();

        }

   

    }
}
