namespace SortingVisualization
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.screen = new System.Windows.Forms.PictureBox();
            this.shuffleButton = new System.Windows.Forms.Button();
            this.sortButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.screen)).BeginInit();
            this.SuspendLayout();
            // 
            // screen
            // 
            this.screen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.screen.Location = new System.Drawing.Point(12, 12);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(600, 500);
            this.screen.TabIndex = 0;
            this.screen.TabStop = false;
            // 
            // ShuffleButton
            // 
            this.shuffleButton.Location = new System.Drawing.Point(618, 12);
            this.shuffleButton.Name = "ShuffleButton";
            this.shuffleButton.Size = new System.Drawing.Size(75, 23);
            this.shuffleButton.TabIndex = 1;
            this.shuffleButton.Text = "Shuffle";
            this.shuffleButton.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.sortButton.Location = new System.Drawing.Point(618, 41);
            this.sortButton.Name = "button2";
            this.sortButton.Size = new System.Drawing.Size(75, 23);
            this.sortButton.TabIndex = 2;
            this.sortButton.Text = "Sort";
            this.sortButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 522);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.shuffleButton);
            this.Controls.Add(this.screen);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.screen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox screen;
        private System.Windows.Forms.Button shuffleButton;
        private System.Windows.Forms.Button sortButton;
    }
}

