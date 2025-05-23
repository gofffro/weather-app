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
      CityTextBox = new TextBox();
      ServiceComboBox = new ComboBox();
      textBox2 = new TextBox();
      textBox3 = new TextBox();
      WeatherResultLabel = new Label();
      GetWeatherButton = new Button();
      SuspendLayout();
      // 
      // CityTextBox
      // 
      CityTextBox.Location = new Point(30, 48);
      CityTextBox.Name = "CityTextBox";
      CityTextBox.Size = new Size(200, 23);
      CityTextBox.TabIndex = 0;
      // 
      // ServiceComboBox
      // 
      ServiceComboBox.FormattingEnabled = true;
      ServiceComboBox.Items.AddRange(new object[] { "OpenWeather", "AccuWeather" });
      ServiceComboBox.Location = new Point(30, 99);
      ServiceComboBox.Name = "ServiceComboBox";
      ServiceComboBox.Size = new Size(200, 23);
      ServiceComboBox.TabIndex = 2;
      ServiceComboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
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
      // WeatherResultLabel
      // 
      WeatherResultLabel.AutoSize = true;
      WeatherResultLabel.Location = new Point(401, 48);
      WeatherResultLabel.Name = "WeatherResultLabel";
      WeatherResultLabel.Size = new Size(0, 15);
      WeatherResultLabel.TabIndex = 6;
      // 
      // GetWeatherButton
      // 
      GetWeatherButton.Location = new Point(603, 289);
      GetWeatherButton.Name = "GetWeatherButton";
      GetWeatherButton.Size = new Size(219, 57);
      GetWeatherButton.TabIndex = 7;
      GetWeatherButton.Text = "Получить погоду";
      GetWeatherButton.UseVisualStyleBackColor = true;
      GetWeatherButton.Click += GetWeatherButton_Click;
      // 
      // Form1
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(834, 358);
      Controls.Add(GetWeatherButton);
      Controls.Add(WeatherResultLabel);
      Controls.Add(textBox3);
      Controls.Add(textBox2);
      Controls.Add(ServiceComboBox);
      Controls.Add(CityTextBox);
      Name = "Form1";
      Text = "Form1";
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private TextBox CityTextBox;
    private ComboBox ServiceComboBox;
    private TextBox textBox2;
    private TextBox textBox3;
    private Label WeatherResultLabel;
    private Button GetWeatherButton;
  }
}
