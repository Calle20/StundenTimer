
namespace StundenTimerNeu

{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl_Clock = new System.Windows.Forms.Label();
            this.Clock = new System.Windows.Forms.Timer(this.components);
            this.groupBoxClock = new System.Windows.Forms.GroupBox();
            this.lbl_Next = new System.Windows.Forms.Label();
            this.groupBoxClock.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Clock
            // 
            this.lbl_Clock.AutoSize = true;
            this.lbl_Clock.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Clock.Location = new System.Drawing.Point(6, 26);
            this.lbl_Clock.Name = "lbl_Clock";
            this.lbl_Clock.Size = new System.Drawing.Size(96, 26);
            this.lbl_Clock.TabIndex = 1;
            this.lbl_Clock.Text = "24:24:24";
            // 
            // Clock
            // 
            this.Clock.Interval = 1000;
            this.Clock.Tick += new System.EventHandler(this.Clock_Tick);
            // 
            // groupBoxClock
            // 
            this.groupBoxClock.Controls.Add(this.lbl_Clock);
            this.groupBoxClock.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxClock.Location = new System.Drawing.Point(12, 12);
            this.groupBoxClock.Name = "groupBoxClock";
            this.groupBoxClock.Size = new System.Drawing.Size(108, 67);
            this.groupBoxClock.TabIndex = 2;
            this.groupBoxClock.TabStop = false;
            this.groupBoxClock.Text = "Uhrzeit";
            // 
            // lbl_Next
            // 
            this.lbl_Next.AutoSize = true;
            this.lbl_Next.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Next.Location = new System.Drawing.Point(126, 27);
            this.lbl_Next.Name = "lbl_Next";
            this.lbl_Next.Size = new System.Drawing.Size(196, 52);
            this.lbl_Next.TabIndex = 3;
            this.lbl_Next.Text = "Um 7:40 Uhr klingelt\r\n     es zur Stunde";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 98);
            this.Controls.Add(this.lbl_Next);
            this.Controls.Add(this.groupBoxClock);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxClock.ResumeLayout(false);
            this.groupBoxClock.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Clock;
        private System.Windows.Forms.Timer Clock;
        private System.Windows.Forms.GroupBox groupBoxClock;
        private System.Windows.Forms.Label lbl_Next;
    }
}



