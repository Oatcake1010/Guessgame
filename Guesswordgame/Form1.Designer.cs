namespace Guesswordgame
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
            label_word = new Label();
            textBox_guess = new TextBox();
            button_next = new Button();
            button_start = new Button();
            label_result = new Label();
            label_score = new Label();
            SuspendLayout();
            // 
            // label_word
            // 
            label_word.BackColor = SystemColors.ButtonShadow;
            label_word.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_word.ForeColor = Color.White;
            label_word.Location = new Point(58, 47);
            label_word.Name = "label_word";
            label_word.Size = new Size(305, 57);
            label_word.TabIndex = 0;
            label_word.Text = "Word";
            label_word.TextAlign = ContentAlignment.TopCenter;
            label_word.Click += label1_Click;
            // 
            // textBox_guess
            // 
            textBox_guess.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_guess.Location = new Point(58, 134);
            textBox_guess.Name = "textBox_guess";
            textBox_guess.Size = new Size(305, 38);
            textBox_guess.TabIndex = 1;
            textBox_guess.TextAlign = HorizontalAlignment.Center;
            textBox_guess.TextChanged += textBox1_TextChanged;
            // 
            // button_next
            // 
            button_next.BackColor = Color.DeepSkyBlue;
            button_next.Enabled = false;
            button_next.FlatAppearance.BorderColor = Color.RoyalBlue;
            button_next.FlatStyle = FlatStyle.Flat;
            button_next.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_next.Location = new Point(58, 192);
            button_next.Name = "button_next";
            button_next.Size = new Size(305, 44);
            button_next.TabIndex = 2;
            button_next.Text = "Next";
            button_next.UseVisualStyleBackColor = false;
            button_next.Click += button_next_Click;
            // 
            // button_start
            // 
            button_start.BackColor = Color.DeepSkyBlue;
            button_start.FlatAppearance.BorderColor = Color.RoyalBlue;
            button_start.FlatStyle = FlatStyle.Flat;
            button_start.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_start.Location = new Point(58, 259);
            button_start.Name = "button_start";
            button_start.Size = new Size(305, 44);
            button_start.TabIndex = 3;
            button_start.Text = "Start";
            button_start.UseVisualStyleBackColor = false;
            button_start.Click += button_start_Click;
            // 
            // label_result
            // 
            label_result.BackColor = Color.Peru;
            label_result.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_result.Location = new Point(58, 351);
            label_result.Name = "label_result";
            label_result.Size = new Size(305, 60);
            label_result.TabIndex = 4;
            label_result.Text = "Result";
            label_result.TextAlign = ContentAlignment.TopCenter;
            label_result.Click += label_result_Click;
            // 
            // label_score
            // 
            label_score.AutoSize = true;
            label_score.Location = new Point(187, 434);
            label_score.Name = "label_score";
            label_score.Size = new Size(19, 15);
            label_score.TabIndex = 5;
            label_score.Text = "00";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(420, 468);
            Controls.Add(label_score);
            Controls.Add(label_result);
            Controls.Add(button_start);
            Controls.Add(button_next);
            Controls.Add(textBox_guess);
            Controls.Add(label_word);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_word;
        private TextBox textBox_guess;
        private Button button_next;
        private Button button_start;
        private Label label_result;
        private Label label_score;
    }
}
