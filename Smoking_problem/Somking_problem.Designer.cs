namespace Smoking_problem
{
    partial class Somking_problem
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Somking_problem));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.agent = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.smoker3 = new System.Windows.Forms.PictureBox();
            this.smoker2 = new System.Windows.Forms.PictureBox();
            this.smoker1 = new System.Windows.Forms.PictureBox();
            this.start = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agent)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.smoker3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smoker2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smoker1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.agent);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 314);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agent";
            // 
            // agent
            // 
            this.agent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("agent.BackgroundImage")));
            this.agent.Location = new System.Drawing.Point(20, 35);
            this.agent.Name = "agent";
            this.agent.Size = new System.Drawing.Size(160, 260);
            this.agent.TabIndex = 0;
            this.agent.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.smoker3);
            this.groupBox2.Controls.Add(this.smoker2);
            this.groupBox2.Controls.Add(this.smoker1);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(228, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(534, 314);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Smokers";
            // 
            // smoker3
            // 
            this.smoker3.BackgroundImage = global::Smoking_problem.Resource1.somker_wait;
            this.smoker3.Location = new System.Drawing.Point(354, 35);
            this.smoker3.Name = "smoker3";
            this.smoker3.Size = new System.Drawing.Size(160, 260);
            this.smoker3.TabIndex = 2;
            this.smoker3.TabStop = false;
            // 
            // smoker2
            // 
            this.smoker2.BackgroundImage = global::Smoking_problem.Resource1.somker_wait;
            this.smoker2.Location = new System.Drawing.Point(187, 35);
            this.smoker2.Name = "smoker2";
            this.smoker2.Size = new System.Drawing.Size(160, 260);
            this.smoker2.TabIndex = 1;
            this.smoker2.TabStop = false;
            // 
            // smoker1
            // 
            this.smoker1.BackgroundImage = global::Smoking_problem.Resource1.somker_wait;
            this.smoker1.Location = new System.Drawing.Point(20, 35);
            this.smoker1.Name = "smoker1";
            this.smoker1.Size = new System.Drawing.Size(160, 260);
            this.smoker1.TabIndex = 0;
            this.smoker1.TabStop = false;
            // 
            // start
            // 
            this.start.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.start.Location = new System.Drawing.Point(312, 336);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(150, 63);
            this.start.TabIndex = 2;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // Somking_problem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(775, 409);
            this.Controls.Add(this.start);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Somking_problem";
            this.Text = "Somking Problem by CS1504 WangXuSheng";
            this.Load += new System.EventHandler(this.Somking_problem_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.agent)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.smoker3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smoker2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smoker1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox agent;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox smoker3;
        private System.Windows.Forms.PictureBox smoker2;
        private System.Windows.Forms.PictureBox smoker1;
        private System.Windows.Forms.Button start;
    }
}

