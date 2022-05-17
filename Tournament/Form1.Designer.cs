namespace Tournament
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirstPair = new System.Windows.Forms.TextBox();
            this.txtSecondPair = new System.Windows.Forms.TextBox();
            this.txtFourthPair = new System.Windows.Forms.TextBox();
            this.txtThirdPair = new System.Windows.Forms.TextBox();
            this.txtSecondRoundFirstPair = new System.Windows.Forms.TextBox();
            this.txtSecondRoundSecondPair = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFinalists = new System.Windows.Forms.TextBox();
            this.btnStartTournament = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWinnerOfTournament = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quarter final:";
            // 
            // txtFirstPair
            // 
            this.txtFirstPair.Location = new System.Drawing.Point(21, 53);
            this.txtFirstPair.Name = "txtFirstPair";
            this.txtFirstPair.Size = new System.Drawing.Size(280, 27);
            this.txtFirstPair.TabIndex = 1;
            // 
            // txtSecondPair
            // 
            this.txtSecondPair.Location = new System.Drawing.Point(21, 100);
            this.txtSecondPair.Name = "txtSecondPair";
            this.txtSecondPair.Size = new System.Drawing.Size(280, 27);
            this.txtSecondPair.TabIndex = 2;
            // 
            // txtFourthPair
            // 
            this.txtFourthPair.Location = new System.Drawing.Point(21, 202);
            this.txtFourthPair.Name = "txtFourthPair";
            this.txtFourthPair.Size = new System.Drawing.Size(280, 27);
            this.txtFourthPair.TabIndex = 3;
            // 
            // txtThirdPair
            // 
            this.txtThirdPair.Location = new System.Drawing.Point(21, 151);
            this.txtThirdPair.Name = "txtThirdPair";
            this.txtThirdPair.Size = new System.Drawing.Size(280, 27);
            this.txtThirdPair.TabIndex = 4;
            // 
            // txtSecondRoundFirstPair
            // 
            this.txtSecondRoundFirstPair.Location = new System.Drawing.Point(345, 77);
            this.txtSecondRoundFirstPair.Name = "txtSecondRoundFirstPair";
            this.txtSecondRoundFirstPair.Size = new System.Drawing.Size(248, 27);
            this.txtSecondRoundFirstPair.TabIndex = 6;
            // 
            // txtSecondRoundSecondPair
            // 
            this.txtSecondRoundSecondPair.Location = new System.Drawing.Point(345, 178);
            this.txtSecondRoundSecondPair.Name = "txtSecondRoundSecondPair";
            this.txtSecondRoundSecondPair.Size = new System.Drawing.Size(248, 27);
            this.txtSecondRoundSecondPair.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(422, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Semifinal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(804, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Final:";
            // 
            // txtFinalists
            // 
            this.txtFinalists.Location = new System.Drawing.Point(668, 131);
            this.txtFinalists.Name = "txtFinalists";
            this.txtFinalists.Size = new System.Drawing.Size(291, 27);
            this.txtFinalists.TabIndex = 11;
            // 
            // btnStartTournament
            // 
            this.btnStartTournament.Location = new System.Drawing.Point(345, 273);
            this.btnStartTournament.Name = "btnStartTournament";
            this.btnStartTournament.Size = new System.Drawing.Size(248, 29);
            this.btnStartTournament.TabIndex = 12;
            this.btnStartTournament.Text = "Start tournament";
            this.btnStartTournament.UseVisualStyleBackColor = true;
            this.btnStartTournament.Click += new System.EventHandler(this.btnStartTournament_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Winner of this tournament is: ";
            // 
            // txtWinnerOfTournament
            // 
            this.txtWinnerOfTournament.Location = new System.Drawing.Point(345, 357);
            this.txtWinnerOfTournament.Name = "txtWinnerOfTournament";
            this.txtWinnerOfTournament.Size = new System.Drawing.Size(248, 27);
            this.txtWinnerOfTournament.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 464);
            this.Controls.Add(this.txtWinnerOfTournament);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnStartTournament);
            this.Controls.Add(this.txtFinalists);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSecondRoundSecondPair);
            this.Controls.Add(this.txtSecondRoundFirstPair);
            this.Controls.Add(this.txtThirdPair);
            this.Controls.Add(this.txtFourthPair);
            this.Controls.Add(this.txtSecondPair);
            this.Controls.Add(this.txtFirstPair);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Tennis tournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtFirstPair;
        private TextBox txtSecondPair;
        private TextBox txtFourthPair;
        private TextBox txtThirdPair;
        private TextBox txtSecondRoundFirstPair;
        private TextBox txtSecondRoundSecondPair;
        private Label label2;
        private Label label3;
        private TextBox txtFinalists;
        private Button btnStartTournament;
        private Label label4;
        private TextBox txtWinnerOfTournament;
    }
}