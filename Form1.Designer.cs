namespace Knopka_Ybegaet
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.пЕРВОЕЗАДАНИЕToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вТОРОЕЗАДАНИЕToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 27);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пЕРВОЕЗАДАНИЕToolStripMenuItem,
            this.вТОРОЕЗАДАНИЕToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 27);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // пЕРВОЕЗАДАНИЕToolStripMenuItem
            // 
            this.пЕРВОЕЗАДАНИЕToolStripMenuItem.Name = "пЕРВОЕЗАДАНИЕToolStripMenuItem";
            this.пЕРВОЕЗАДАНИЕToolStripMenuItem.Size = new System.Drawing.Size(121, 23);
            this.пЕРВОЕЗАДАНИЕToolStripMenuItem.Text = "ПЕРВОЕ ЗАДАНИЕ";
            this.пЕРВОЕЗАДАНИЕToolStripMenuItem.Click += new System.EventHandler(this.пЕРВОЕЗАДАНИЕToolStripMenuItem_Click);
            // 
            // вТОРОЕЗАДАНИЕToolStripMenuItem
            // 
            this.вТОРОЕЗАДАНИЕToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.вТОРОЕЗАДАНИЕToolStripMenuItem.Name = "вТОРОЕЗАДАНИЕToolStripMenuItem";
            this.вТОРОЕЗАДАНИЕToolStripMenuItem.Size = new System.Drawing.Size(140, 23);
            this.вТОРОЕЗАДАНИЕToolStripMenuItem.Text = "ВТОРОЕ ЗАДАНИЕ";
            this.вТОРОЕЗАДАНИЕToolStripMenuItem.Click += new System.EventHandler(this.вТОРОЕЗАДАНИЕToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem пЕРВОЕЗАДАНИЕToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вТОРОЕЗАДАНИЕToolStripMenuItem;
    }
}

