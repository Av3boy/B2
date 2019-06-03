namespace B2
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Calculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Tbox_num1 = new System.Windows.Forms.TextBox();
            this.Tbox_num2 = new System.Windows.Forms.TextBox();
            this.Tbox_operation = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.VoiceActivation = new System.Windows.Forms.GroupBox();
            this.Lbl_Synthentizer = new System.Windows.Forms.Label();
            this.Btn_Synthentizer = new System.Windows.Forms.Button();
            this.Lbl_Microphone = new System.Windows.Forms.Label();
            this.Btn_SpeechRecognition = new System.Windows.Forms.Button();
            this.Lbl_CurrentAudioOutput = new System.Windows.Forms.Label();
            this.Lbl_CurrentAudioInput = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.VoiceActivation.SuspendLayout();
            this.SuspendLayout();
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(109, 100);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(75, 23);
            this.Calculate.TabIndex = 0;
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Button_Calculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // Tbox_num1
            // 
            this.Tbox_num1.Location = new System.Drawing.Point(94, 19);
            this.Tbox_num1.Name = "Tbox_num1";
            this.Tbox_num1.Size = new System.Drawing.Size(100, 20);
            this.Tbox_num1.TabIndex = 2;
            // 
            // Tbox_num2
            // 
            this.Tbox_num2.Location = new System.Drawing.Point(94, 74);
            this.Tbox_num2.Name = "Tbox_num2";
            this.Tbox_num2.Size = new System.Drawing.Size(100, 20);
            this.Tbox_num2.TabIndex = 3;
            // 
            // Tbox_operation
            // 
            this.Tbox_operation.Location = new System.Drawing.Point(94, 48);
            this.Tbox_operation.Name = "Tbox_operation";
            this.Tbox_operation.Size = new System.Drawing.Size(100, 20);
            this.Tbox_operation.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Tbox_num1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Tbox_operation);
            this.groupBox1.Controls.Add(this.Calculate);
            this.groupBox1.Controls.Add(this.Tbox_num2);
            this.groupBox1.Location = new System.Drawing.Point(588, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 177);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // VoiceActivation
            // 
            this.VoiceActivation.Controls.Add(this.Lbl_CurrentAudioInput);
            this.VoiceActivation.Controls.Add(this.Lbl_CurrentAudioOutput);
            this.VoiceActivation.Controls.Add(this.Btn_SpeechRecognition);
            this.VoiceActivation.Controls.Add(this.Lbl_Microphone);
            this.VoiceActivation.Controls.Add(this.Lbl_Synthentizer);
            this.VoiceActivation.Controls.Add(this.Btn_Synthentizer);
            this.VoiceActivation.Location = new System.Drawing.Point(402, 12);
            this.VoiceActivation.Name = "VoiceActivation";
            this.VoiceActivation.Size = new System.Drawing.Size(180, 245);
            this.VoiceActivation.TabIndex = 6;
            this.VoiceActivation.TabStop = false;
            // 
            // Lbl_Synthentizer
            // 
            this.Lbl_Synthentizer.AutoSize = true;
            this.Lbl_Synthentizer.Location = new System.Drawing.Point(26, 19);
            this.Lbl_Synthentizer.Name = "Lbl_Synthentizer";
            this.Lbl_Synthentizer.Size = new System.Drawing.Size(108, 13);
            this.Lbl_Synthentizer.TabIndex = 1;
            this.Lbl_Synthentizer.Text = "Voice Synthentizer is:";
            // 
            // Btn_Synthentizer
            // 
            this.Btn_Synthentizer.Location = new System.Drawing.Point(54, 45);
            this.Btn_Synthentizer.Name = "Btn_Synthentizer";
            this.Btn_Synthentizer.Size = new System.Drawing.Size(57, 23);
            this.Btn_Synthentizer.TabIndex = 0;
            this.Btn_Synthentizer.Text = "Activate";
            this.Btn_Synthentizer.UseVisualStyleBackColor = true;
            // 
            // Lbl_Microphone
            // 
            this.Lbl_Microphone.AutoSize = true;
            this.Lbl_Microphone.Location = new System.Drawing.Point(35, 125);
            this.Lbl_Microphone.Name = "Lbl_Microphone";
            this.Lbl_Microphone.Size = new System.Drawing.Size(76, 13);
            this.Lbl_Microphone.TabIndex = 2;
            this.Lbl_Microphone.Text = "Microphone is:";
            // 
            // Btn_SpeechRecognition
            // 
            this.Btn_SpeechRecognition.Location = new System.Drawing.Point(54, 154);
            this.Btn_SpeechRecognition.Name = "Btn_SpeechRecognition";
            this.Btn_SpeechRecognition.Size = new System.Drawing.Size(57, 23);
            this.Btn_SpeechRecognition.TabIndex = 3;
            this.Btn_SpeechRecognition.Text = "Activate";
            this.Btn_SpeechRecognition.UseVisualStyleBackColor = true;
            // 
            // Lbl_CurrentAudioOutput
            // 
            this.Lbl_CurrentAudioOutput.AutoSize = true;
            this.Lbl_CurrentAudioOutput.Location = new System.Drawing.Point(35, 81);
            this.Lbl_CurrentAudioOutput.Name = "Lbl_CurrentAudioOutput";
            this.Lbl_CurrentAudioOutput.Size = new System.Drawing.Size(109, 13);
            this.Lbl_CurrentAudioOutput.TabIndex = 4;
            this.Lbl_CurrentAudioOutput.Text = "Current Audio Output:";
            // 
            // Lbl_CurrentAudioInput
            // 
            this.Lbl_CurrentAudioInput.AutoSize = true;
            this.Lbl_CurrentAudioInput.Location = new System.Drawing.Point(35, 190);
            this.Lbl_CurrentAudioInput.Name = "Lbl_CurrentAudioInput";
            this.Lbl_CurrentAudioInput.Size = new System.Drawing.Size(101, 13);
            this.Lbl_CurrentAudioInput.TabIndex = 5;
            this.Lbl_CurrentAudioInput.Text = "Current Audio Input:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 574);
            this.Controls.Add(this.VoiceActivation);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "B2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.VoiceActivation.ResumeLayout(false);
            this.VoiceActivation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tbox_num1;
        private System.Windows.Forms.TextBox Tbox_num2;
        private System.Windows.Forms.TextBox Tbox_operation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox VoiceActivation;
        private System.Windows.Forms.Label Lbl_Synthentizer;
        private System.Windows.Forms.Button Btn_Synthentizer;
        private System.Windows.Forms.Label Lbl_CurrentAudioInput;
        private System.Windows.Forms.Label Lbl_CurrentAudioOutput;
        private System.Windows.Forms.Button Btn_SpeechRecognition;
        private System.Windows.Forms.Label Lbl_Microphone;
    }
}

