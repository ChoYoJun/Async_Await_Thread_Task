﻿namespace Async_Await_Thread_Task
{
    partial class ThreadTest
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ThreadStart = new System.Windows.Forms.Button();
            this.Suspend = new System.Windows.Forms.Button();
            this.Resume = new System.Windows.Forms.Button();
            this.Interrupt = new System.Windows.Forms.Button();
            this.Threadpool = new System.Windows.Forms.Button();
            this.Join = new System.Windows.Forms.Button();
            this.Abort = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Synchronously = new System.Windows.Forms.Button();
            this.TaskRun = new System.Windows.Forms.Button();
            this.TaskFactory = new System.Windows.Forms.Button();
            this.NewTask = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TaskWaitAll = new System.Windows.Forms.Button();
            this.TaskWaitAny = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.TaskCreationOptions = new System.Windows.Forms.Button();
            this.DenyChildAttach = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 358);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 140);
            this.textBox1.TabIndex = 0;
            // 
            // ThreadStart
            // 
            this.ThreadStart.Location = new System.Drawing.Point(22, 23);
            this.ThreadStart.Name = "ThreadStart";
            this.ThreadStart.Size = new System.Drawing.Size(140, 44);
            this.ThreadStart.TabIndex = 1;
            this.ThreadStart.Text = "ThreadStart";
            this.ThreadStart.UseVisualStyleBackColor = true;
            this.ThreadStart.Click += new System.EventHandler(this.ThreadStart_Click);
            // 
            // Suspend
            // 
            this.Suspend.Location = new System.Drawing.Point(22, 79);
            this.Suspend.Name = "Suspend";
            this.Suspend.Size = new System.Drawing.Size(140, 44);
            this.Suspend.TabIndex = 2;
            this.Suspend.Text = "Suspend";
            this.Suspend.UseVisualStyleBackColor = true;
            this.Suspend.Click += new System.EventHandler(this.Suspend_Click);
            // 
            // Resume
            // 
            this.Resume.Location = new System.Drawing.Point(22, 136);
            this.Resume.Name = "Resume";
            this.Resume.Size = new System.Drawing.Size(140, 44);
            this.Resume.TabIndex = 3;
            this.Resume.Text = "Resume";
            this.Resume.UseVisualStyleBackColor = true;
            this.Resume.Click += new System.EventHandler(this.Resume_Click);
            // 
            // Interrupt
            // 
            this.Interrupt.Location = new System.Drawing.Point(22, 191);
            this.Interrupt.Name = "Interrupt";
            this.Interrupt.Size = new System.Drawing.Size(140, 44);
            this.Interrupt.TabIndex = 4;
            this.Interrupt.Text = "Interrupt";
            this.Interrupt.UseVisualStyleBackColor = true;
            this.Interrupt.Click += new System.EventHandler(this.Interrupt_Click);
            // 
            // Threadpool
            // 
            this.Threadpool.Location = new System.Drawing.Point(20, 25);
            this.Threadpool.Name = "Threadpool";
            this.Threadpool.Size = new System.Drawing.Size(140, 44);
            this.Threadpool.TabIndex = 7;
            this.Threadpool.Text = "ThreadPool";
            this.Threadpool.UseVisualStyleBackColor = true;
            this.Threadpool.Click += new System.EventHandler(this.Threadpool_Click);
            // 
            // Join
            // 
            this.Join.Location = new System.Drawing.Point(22, 304);
            this.Join.Name = "Join";
            this.Join.Size = new System.Drawing.Size(140, 44);
            this.Join.TabIndex = 6;
            this.Join.Text = "Join";
            this.Join.UseVisualStyleBackColor = true;
            this.Join.Click += new System.EventHandler(this.Join_Click);
            // 
            // Abort
            // 
            this.Abort.Location = new System.Drawing.Point(22, 247);
            this.Abort.Name = "Abort";
            this.Abort.Size = new System.Drawing.Size(140, 44);
            this.Abort.TabIndex = 5;
            this.Abort.Text = "Abort";
            this.Abort.UseVisualStyleBackColor = true;
            this.Abort.Click += new System.EventHandler(this.Abort_Click);
            // 
            // Timer
            // 
            this.Timer.Location = new System.Drawing.Point(20, 87);
            this.Timer.Name = "Timer";
            this.Timer.Size = new System.Drawing.Size(140, 44);
            this.Timer.TabIndex = 8;
            this.Timer.Text = "Timer";
            this.Timer.UseVisualStyleBackColor = true;
            this.Timer.Click += new System.EventHandler(this.Timer_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Timer);
            this.groupBox1.Controls.Add(this.Threadpool);
            this.groupBox1.Location = new System.Drawing.Point(197, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 142);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "比较少用";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DenyChildAttach);
            this.groupBox2.Controls.Add(this.TaskCreationOptions);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Location = new System.Drawing.Point(417, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 408);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Task = Thread + ThreadPool + 优化功能";
            // 
            // Synchronously
            // 
            this.Synchronously.Location = new System.Drawing.Point(167, 74);
            this.Synchronously.Name = "Synchronously";
            this.Synchronously.Size = new System.Drawing.Size(137, 36);
            this.Synchronously.TabIndex = 3;
            this.Synchronously.Text = "同步方法";
            this.Synchronously.UseVisualStyleBackColor = true;
            this.Synchronously.Click += new System.EventHandler(this.Synchronously_Click);
            // 
            // TaskRun
            // 
            this.TaskRun.Location = new System.Drawing.Point(167, 21);
            this.TaskRun.Name = "TaskRun";
            this.TaskRun.Size = new System.Drawing.Size(137, 36);
            this.TaskRun.TabIndex = 2;
            this.TaskRun.Text = "TaskRun";
            this.TaskRun.UseVisualStyleBackColor = true;
            this.TaskRun.Click += new System.EventHandler(this.TaskRun_Click);
            // 
            // TaskFactory
            // 
            this.TaskFactory.Location = new System.Drawing.Point(6, 74);
            this.TaskFactory.Name = "TaskFactory";
            this.TaskFactory.Size = new System.Drawing.Size(137, 36);
            this.TaskFactory.TabIndex = 1;
            this.TaskFactory.Text = "TaskFactory";
            this.TaskFactory.UseVisualStyleBackColor = true;
            this.TaskFactory.Click += new System.EventHandler(this.TaskFactory_Click);
            // 
            // NewTask
            // 
            this.NewTask.Location = new System.Drawing.Point(5, 21);
            this.NewTask.Name = "NewTask";
            this.NewTask.Size = new System.Drawing.Size(137, 36);
            this.NewTask.TabIndex = 0;
            this.NewTask.Text = "NewTask";
            this.NewTask.UseVisualStyleBackColor = true;
            this.NewTask.Click += new System.EventHandler(this.NewTask_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Join);
            this.groupBox3.Controls.Add(this.Abort);
            this.groupBox3.Controls.Add(this.Interrupt);
            this.groupBox3.Controls.Add(this.Resume);
            this.groupBox3.Controls.Add(this.Suspend);
            this.groupBox3.Controls.Add(this.ThreadStart);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Location = new System.Drawing.Point(10, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(174, 511);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thread";
            // 
            // TaskWaitAll
            // 
            this.TaskWaitAll.Location = new System.Drawing.Point(26, 26);
            this.TaskWaitAll.Name = "TaskWaitAll";
            this.TaskWaitAll.Size = new System.Drawing.Size(137, 36);
            this.TaskWaitAll.TabIndex = 4;
            this.TaskWaitAll.Text = "TaskWaitAll";
            this.TaskWaitAll.UseVisualStyleBackColor = true;
            this.TaskWaitAll.Click += new System.EventHandler(this.TaskWaitAll_Click);
            // 
            // TaskWaitAny
            // 
            this.TaskWaitAny.Location = new System.Drawing.Point(27, 69);
            this.TaskWaitAny.Name = "TaskWaitAny";
            this.TaskWaitAny.Size = new System.Drawing.Size(137, 36);
            this.TaskWaitAny.TabIndex = 12;
            this.TaskWaitAny.Text = "TaskWaitAny";
            this.TaskWaitAny.UseVisualStyleBackColor = true;
            this.TaskWaitAny.Click += new System.EventHandler(this.TaskWaitAny_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Synchronously);
            this.groupBox4.Controls.Add(this.TaskRun);
            this.groupBox4.Controls.Add(this.TaskFactory);
            this.groupBox4.Controls.Add(this.NewTask);
            this.groupBox4.Location = new System.Drawing.Point(17, 24);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(310, 120);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "启动方法";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.TaskWaitAny);
            this.groupBox5.Controls.Add(this.TaskWaitAll);
            this.groupBox5.Location = new System.Drawing.Point(17, 149);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(183, 116);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "常用阻塞和延续";
            // 
            // TaskCreationOptions
            // 
            this.TaskCreationOptions.Location = new System.Drawing.Point(23, 281);
            this.TaskCreationOptions.Name = "TaskCreationOptions";
            this.TaskCreationOptions.Size = new System.Drawing.Size(180, 36);
            this.TaskCreationOptions.TabIndex = 13;
            this.TaskCreationOptions.Text = "TaskCreationOptions";
            this.TaskCreationOptions.UseVisualStyleBackColor = true;
            this.TaskCreationOptions.Click += new System.EventHandler(this.TaskCreationOptions_Click);
            // 
            // DenyChildAttach
            // 
            this.DenyChildAttach.Location = new System.Drawing.Point(23, 323);
            this.DenyChildAttach.Name = "DenyChildAttach";
            this.DenyChildAttach.Size = new System.Drawing.Size(180, 36);
            this.DenyChildAttach.TabIndex = 14;
            this.DenyChildAttach.Text = "DenyChildAttach";
            this.DenyChildAttach.UseVisualStyleBackColor = true;
            this.DenyChildAttach.Click += new System.EventHandler(this.DenyChildAttach_Click);
            // 
            // ThreadTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 626);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ThreadTest";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ThreadTest_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ThreadStart;
        private System.Windows.Forms.Button Suspend;
        private System.Windows.Forms.Button Resume;
        private System.Windows.Forms.Button Interrupt;
        private System.Windows.Forms.Button Threadpool;
        private System.Windows.Forms.Button Join;
        private System.Windows.Forms.Button Abort;
        private System.Windows.Forms.Button Timer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button NewTask;
        private System.Windows.Forms.Button TaskFactory;
        private System.Windows.Forms.Button Synchronously;
        private System.Windows.Forms.Button TaskRun;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button TaskWaitAll;
        private System.Windows.Forms.Button TaskWaitAny;
        private System.Windows.Forms.Button DenyChildAttach;
        private System.Windows.Forms.Button TaskCreationOptions;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}