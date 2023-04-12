namespace Lamboda_Run
{
    partial class GameScreen
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label12 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.gameEngine = new System.Windows.Forms.Timer(this.components);
            this.scoreOutput = new System.Windows.Forms.Label();
            this.livesOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Yellow;
            this.label12.Location = new System.Drawing.Point(398, 717);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(10, 43);
            this.label12.TabIndex = 16;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.Yellow;
            this.label18.Location = new System.Drawing.Point(290, 717);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(10, 43);
            this.label18.TabIndex = 30;
            // 
            // gameEngine
            // 
            this.gameEngine.Enabled = true;
            this.gameEngine.Interval = 17;
            this.gameEngine.Tick += new System.EventHandler(this.gameEngine_Tick);
            // 
            // scoreOutput
            // 
            this.scoreOutput.AutoSize = true;
            this.scoreOutput.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreOutput.Location = new System.Drawing.Point(3, 10);
            this.scoreOutput.Name = "scoreOutput";
            this.scoreOutput.Size = new System.Drawing.Size(87, 21);
            this.scoreOutput.TabIndex = 31;
            this.scoreOutput.Text = "Score: ";
            // 
            // livesOutput
            // 
            this.livesOutput.AutoSize = true;
            this.livesOutput.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.livesOutput.Location = new System.Drawing.Point(3, 40);
            this.livesOutput.Name = "livesOutput";
            this.livesOutput.Size = new System.Drawing.Size(76, 21);
            this.livesOutput.TabIndex = 32;
            this.livesOutput.Text = "Lives:";
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.BackgroundImage = global::Lamboda_Run.Properties.Resources.Untitled;
            this.Controls.Add(this.livesOutput);
            this.Controls.Add(this.scoreOutput);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label12);
            this.DoubleBuffered = true;
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(700, 700);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameScreen_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameScreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GameScreen_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Timer gameEngine;
        private System.Windows.Forms.Label scoreOutput;
        private System.Windows.Forms.Label livesOutput;
    }
}
