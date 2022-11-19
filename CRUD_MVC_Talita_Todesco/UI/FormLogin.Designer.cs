
namespace CRUD_MVC_Talita_Todesco
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tblemail = new System.Windows.Forms.Label();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.senha = new System.Windows.Forms.Label();
            this.senhatxt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tblemail
            // 
            this.tblemail.AutoSize = true;
            this.tblemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblemail.Location = new System.Drawing.Point(329, 177);
            this.tblemail.Name = "tblemail";
            this.tblemail.Size = new System.Drawing.Size(55, 18);
            this.tblemail.TabIndex = 0;
            this.tblemail.Text = "Email:";
            this.tblemail.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.tblemail.Click += new System.EventHandler(this.label1_Click);
            // 
            // emailtxt
            // 
            this.emailtxt.BackColor = System.Drawing.Color.White;
            this.emailtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailtxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.emailtxt.Location = new System.Drawing.Point(390, 174);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(100, 24);
            this.emailtxt.TabIndex = 1;
            this.emailtxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // senha
            // 
            this.senha.AutoSize = true;
            this.senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senha.Location = new System.Drawing.Point(324, 228);
            this.senha.Name = "senha";
            this.senha.Size = new System.Drawing.Size(60, 18);
            this.senha.TabIndex = 2;
            this.senha.Text = "Senha:";
            // 
            // senhatxt
            // 
            this.senhatxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senhatxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.senhatxt.Location = new System.Drawing.Point(390, 222);
            this.senhatxt.Name = "senhatxt";
            this.senhatxt.PasswordChar = '*';
            this.senhatxt.Size = new System.Drawing.Size(100, 24);
            this.senhatxt.TabIndex = 3;
            this.senhatxt.TextChanged += new System.EventHandler(this.senha2_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::CRUD_MVC_Talita_Todesco.Properties.Resources.download20220805221552;
            this.pictureBox1.Location = new System.Drawing.Point(329, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnbutton
            // 
            this.btnbutton.BackColor = System.Drawing.Color.Yellow;
            this.btnbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbutton.Location = new System.Drawing.Point(363, 267);
            this.btnbutton.Name = "btnbutton";
            this.btnbutton.Size = new System.Drawing.Size(89, 30);
            this.btnbutton.TabIndex = 6;
            this.btnbutton.Text = "Entrar";
            this.btnbutton.UseVisualStyleBackColor = false;
            this.btnbutton.Click += new System.EventHandler(this.btnbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnbutton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.senhatxt);
            this.Controls.Add(this.senha);
            this.Controls.Add(this.emailtxt);
            this.Controls.Add(this.tblemail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tblemail;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.Label senha;
        private System.Windows.Forms.TextBox senhatxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnbutton;
        private System.Windows.Forms.Label label1;
    }
}

