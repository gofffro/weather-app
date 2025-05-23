namespace weather_app
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
      textBox1 = new TextBox();
      comboBox1 = new ComboBox();
      textBox2 = new TextBox();
      textBox3 = new TextBox();
      label1 = new Label();
      GetWeatherButton = new Button();
      SuspendLayout();
      // 
      // textBox1
      // 
      textBox1.Location = new Point(30, 48);
      textBox1.Name = "textBox1";
      textBox1.Size = new Size(200, 23);
      textBox1.TabIndex = 0;
      // 
      // comboBox1
      // 
      comboBox1.FormattingEnabled = true;
      comboBox1.Items.AddRange(new object[] { "OpenWeather", "YandexWeather" });
      comboBox1.Location = new Point(30, 99);
      comboBox1.Name = "comboBox1";
      comboBox1.Size = new Size(200, 23);
      comboBox1.TabIndex = 2;
      comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
      // 
      // textBox2
      // 
      textBox2.BackColor = SystemColors.Control;
      textBox2.BorderStyle = BorderStyle.None;
      textBox2.Location = new Point(30, 26);
      textBox2.Name = "textBox2";
      textBox2.ReadOnly = true;
      textBox2.Size = new Size(200, 16);
      textBox2.TabIndex = 3;
      textBox2.Text = "Введите название города:";
      // 
      // textBox3
      // 
      textBox3.BackColor = SystemColors.Control;
      textBox3.BorderStyle = BorderStyle.None;
      textBox3.Location = new Point(30, 77);
      textBox3.Name = "textBox3";
      textBox3.ReadOnly = true;
      textBox3.Size = new Size(200, 16);
      textBox3.TabIndex = 5;
      textBox3.Text = "Выберите сервис погоды:";
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Location = new Point(401, 48);
      label1.Name = "label1";
      label1.Size = new Size(13, 15);
      label1.TabIndex = 6;
      label1.Text = "1";
      // 
      // GetWeatherButton
      // 
      GetWeatherButton.Location = new Point(603, 289);
      GetWeatherButton.Name = "GetWeatherButton";
      GetWeatherButton.Size = new Size(219, 57);
      GetWeatherButton.TabIndex = 7;
      GetWeatherButton.Text = "Получить погоду";
      GetWeatherButton.UseVisualStyleBackColor = true;
      // 
      // Form1
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(834, 358);
      Controls.Add(GetWeatherButton);
      Controls.Add(label1);
      Controls.Add(textBox3);
      Controls.Add(textBox2);
      Controls.Add(comboBox1);
      Controls.Add(textBox1);
      Name = "Form1";
      Text = "Form1";
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private TextBox textBox1;
    private ComboBox comboBox1;
    private TextBox textBox2;
    private TextBox textBox3;
    private Label label1;
    private Button GetWeatherButton;
  }
}
