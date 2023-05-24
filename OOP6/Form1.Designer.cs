namespace OOP6
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
            check_ctrl = new CheckBox();
            Plus5_button = new Button();
            Minus5_button = new Button();
            delete_button = new Button();
            button4 = new Button();
            button_circle = new Button();
            button_square = new Button();
            button_triangle = new Button();
            button_section = new Button();
            Color_Button = new Button();
            ChoiceAll_button = new Button();
            shapeSize_NumericUpDown = new NumericUpDown();
            Group_Button = new Button();
            save_button = new Button();
            load_button = new Button();
            ((System.ComponentModel.ISupportInitialize)shapeSize_NumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // check_ctrl
            // 
            check_ctrl.AutoSize = true;
            check_ctrl.FlatStyle = FlatStyle.Flat;
            check_ctrl.Location = new Point(10, 215);
            check_ctrl.Margin = new Padding(3, 2, 3, 2);
            check_ctrl.Name = "check_ctrl";
            check_ctrl.Size = new Size(42, 19);
            check_ctrl.TabIndex = 2;
            check_ctrl.TabStop = false;
            check_ctrl.Text = "Ctrl";
            check_ctrl.UseVisualStyleBackColor = true;
            check_ctrl.CheckedChanged += check_ctrl_CheckedChanged;
            // 
            // Plus5_button
            // 
            Plus5_button.FlatStyle = FlatStyle.Popup;
            Plus5_button.Location = new Point(217, 255);
            Plus5_button.Margin = new Padding(3, 2, 3, 2);
            Plus5_button.Name = "Plus5_button";
            Plus5_button.Size = new Size(31, 26);
            Plus5_button.TabIndex = 3;
            Plus5_button.TabStop = false;
            Plus5_button.Text = "+5";
            Plus5_button.UseVisualStyleBackColor = true;
            Plus5_button.Click += Plus5_button_Click;
            // 
            // Minus5_button
            // 
            Minus5_button.FlatStyle = FlatStyle.Popup;
            Minus5_button.Location = new Point(217, 301);
            Minus5_button.Margin = new Padding(3, 2, 3, 2);
            Minus5_button.Name = "Minus5_button";
            Minus5_button.Size = new Size(31, 26);
            Minus5_button.TabIndex = 4;
            Minus5_button.TabStop = false;
            Minus5_button.Text = "-5";
            Minus5_button.UseVisualStyleBackColor = true;
            Minus5_button.Click += Minus5_button_Click;
            // 
            // delete_button
            // 
            delete_button.FlatStyle = FlatStyle.Popup;
            delete_button.Location = new Point(10, 255);
            delete_button.Margin = new Padding(3, 2, 3, 2);
            delete_button.Name = "delete_button";
            delete_button.Size = new Size(88, 26);
            delete_button.TabIndex = 5;
            delete_button.TabStop = false;
            delete_button.Text = "Удалить";
            delete_button.UseVisualStyleBackColor = true;
            delete_button.Click += delete_button_Click;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Popup;
            button4.Location = new Point(114, 301);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(88, 26);
            button4.TabIndex = 7;
            button4.TabStop = false;
            button4.Text = "Снять выбор";
            button4.UseVisualStyleBackColor = true;
            button4.Click += removeSelection_button_Click;
            // 
            // button_circle
            // 
            button_circle.BackgroundImageLayout = ImageLayout.Stretch;
            button_circle.FlatStyle = FlatStyle.Popup;
            button_circle.Location = new Point(10, 13);
            button_circle.Margin = new Padding(3, 2, 3, 2);
            button_circle.Name = "button_circle";
            button_circle.Size = new Size(88, 38);
            button_circle.TabIndex = 8;
            button_circle.Text = "Круг";
            button_circle.UseVisualStyleBackColor = true;
            button_circle.Click += button_circle_Click;
            // 
            // button_square
            // 
            button_square.BackgroundImageLayout = ImageLayout.Stretch;
            button_square.FlatStyle = FlatStyle.Popup;
            button_square.Location = new Point(10, 55);
            button_square.Margin = new Padding(3, 2, 3, 2);
            button_square.Name = "button_square";
            button_square.Size = new Size(88, 38);
            button_square.TabIndex = 9;
            button_square.Text = "Квадрат";
            button_square.UseVisualStyleBackColor = true;
            button_square.Click += button_square_Click;
            // 
            // button_triangle
            // 
            button_triangle.BackgroundImageLayout = ImageLayout.Stretch;
            button_triangle.FlatStyle = FlatStyle.Popup;
            button_triangle.Location = new Point(104, 55);
            button_triangle.Margin = new Padding(3, 2, 3, 2);
            button_triangle.Name = "button_triangle";
            button_triangle.Size = new Size(88, 38);
            button_triangle.TabIndex = 10;
            button_triangle.Text = "Треугольник";
            button_triangle.UseVisualStyleBackColor = true;
            button_triangle.Click += button_triangle_Click;
            // 
            // button_section
            // 
            button_section.BackgroundImageLayout = ImageLayout.Stretch;
            button_section.FlatStyle = FlatStyle.Popup;
            button_section.Location = new Point(104, 13);
            button_section.Margin = new Padding(3, 2, 3, 2);
            button_section.Name = "button_section";
            button_section.Size = new Size(88, 38);
            button_section.TabIndex = 11;
            button_section.Text = "Отрезок";
            button_section.UseVisualStyleBackColor = true;
            button_section.Click += button_section_Click;
            // 
            // Color_Button
            // 
            Color_Button.BackColor = Color.Black;
            Color_Button.BackgroundImageLayout = ImageLayout.Center;
            Color_Button.FlatStyle = FlatStyle.Popup;
            Color_Button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Color_Button.ForeColor = SystemColors.Control;
            Color_Button.Location = new Point(10, 97);
            Color_Button.Margin = new Padding(3, 2, 3, 2);
            Color_Button.Name = "Color_Button";
            Color_Button.Size = new Size(182, 26);
            Color_Button.TabIndex = 12;
            Color_Button.Text = "Color";
            Color_Button.UseVisualStyleBackColor = false;
            Color_Button.Click += Color_Button_Click;
            // 
            // ChoiceAll_button
            // 
            ChoiceAll_button.FlatStyle = FlatStyle.Popup;
            ChoiceAll_button.Location = new Point(10, 301);
            ChoiceAll_button.Margin = new Padding(3, 2, 3, 2);
            ChoiceAll_button.Name = "ChoiceAll_button";
            ChoiceAll_button.Size = new Size(88, 26);
            ChoiceAll_button.TabIndex = 13;
            ChoiceAll_button.TabStop = false;
            ChoiceAll_button.Text = "Выбрать все";
            ChoiceAll_button.UseVisualStyleBackColor = true;
            ChoiceAll_button.Click += ChoiceAll_button_Click;
            // 
            // shapeSize_NumericUpDown
            // 
            shapeSize_NumericUpDown.Location = new Point(114, 255);
            shapeSize_NumericUpDown.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            shapeSize_NumericUpDown.Name = "shapeSize_NumericUpDown";
            shapeSize_NumericUpDown.Size = new Size(88, 23);
            shapeSize_NumericUpDown.TabIndex = 16;
            shapeSize_NumericUpDown.Value = new decimal(new int[] { 10, 0, 0, 0 });
            shapeSize_NumericUpDown.ValueChanged += shapeSize_NumericUpDown_ValueChanged;
            // 
            // Group_Button
            // 
            Group_Button.FlatStyle = FlatStyle.Popup;
            Group_Button.Location = new Point(104, 217);
            Group_Button.Name = "Group_Button";
            Group_Button.Size = new Size(112, 23);
            Group_Button.TabIndex = 17;
            Group_Button.Text = "Сгруппировать";
            Group_Button.UseVisualStyleBackColor = true;
            Group_Button.Click += Group_Button_Click;
            // 
            // save_button
            // 
            save_button.FlatStyle = FlatStyle.Popup;
            save_button.Location = new Point(10, 128);
            save_button.Name = "save_button";
            save_button.Size = new Size(88, 23);
            save_button.TabIndex = 18;
            save_button.Text = "Сохранить";
            save_button.UseVisualStyleBackColor = true;
            save_button.Click += save_button_Click;
            // 
            // load_button
            // 
            load_button.FlatStyle = FlatStyle.Popup;
            load_button.Location = new Point(104, 128);
            load_button.Name = "load_button";
            load_button.Size = new Size(88, 23);
            load_button.TabIndex = 19;
            load_button.Text = "Загрузить";
            load_button.UseVisualStyleBackColor = true;
            load_button.Click += load_button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(load_button);
            Controls.Add(save_button);
            Controls.Add(Group_Button);
            Controls.Add(shapeSize_NumericUpDown);
            Controls.Add(ChoiceAll_button);
            Controls.Add(Color_Button);
            Controls.Add(button_section);
            Controls.Add(button_triangle);
            Controls.Add(button_square);
            Controls.Add(button_circle);
            Controls.Add(button4);
            Controls.Add(delete_button);
            Controls.Add(Minus5_button);
            Controls.Add(Plus5_button);
            Controls.Add(check_ctrl);
            KeyPreview = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            SizeChanged += Form1_SizeChanged;
            Paint += Form1_Paint;
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            MouseClick += Form1_MouseClick;
            ((System.ComponentModel.ISupportInitialize)shapeSize_NumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckBox check_ctrl;
        private Button Plus5_button;
        private Button Minus5_button;
        private Button delete_button;
        private Button button4;
        private Button button_circle;
        private Button button_square;
        private Button button_triangle;
        private Button button_section;
        private Button Color_Button;
        private Button ChoiceAll_button;
        private NumericUpDown shapeSize_NumericUpDown;
        private Button Group_Button;
        private Button save_button;
        private Button load_button;
    }
}