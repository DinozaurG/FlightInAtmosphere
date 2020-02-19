namespace FlightInAtmosphere
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.breakButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.timeShow = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.angle = new System.Windows.Forms.Label();
            this.height = new System.Windows.Forms.Label();
            this.speed = new System.Windows.Forms.Label();
            this.inputAngle = new System.Windows.Forms.NumericUpDown();
            this.inputHeight = new System.Windows.Forms.NumericUpDown();
            this.inputSpeed = new System.Windows.Forms.NumericUpDown();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.size = new System.Windows.Forms.Label();
            this.weight = new System.Windows.Forms.Label();
            this.inputSize = new System.Windows.Forms.NumericUpDown();
            this.inputWeight = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.inputWeight);
            this.panel1.Controls.Add(this.inputSize);
            this.panel1.Controls.Add(this.weight);
            this.panel1.Controls.Add(this.size);
            this.panel1.Controls.Add(this.breakButton);
            this.panel1.Controls.Add(this.pauseButton);
            this.panel1.Controls.Add(this.timeShow);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.angle);
            this.panel1.Controls.Add(this.height);
            this.panel1.Controls.Add(this.speed);
            this.panel1.Controls.Add(this.inputAngle);
            this.panel1.Controls.Add(this.inputHeight);
            this.panel1.Controls.Add(this.inputSpeed);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1513, 101);
            this.panel1.TabIndex = 0;
            // 
            // breakButton
            // 
            this.breakButton.Location = new System.Drawing.Point(813, 58);
            this.breakButton.Name = "breakButton";
            this.breakButton.Size = new System.Drawing.Size(75, 23);
            this.breakButton.TabIndex = 9;
            this.breakButton.Text = "Break";
            this.breakButton.UseVisualStyleBackColor = true;
            this.breakButton.Click += new System.EventHandler(this.breakButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.Location = new System.Drawing.Point(712, 13);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(82, 76);
            this.pauseButton.TabIndex = 8;
            this.pauseButton.Text = "Pause";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // timeShow
            // 
            this.timeShow.AutoSize = true;
            this.timeShow.Location = new System.Drawing.Point(810, 13);
            this.timeShow.Name = "timeShow";
            this.timeShow.Size = new System.Drawing.Size(79, 17);
            this.timeShow.TabIndex = 7;
            this.timeShow.Text = "Seconds: 0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(624, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 76);
            this.button1.TabIndex = 6;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // angle
            // 
            this.angle.AutoSize = true;
            this.angle.Location = new System.Drawing.Point(6, 64);
            this.angle.Name = "angle";
            this.angle.Size = new System.Drawing.Size(42, 17);
            this.angle.TabIndex = 5;
            this.angle.Text = "Угол:";
            // 
            // height
            // 
            this.height.AutoSize = true;
            this.height.Location = new System.Drawing.Point(6, 36);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(61, 17);
            this.height.TabIndex = 4;
            this.height.Text = "Высота:";
            // 
            // speed
            // 
            this.speed.AutoSize = true;
            this.speed.Location = new System.Drawing.Point(6, 8);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(73, 17);
            this.speed.TabIndex = 3;
            this.speed.Text = "Скорость:";
            // 
            // inputAngle
            // 
            this.inputAngle.Location = new System.Drawing.Point(97, 64);
            this.inputAngle.Name = "inputAngle";
            this.inputAngle.Size = new System.Drawing.Size(120, 22);
            this.inputAngle.TabIndex = 2;
            // 
            // inputHeight
            // 
            this.inputHeight.Location = new System.Drawing.Point(97, 36);
            this.inputHeight.Name = "inputHeight";
            this.inputHeight.Size = new System.Drawing.Size(120, 22);
            this.inputHeight.TabIndex = 1;
            // 
            // inputSpeed
            // 
            this.inputSpeed.Location = new System.Drawing.Point(97, 8);
            this.inputSpeed.Name = "inputSpeed";
            this.inputSpeed.Size = new System.Drawing.Size(120, 22);
            this.inputSpeed.TabIndex = 0;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(13, 121);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1513, 687);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // size
            // 
            this.size.AutoSize = true;
            this.size.Location = new System.Drawing.Point(239, 12);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(61, 17);
            this.size.TabIndex = 10;
            this.size.Text = "Размер:";
            // 
            // weight
            // 
            this.weight.AutoSize = true;
            this.weight.Location = new System.Drawing.Point(239, 36);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(53, 17);
            this.weight.TabIndex = 11;
            this.weight.Text = "Масса:";
            // 
            // inputSize
            // 
            this.inputSize.Location = new System.Drawing.Point(345, 11);
            this.inputSize.Name = "inputSize";
            this.inputSize.Size = new System.Drawing.Size(120, 22);
            this.inputSize.TabIndex = 12;
            // 
            // inputWeight
            // 
            this.inputWeight.Location = new System.Drawing.Point(345, 36);
            this.inputWeight.Name = "inputWeight";
            this.inputWeight.Size = new System.Drawing.Size(120, 22);
            this.inputWeight.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1532, 820);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputWeight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label angle;
        private System.Windows.Forms.Label height;
        private System.Windows.Forms.Label speed;
        private System.Windows.Forms.NumericUpDown inputAngle;
        private System.Windows.Forms.NumericUpDown inputHeight;
        private System.Windows.Forms.NumericUpDown inputSpeed;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label timeShow;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button breakButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.NumericUpDown inputWeight;
        private System.Windows.Forms.NumericUpDown inputSize;
        private System.Windows.Forms.Label weight;
        private System.Windows.Forms.Label size;
    }
}

