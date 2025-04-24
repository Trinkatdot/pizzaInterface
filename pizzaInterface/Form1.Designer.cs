using System;
using System.Drawing;
using System.Windows.Forms;

namespace InterfacePizza
{
    public partial class Form1 : Form
    {
        private System.ComponentModel.IContainer components = null;

        public Form1()
        {
            InitializeComponent();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txt_titulo = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            btnTomate = new Button();
            btnBranco = new Button();
            btnPesto = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            printDialog1 = new PrintDialog();
            button13 = new Button();

            // 
            // txt_titulo
            // 
            txt_titulo.AutoSize = true;
            txt_titulo.Font = new Font("Sitka Text", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_titulo.Location = new Point(284, 29);
            txt_titulo.Name = "txt_titulo";
            txt_titulo.Size = new Size(181, 30);
            txt_titulo.TabIndex = 0;
            txt_titulo.Text = "Monte sua Pizza";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(42, 53);
            label1.Name = "label1";
            label1.Size = new Size(170, 19);
            label1.TabIndex = 1;
            label1.Text = "Selecione os Ingredientes:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Mongolian Baiti", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkRed;
            label3.Location = new Point(41, 209);
            label3.Name = "label3";
            label3.Size = new Size(73, 23);
            label3.TabIndex = 5;
            label3.Text = "Molho";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Mongolian Baiti", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkRed;
            label4.Location = new Point(37, 82);
            label4.Name = "label4";
            label4.Size = new Size(82, 23);
            label4.TabIndex = 7;
            label4.Text = "Farinha";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Mongolian Baiti", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkRed;
            label5.Location = new Point(37, 330);
            label5.Name = "label5";
            label5.Size = new Size(74, 23);
            label5.TabIndex = 8;
            label5.Text = "Queijo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Mongolian Baiti", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkRed;
            label2.Location = new Point(41, 462);
            label2.Name = "label2";
            label2.Size = new Size(65, 23);
            label2.TabIndex = 3;
            label2.Text = "Carne";
            // 
            // Botões de ingredientes
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Location = new Point(140, 108);
            button1.Size = new Size(100, 89);

            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Location = new Point(34, 108);
            button2.Size = new Size(100, 89);

            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.Location = new Point(246, 108);
            button3.Size = new Size(102, 89);

            btnTomate.BackgroundImage = (Image)resources.GetObject("btnTomate.BackgroundImage");
            btnTomate.BackgroundImageLayout = ImageLayout.Stretch;
            btnTomate.Location = new Point(34, 229);
            btnTomate.Size = new Size(100, 89);

            btnBranco.BackgroundImage = (Image)resources.GetObject("btnBranco.BackgroundImage");
            btnBranco.BackgroundImageLayout = ImageLayout.Zoom;
            btnBranco.Location = new Point(140, 229);
            btnBranco.Size = new Size(100, 89);

            btnPesto.BackgroundImage = (Image)resources.GetObject("btnPesto.BackgroundImage");
            btnPesto.BackgroundImageLayout = ImageLayout.Zoom;
            btnPesto.Location = new Point(246, 229);
            btnPesto.Size = new Size(102, 89);

            button7.BackgroundImage = (Image)resources.GetObject("button7.BackgroundImage");
            button7.BackgroundImageLayout = ImageLayout.Zoom;
            button7.Location = new Point(34, 353);
            button7.Size = new Size(100, 94);

            button8.BackgroundImage = (Image)resources.GetObject("button8.BackgroundImage");
            button8.BackgroundImageLayout = ImageLayout.Zoom;
            button8.Location = new Point(140, 353);
            button8.Size = new Size(100, 94);

            button9.BackgroundImage = (Image)resources.GetObject("button9.BackgroundImage");
            button9.BackgroundImageLayout = ImageLayout.Zoom;
            button9.Location = new Point(246, 353);
            button9.Size = new Size(102, 94);

            button10.BackgroundImage = (Image)resources.GetObject("button10.BackgroundImage");
            button10.BackgroundImageLayout = ImageLayout.Zoom;
            button10.Location = new Point(35, 484);
            button10.Size = new Size(100, 94);

            button11.BackgroundImage = (Image)resources.GetObject("button11.BackgroundImage");
            button11.BackgroundImageLayout = ImageLayout.Zoom;
            button11.Location = new Point(141, 484);
            button11.Size = new Size(100, 94);

            button12.BackgroundImage = (Image)resources.GetObject("button12.BackgroundImage");
            button12.BackgroundImageLayout = ImageLayout.Zoom;
            button12.Location = new Point(247, 484);
            button12.Size = new Size(100, 94);

            printDialog1.UseEXDialog = true;

            // Botão Confirmar
            button13.Location = new Point(235, 593);
            button13.Size = new Size(112, 30);
            button13.Text = "Confirmar";
            button13.Click += new EventHandler(btnConfirmar_Click);

            // Form1
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 657);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(btnPesto);
            Controls.Add(btnBranco);
            Controls.Add(btnTomate);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_titulo);
            Name = "Form1";
            Text = "Monte sua Pizza";
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pedido confirmado!");
        }

        private Label txt_titulo;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button btnTomate;
        private Button btnBranco;
        private Button btnPesto;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private PrintDialog printDialog1;
        private Button button13;
    }
}
