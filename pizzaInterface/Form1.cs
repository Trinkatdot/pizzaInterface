namespace pizzaInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Location = new Point(59, 199);
            button1.Name = "button1";
            button1.Size = new Size(62, 64);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Location = new Point(127, 199);
            button2.Name = "button2";
            button2.Size = new Size(62, 64);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.Location = new Point(195, 199);
            button3.Name = "button3";
            button3.Size = new Size(62, 64);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.Location = new Point(195, 294);
            button4.Name = "button4";
            button4.Size = new Size(62, 64);
            button4.TabIndex = 5;
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.BackgroundImageLayout = ImageLayout.Zoom;
            button5.Location = new Point(127, 294);
            button5.Name = "button5";
            button5.Size = new Size(62, 64);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.BackgroundImage = (Image)resources.GetObject("button6.BackgroundImage");
            button6.BackgroundImageLayout = ImageLayout.Zoom;
            button6.Location = new Point(59, 294);
            button6.Name = "button6";
            button6.Size = new Size(62, 64);
            button6.TabIndex = 3;
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.BackgroundImage = (Image)resources.GetObject("button7.BackgroundImage");
            button7.BackgroundImageLayout = ImageLayout.Zoom;
            button7.Location = new Point(195, 385);
            button7.Name = "button7";
            button7.Size = new Size(62, 64);
            button7.TabIndex = 8;
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.BackgroundImage = (Image)resources.GetObject("button8.BackgroundImage");
            button8.BackgroundImageLayout = ImageLayout.Zoom;
            button8.Location = new Point(127, 385);
            button8.Name = "button8";
            button8.Size = new Size(62, 64);
            button8.TabIndex = 7;
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.BackgroundImage = (Image)resources.GetObject("button9.BackgroundImage");
            button9.BackgroundImageLayout = ImageLayout.Zoom;
            button9.Location = new Point(59, 385);
            button9.Name = "button9";
            button9.Size = new Size(62, 64);
            button9.TabIndex = 6;
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.BackgroundImage = (Image)resources.GetObject("button10.BackgroundImage");
            button10.BackgroundImageLayout = ImageLayout.Zoom;
            button10.Location = new Point(195, 478);
            button10.Name = "button10";
            button10.Size = new Size(62, 64);
            button10.TabIndex = 11;
            button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.BackgroundImage = (Image)resources.GetObject("button11.BackgroundImage");
            button11.BackgroundImageLayout = ImageLayout.Zoom;
            button11.Location = new Point(127, 478);
            button11.Name = "button11";
            button11.Size = new Size(62, 64);
            button11.TabIndex = 10;
            button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.BackgroundImage = (Image)resources.GetObject("button12.BackgroundImage");
            button12.BackgroundImageLayout = ImageLayout.Zoom;
            button12.Location = new Point(59, 478);
            button12.Name = "button12";
            button12.Size = new Size(62, 64);
            button12.TabIndex = 9;
            button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            button13.BackColor = Color.FromArgb(192, 0, 0);
            button13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button13.ForeColor = SystemColors.ButtonHighlight;
            button13.Location = new Point(166, 565);
            button13.Name = "button13";
            button13.Size = new Size(121, 26);
            button13.TabIndex = 12;
            button13.Text = "CONFIRMAR";
            button13.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(782, 651);
            Controls.Add(button13);
            Controls.Add(button10);
            Controls.Add(button11);
            Controls.Add(button12);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            ResumeLayout(false);
        }

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
    }
}
    

