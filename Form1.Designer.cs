
namespace _8_Card_Game
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MoveToDeck1Button = new System.Windows.Forms.Button();
            this.MoveToDeck2Button = new System.Windows.Forms.Button();
            this.ResetDeck1Button = new System.Windows.Forms.Button();
            this.ShuffleDeck1Button = new System.Windows.Forms.Button();
            this.ResetDeck2Button = new System.Windows.Forms.Button();
            this.ShuffleDeck2Button = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Deck #1(9 cards)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Deck #2(52 cards)";
            // 
            // MoveToDeck1Button
            // 
            this.MoveToDeck1Button.Location = new System.Drawing.Point(144, 80);
            this.MoveToDeck1Button.Name = "MoveToDeck1Button";
            this.MoveToDeck1Button.Size = new System.Drawing.Size(37, 21);
            this.MoveToDeck1Button.TabIndex = 4;
            this.MoveToDeck1Button.Text = "<<";
            this.MoveToDeck1Button.UseVisualStyleBackColor = true;
            this.MoveToDeck1Button.Click += new System.EventHandler(this.MoveToDeck1Button_Click);
            // 
            // MoveToDeck2Button
            // 
            this.MoveToDeck2Button.Location = new System.Drawing.Point(144, 107);
            this.MoveToDeck2Button.Name = "MoveToDeck2Button";
            this.MoveToDeck2Button.Size = new System.Drawing.Size(37, 21);
            this.MoveToDeck2Button.TabIndex = 5;
            this.MoveToDeck2Button.Text = ">>";
            this.MoveToDeck2Button.UseVisualStyleBackColor = true;
            this.MoveToDeck2Button.Click += new System.EventHandler(this.MoveToDeck2Button_Click);
            // 
            // ResetDeck1Button
            // 
            this.ResetDeck1Button.Location = new System.Drawing.Point(33, 262);
            this.ResetDeck1Button.Name = "ResetDeck1Button";
            this.ResetDeck1Button.Size = new System.Drawing.Size(101, 21);
            this.ResetDeck1Button.TabIndex = 6;
            this.ResetDeck1Button.Text = "Reset Deck #1";
            this.ResetDeck1Button.UseVisualStyleBackColor = true;
            this.ResetDeck1Button.Click += new System.EventHandler(this.ResetDeck1Button_Click);
            // 
            // ShuffleDeck1Button
            // 
            this.ShuffleDeck1Button.Location = new System.Drawing.Point(33, 289);
            this.ShuffleDeck1Button.Name = "ShuffleDeck1Button";
            this.ShuffleDeck1Button.Size = new System.Drawing.Size(101, 21);
            this.ShuffleDeck1Button.TabIndex = 7;
            this.ShuffleDeck1Button.Text = "Shuffle Deck #1";
            this.ShuffleDeck1Button.UseVisualStyleBackColor = true;
            this.ShuffleDeck1Button.Click += new System.EventHandler(this.ShuffleDeck1Button_Click);
            // 
            // ResetDeck2Button
            // 
            this.ResetDeck2Button.Location = new System.Drawing.Point(207, 262);
            this.ResetDeck2Button.Name = "ResetDeck2Button";
            this.ResetDeck2Button.Size = new System.Drawing.Size(105, 21);
            this.ResetDeck2Button.TabIndex = 8;
            this.ResetDeck2Button.Text = "Reset Deck #2";
            this.ResetDeck2Button.UseVisualStyleBackColor = true;
            // 
            // ShuffleDeck2Button
            // 
            this.ShuffleDeck2Button.Location = new System.Drawing.Point(207, 289);
            this.ShuffleDeck2Button.Name = "ShuffleDeck2Button";
            this.ShuffleDeck2Button.Size = new System.Drawing.Size(105, 21);
            this.ShuffleDeck2Button.TabIndex = 10;
            this.ShuffleDeck2Button.Text = "Shuffle Deck #2";
            this.ShuffleDeck2Button.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(15, 37);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(119, 212);
            this.listBox1.TabIndex = 11;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(190, 44);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(119, 212);
            this.listBox2.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 515);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ShuffleDeck2Button);
            this.Controls.Add(this.ResetDeck2Button);
            this.Controls.Add(this.ShuffleDeck1Button);
            this.Controls.Add(this.ResetDeck1Button);
            this.Controls.Add(this.MoveToDeck2Button);
            this.Controls.Add(this.MoveToDeck1Button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button MoveToDeck1Button;
        private System.Windows.Forms.Button MoveToDeck2Button;
        private System.Windows.Forms.Button ResetDeck1Button;
        private System.Windows.Forms.Button ShuffleDeck1Button;
        private System.Windows.Forms.Button ResetDeck2Button;
        private System.Windows.Forms.Button ShuffleDeck2Button;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
    }
}

